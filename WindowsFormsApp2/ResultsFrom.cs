using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp2.Program;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using LiveCharts;
using Microsoft.EntityFrameworkCore;
using System.Data.Linq;

namespace WindowsFormsApp2
{
    public partial class ResultsFrom : Form
    {
        ApplicationContext db = new ApplicationContext();
       
        bool nextForm = false;
        private SaveFileDialog sfd;
        private string filepath;
        bool loaded;
        Color currentLabelColor;
        public ResultsFrom(bool loadedToDb)
        {
            loaded = loadedToDb;
        
            InitializeComponent();
            if (loaded == false)
              UpadteDatabaseAsync();
        }
    
        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!nextForm)
            {
                var result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтвердите действие", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                    this.Show();
                }         
            }
        }
      

        private void Form8_Load(object sender, EventArgs e)
        {
            label3.Text = OutData.NumberOfRepresentations.ToString();
            label4.Text = OutData.NumberOfIndicators.ToString();
            label5.Text = GetAverageTime().ToString();
            // гарантируем, что база данных создана
            db.Database.EnsureCreated();
            // загружаем данные из БД
            db.Datas.Load();
            
        }
        private StringBuilder ReturnTypesString()
        {
            StringBuilder sb = new StringBuilder();
            var ordered = OutData.types.OrderBy(n => n);// по возрастанию
           
            foreach (var type in ordered)
            {
                sb.Append("Тип " + type.ToString() + " \n");
            }
           
            return sb;
        }
        private StringBuilder ReturnReprTimeString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var reprTime in OutData.reprTime)
            {
                sb.Append("Опыт " + reprTime.Key.ToString() + " " + reprTime.Value.ToString() + " \n");
            }
            return sb;
        }
        private StringBuilder ReturnReprTimeStringDBEd()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var reprTime in OutData.reprTime)
            {
                sb.Append(reprTime.Key.ToString() + " " + reprTime.Value.ToString() + " \n");
            }
            return sb;
        }
        private string GetAverageTime()
        {
            TimeSpan averageTime = TimeSpan.Zero;
            foreach (var reprTime in OutData.reprTime)
            {
                averageTime = averageTime.Add(reprTime.Value);
            }
            return (Convert.ToDouble(averageTime.TotalSeconds)/ OutData.NumberOfRepresentations).ToString("F4");//IN SECONDS
        }
        private async Task UpadteDatabaseAsync()

        {
            db.Database.EnsureCreated();
          
            var all = db.Datas.ToList();
            var result = (from d in all where d.Name == OutData.Name where d.Group == OutData.Group where d.NumberOfIndicators == OutData.NumberOfIndicators where d.NumberOfRepresentations == OutData.NumberOfRepresentations  select d);
            if (result.Count() == 0)
            {
 Data data = new Data();
            data.Name = OutData.Name;
            data.Group= OutData.Group;
            data.NumberOfRepresentations= OutData.NumberOfRepresentations;
            data.NumberOfIndicators= OutData.NumberOfIndicators;
            data.Types = ReturnTypesString().ToString();
            data.ReprTime = ReturnReprTimeStringDBEd().ToString();
            data.AverageTime = GetAverageTime().ToString();
            db.Datas.Add(data);
            db.SaveChanges();
            }
        }
        private async Task FillFileAsync()
        {
            if (File.Exists(filepath))
            {
                using (StreamWriter writer = new StreamWriter(filepath, true))//дозапись
                {
                    await writer.WriteLineAsync($"Количество предъявлений: {OutData.NumberOfRepresentations}\nКоличество индикаторов: {OutData.NumberOfIndicators}");
                    await writer.WriteAsync("Использованные типы индикаторов:\n" + ReturnTypesString().ToString());
                    await writer.WriteAsync("Время информационного поиска:\n" + ReturnReprTimeString().ToString());
                    await writer.WriteAsync("Общее среднее экспериментальное значение:\n" + GetAverageTime() + "\n\n");

                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(filepath, false))//созданіе і запісь 
                {
                    await writer.WriteLineAsync($"Имя: {OutData.Name} \nНомер группы: {OutData.Group}");
                    await writer.WriteLineAsync($"Количество предъявлений: {OutData.NumberOfRepresentations}\nКоличество индикаторов: {OutData.NumberOfIndicators}");
                    await writer.WriteAsync("Использованные типы индикаторов:\n" + ReturnTypesString().ToString());
                    await writer.WriteAsync("Время информационного поиска:\n" + ReturnReprTimeString().ToString());
                    await writer.WriteAsync("Общее среднее экспериментальное значение:\n" + GetAverageTime() + "\n\n");

                }
            }
        }

        private void roundCornerButton1_Click(object sender, EventArgs e)
        {
            sfd = new SaveFileDialog
            {
                Filter = "Text files(*.txt)|*.txt",
                OverwritePrompt = true
            };
          
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filepath = sfd.FileName;
            }

            try
            {        
                FillFileAsync();
                MessageBox.Show("Сохранено!");
            }
            catch
            {
                MessageBox.Show("Ошибка! Попробуйте еще раз.");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            nextForm = true;
            this.Hide();
            ModeChoiceForm form1 = new ModeChoiceForm();
            form1.Show();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            currentLabelColor = label2.ForeColor;
            label2.ForeColor = Color.FromKnownColor(KnownColor.Highlight);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = currentLabelColor;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            nextForm = true;
            OutData.reprTime.Clear();
            OutData.types.Clear();
            this.Hide();
            SetSettingsForm1 form5 = new SetSettingsForm1();
            form5.Show();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            currentLabelColor = label1.ForeColor;
            label1.ForeColor = Color.FromKnownColor(KnownColor.Highlight);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = currentLabelColor;
        }

        private void roundCornerButton1_MouseEnter(object sender, EventArgs e)
        {
           // label8.Visible = true;
        }

        private void roundCornerButton1_MouseLeave(object sender, EventArgs e)
        {
            //label8.Visible = false;

        }

        private void roundCornerButton2_MouseEnter(object sender, EventArgs e)
        {
           // label12.Visible = true;
        }

        private void roundCornerButton2_MouseLeave(object sender, EventArgs e)
        {

           // label12.Visible = false;
        }

        private void roundCornerButton2_Click(object sender, EventArgs e)
        {
            nextForm = true;
            this.Hide(); 
            ResultsVisualizationForm form10 = new ResultsVisualizationForm();
            form10.Show();
        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
