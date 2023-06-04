using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static WindowsFormsApp2.Program;

namespace WindowsFormsApp2
{
    public partial class ResultsVisualizationForm : Form
    {
        ApplicationContext db = new ApplicationContext();

        List<int> NumOfInd = new List<int>();
        List<double> AverageTime = new List<double>();
        List<double> TeoretAverageTime = new List<double>();
        bool nextForm = false;
       
        public ResultsVisualizationForm()
        {
            InitializeComponent();
            db.Database.EnsureCreated();
            // загружаем данные из БД
            db.Datas.Load();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            nextForm = true;
            this.Hide();
            ResultsFrom form8 = new ResultsFrom(true);
            form8.Show();
        }

        private void Form10_FormClosing(object sender, FormClosingEventArgs e)
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
        private void GetExpData()
        {
            try
            {
                var data = db.Datas.ToList();
                var result =( from d in data where d.Name == OutData.Name where d.Group== OutData.Group select d);
                
               foreach(var r in result)
                {                             
                                NumOfInd.Add(Convert.ToInt32(r.NumberOfIndicators));
                                AverageTime.Add(Convert.ToDouble(r.AverageTime) * 100);//СЕКУНДЫ *100
                }
                            
            }

            catch
            {
            }
        }
        private void TeoretValues()
        {
            int alpha = 1;
            double timeInfInSeconds;
            for (int i = 0; i < NumOfInd.Count; i++)
            {
                timeInfInSeconds = (NumOfInd[i] / alpha + 1) * 0.640 / 2;//СЕКУНДЫ *100
                TeoretAverageTime.Add(timeInfInSeconds * 100);
            }
        }
        private void Form10_Load(object sender, EventArgs e)
        {
            GetExpData();
            TeoretValues();
            var values = new ChartValues<Point>();
            for (int i = 0; i < NumOfInd.Count; i++)
            {
                var point = new Point() { X = NumOfInd[i], Y = (int)AverageTime[i] };
                values.Add(point);
            }
            var teorValues = new ChartValues<Point>();
            for (int i = 0; i < NumOfInd.Count; i++)
            {
                var point = new Point() { X = NumOfInd[i], Y = (int)TeoretAverageTime[i] };
                teorValues.Add(point);
            }
            cartesianChart1.Series = new SeriesCollection()
            {
                new LineSeries
    {
      Configuration = new CartesianMapper<Point>().X(point => point.X).Y(point => point.Y),
      Title = "Экспериментальные значения времени информационного поиска (сек*10^2)",
      Values = values,
        Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(59,244,95)),
         Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(47,59,244,95)),

      PointGeometrySize = 10
    },
            new LineSeries          
    {
        Configuration = new CartesianMapper<Point>()
        .X(point => point.X)
        .Y(point => point.Y),
        Title = "Теоретические значения времени информационного поиска (сек*10^2)",
        Values = teorValues,
        Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(126,193,255)),
         Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(47,126,193,255)),
            PointGeometrySize = 10
    }

        };
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromKnownColor(KnownColor.Highlight); ;
        }
        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.DimGray;
        }

        private void Form10_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
