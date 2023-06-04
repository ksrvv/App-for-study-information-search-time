using Aspose.Cells;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp2.Program;

namespace WindowsFormsApp2
{
    public partial class AllResultsForm : Form
    {
        ApplicationContext db = new ApplicationContext();
        bool nextForm = false;    
       
        private SaveFileDialog sfd;
        public AllResultsForm()
        {
            InitializeComponent();
            LoadData();
            for(int i=0; i< dataGridView1.Rows.Count; i++)  dataGridView1.Rows[i].Height = 200; 
           

            //this.Width = (int)(ClientSize.Width);
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // гарантируем, что база данных создана
            db.Database.EnsureCreated();
            // загружаем данные из БД
            db.Datas.Load();
           
            Reload();
            dataGridView1.Location = new Point(0, 0);
            sfd = new SaveFileDialog
            {
                Filter = ".xlsx Files (*.xlsx)|*.xlsx",
                OverwritePrompt = true
            };





        }
        void Reload()
        {
            dataGridView1.Height = this.Height - 220;
            dataGridView1.Width = this.Width - 25;
            roundCornerButton1.Location = new Point(this.Width / 2 - roundCornerButton1.Width / 2, dataGridView1.Height + 60);
            label1.Location = new Point(23, roundCornerButton1.Location.Y + roundCornerButton1.Height/2);
            label2.Location = new Point(this.Width/2- label2.Width/2, this.Height/2);

        }

        private void LoadData()
        {
            try
            {
                var datas = db.Datas.ToList();
                if (datas.Count > 0)
                {
                    label2.Visible = false;
                    foreach (var d in datas) {
                    dataGridView1.Rows.Add(d.Name, d.Group, d.NumberOfRepresentations,  d.NumberOfIndicators, GetIndImages( d.Types), d.AverageTime);
                    }
                }
                else
                {
                    dataGridView1.Visible = false;
                    roundCornerButton1.Visible = false;
                    label2.Visible = true;
                }

            }
            catch 
            {
                
                dataGridView1.Visible = false;
                roundCornerButton1.Visible = false;
                label2.Visible = true;
               
            }
            
        }
        private Image GetIndImages(string types)
        {
            Image image;
            if (types.Length==7)
            {
                char typeNum = types[4];
               
                    image = Image.FromFile($"{Directory.GetCurrentDirectory()}\\StimulMat\\Normal\\Type-{typeNum}.png");
               
            }
            else if (types.Length == 14)
            {
                char firstType = types[4];
                char secondType = types[11];
               
              
                    image = Image.FromFile($"{Directory.GetCurrentDirectory()}\\StimulMat\\Normal\\Type-{firstType}-{secondType}.png");
               
              
                
            }
            else if (types.Length == 21)
            {
                char firstType = types[4];
                char secondType = types[11];
                char thirdType = types[18];
                image = Image.FromFile($"{Directory.GetCurrentDirectory()}\\StimulMat\\Normal\\Type-{firstType}-{secondType}-{thirdType}.png");

            }
            else image = Image.FromFile($"{Directory.GetCurrentDirectory()}\\StimulMat\\Normal\\Type-1-2-3-4.png");
            return image;
        }
        private void roundCornerButton1_Click(object sender, EventArgs e)
        {
            Workbook workbookForDataTable = new Workbook();

            DataTable dt = GetData();

            ImportTableOptions importOptions = new ImportTableOptions();

            Worksheet dataTableWorksheet = workbookForDataTable.Worksheets[0];

            dataTableWorksheet.Cells.ImportData(dt, 0, 0, importOptions);

            dataTableWorksheet.AutoFitColumns();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                workbookForDataTable.Save(sfd.FileName);
                MessageBox.Show("Сохранено!");
            }


        }
        private DataTable GetData()
        {


            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            dt.Columns.Add("Имя испытуемого");
            dt.Columns.Add("№ группы");
            dt.Columns.Add("Количество предъявлений");
            dt.Columns.Add("Количество индикаторов");
            dt.Columns.Add("Тип индикаторов");



            dt.Columns.Add("Время инф. поиска для каждого предъявления");
            dt.Columns.Add("Среднее эксперментальное значение");
            dt.Columns.Add("Дата проведения теста");
            var source = db.Datas.ToList();
            try
            {
                foreach (var c in source)
                {
                    DataRow dr = dt.Rows.Add();
                    dr.SetField("Имя испытуемого", c.Name);
                    dr.SetField("№ группы", c.Group);
                    dr.SetField("Количество предъявлений", c.NumberOfRepresentations);
                    dr.SetField("Количество индикаторов", c.NumberOfIndicators);

                    dr.SetField("Тип индикаторов", c.Types);
                    dr.SetField("Время инф. поиска для каждого предъявления", c.ReprTime);
                    dr.SetField("Среднее эксперментальное значение", c.AverageTime);
                    dr.SetField("Дата проведения теста", c.date);



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            return dt;
        }
       
        private void Form9_SizeChanged(object sender, EventArgs e)
        {
            Reload();
            roundCornerButton1.Refresh();
            dataGridView1.Refresh();
            label1.Refresh();
        }

        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
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
            else
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            nextForm = true;
            this.Hide();
            ModeChoiceForm form1 = new ModeChoiceForm();
            form1.Show();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromKnownColor(KnownColor.Highlight); 
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.DimGray;

        }

        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
