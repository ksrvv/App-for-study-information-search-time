using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class ExperimentalSeriesForm : Form
    {
        bool nextForm = false;
        int counter = 0;
        int numofRows; int numInRow; int x; int y; int pbwidth; int pbheight; int padding;
        int representationsCounter = 0;
        int numOfRepr;
        DateTime starttime;
        DateTime endtime;
        int rightsCounter = 0;
        bool sTestSeries;
        PictureBox PBReaction;
        public ExperimentalSeriesForm(bool isTestSeries)
        {
            sTestSeries = isTestSeries;
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            this.Size = new Size(resolution.Width, resolution.Height);

            numInRow = OutData.NumberOfIndicators / 2;//num of indicators /2

            switch (numInRow)
            {
                case 2:
                case 3:
                    padding = 200; pbheight = 300;
                    pbwidth = 400; y = 100; numofRows = 2; break;
                case 4:
                    padding = 100; pbheight = 250;
                    pbwidth = 300; y = 200; numofRows = 2; numInRow = OutData.NumberOfIndicators / numofRows; break;
                case 6:
                    padding = 100; pbheight = 200;
                    pbwidth = 250; y = 100; numofRows = 3; numInRow = OutData.NumberOfIndicators / numofRows; break;
                default:
                    padding = 100; pbheight = 200;
                    pbwidth = 250; y = 100; numofRows = 3; numInRow = OutData.NumberOfIndicators / numofRows; break;
            }
            x = (this.Size.Width / 2 - pbwidth * numInRow / 2 - padding * (numInRow - 1) / 2);
            numOfRepr = OutData.NumberOfRepresentations;
            UploadIndicators(numofRows, numInRow, x, y, pbwidth, pbheight, padding);
        }
        private void GetBgTimerEnabled()
        {
            timer1.Interval = 200;

            timer1.Enabled = true;//
        }
        private void PictureBoxesRight_Click(object sender, EventArgs e)
        {
            rightsCounter++;
            endtime = DateTime.Now;
            OutData.reprTime.Add(rightsCounter, endtime - starttime);
            GetBgTimerEnabled();
            counter = 0;
            this.Controls.Clear();
            timer2.Interval = 1000;
            timer2.Enabled = true;
        }
        private void PictureBoxesWrong_Click(object sender, EventArgs e)
        {
            GetBgTimerEnabled();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Dispose();
        }
        private void UploadIndicators(int numofRows, int numInRow, int x, int y, int pbwidth, int pbheight, int padding)
        {
            starttime = DateTime.Now;
            Random rand = new Random();

            int posOfErrPic = rand.Next(0, OutData.NumberOfIndicators);
            for (int i = 0; i < numofRows; i++)
            {
                for (int j = 0; j < numInRow; j++)
                {
                    int pic = rand.Next(1, 4);
                    int type;
                    PictureBox pictureBox = new System.Windows.Forms.PictureBox();
                    pictureBox.Location = new System.Drawing.Point(x, y);
                    pictureBox.Size = new System.Drawing.Size(pbwidth, pbheight);

                    Controls.Add(pictureBox);
                    x = x + pbwidth + padding;

                    if (counter == posOfErrPic)
                    {//
                        if (OutData.types.Count == 1)
                        {
                            pictureBox.Image = System.Drawing.Image.FromFile($"{Directory.GetCurrentDirectory()}\\StimulMat\\Reaction\\Type{OutData.types[0]}-{4}.gif");

                        }
                        if (OutData.types.Count == 4)
                        {
                            type = rand.Next(1, 5);
                            pictureBox.Image = System.Drawing.Image.FromFile($"{Directory.GetCurrentDirectory()}\\StimulMat\\Reaction\\Type{type}-{4}.gif");

                        }
                        else
                        {
                            int randIndex = rand.Next(0, OutData.types.Count);
                            type = OutData.types[randIndex];
                            pictureBox.Image = System.Drawing.Image.FromFile($"{Directory.GetCurrentDirectory()}\\StimulMat\\Reaction\\Type{type}-{4}.gif");

                        }
                        PBReaction = pictureBox;
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.MouseClick += PictureBoxesRight_Click;
                    }
                    else
                    {
                        if (OutData.types.Count == 1)
                        {
                            pictureBox.Image = System.Drawing.Image.FromFile($"{Directory.GetCurrentDirectory()}\\StimulMat\\Normal\\Type{OutData.types[0]}-{pic}.gif");
                        }
                        if (OutData.types.Count == 4)
                        {
                            type = rand.Next(1, 5);
                            pictureBox.Image = System.Drawing.Image.FromFile($"{Directory.GetCurrentDirectory()}\\StimulMat\\Normal\\Type{type}-{pic}.gif");

                        }
                        else
                        {
                            int randIndex = rand.Next(0, OutData.types.Count);
                            type = OutData.types[randIndex];
                            pictureBox.Image = System.Drawing.Image.FromFile($"{Directory.GetCurrentDirectory()}\\StimulMat\\Normal\\Type{type}-{pic}.gif");

                        }

                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.MouseClick += PictureBoxesWrong_Click;
                        pictureBox.Name = "PBWrongReaction";
                    }
                    counter++;
                }
                x = (this.Size.Width / 2 - pbwidth * numInRow / 2 - padding * (numInRow - 1) / 2);
                y = y + pbheight + padding;
            }
            representationsCounter++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            timer2.Dispose();
           
            if (representationsCounter == numOfRepr)
            {
                timer1.Dispose();
                rightsCounter = 0;
                representationsCounter = 0;
                nextForm = true;
                if (!sTestSeries)
                {
                   
this.Hide();
                   
                    ResultsFrom form8 = new ResultsFrom(false);
                    form8.Show();
                    
                    
                }
                else
                {
                    rightsCounter = 0;
                    representationsCounter = 0;
                    OutData.reprTime.Clear();
                    OutData.types.Clear();
                    //UPLOaddata in file
                    this.Hide(); 
                    SetSettingsForm1 form5 = new SetSettingsForm1();
                    form5.Show();
                }
            }
            else
            {

                UploadIndicators(numofRows, numInRow, x, y, pbwidth, pbheight, padding);
            }

        }

       
      
        private string GetAverageTime()
        {
            TimeSpan averageTime = TimeSpan.Zero;
            foreach (var reprTime in OutData.reprTime)
            {
                averageTime = averageTime.Add(reprTime.Value);
            }
            return (Convert.ToDouble(averageTime.TotalSeconds) / OutData.NumberOfRepresentations).ToString("F4");//IN SECONDS
        }
        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!nextForm)
            {
                var result = MessageBox.Show("Вы уверены, что хотите выйти? Внимание, ваши данные не сохранятся!", "Подтвердите действие", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                    this.Show();
                }
            }
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
