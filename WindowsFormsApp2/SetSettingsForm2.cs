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
    public partial class SetSettingsForm2 : Form
    {
        bool nextForm = false;
        public ErrorsHandler errorsHandler = new ErrorsHandler();
        bool isTestSeries = false;
        public SetSettingsForm2()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label3.Location = new Point(this.Width / 2, 30);
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
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
        private void UpdateTypesList(int n)
        {
            if (OutData.types.Contains(n))
            {
                OutData.types.Remove(n);
            }
            else
            {
                OutData.types.Add(n);
            }
        }
        private void checkBoxType1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTypesList(1);
        }

        private void checkBoxType4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTypesList(4);
        }

        private void checkBoxType3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTypesList(3);

        }
        private void checkBoxType2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTypesList(2);
        }
        private void LoadTestForm(bool isTestSeries)
        {
            if (OutData.types.Count == 0)
                errorsHandler.EmptyIndicatorTypesList();
           
            else
            {
                nextForm = true;
                this.Hide();
                ExperimentalSeriesForm form7 = new ExperimentalSeriesForm(isTestSeries);
                form7.Show();
            }
        }

        private void roundCornerButton1_Click(object sender, EventArgs e)
        {
            isTestSeries = true;
            LoadTestForm(isTestSeries);
        }

        private void roundCornerButton2_Click(object sender, EventArgs e)
        {
            LoadTestForm(isTestSeries);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image= System.Drawing.Image.FromFile($"{Directory.GetCurrentDirectory()}\\StimulMat\\Reaction\\Type{1}-{4}.gif");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = System.Drawing.Image.FromFile($"{Directory.GetCurrentDirectory()}\\StimulMat\\Normal\\Type{1}-{1}.gif");

        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = System.Drawing.Image.FromFile($"{Directory.GetCurrentDirectory()}\\StimulMat\\Reaction\\Type{2}-{4}.gif");

        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = System.Drawing.Image.FromFile($"{Directory.GetCurrentDirectory()}\\StimulMat\\Normal\\Type{2}-{1}.gif");

        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
           pictureBox3.Image = System.Drawing.Image.FromFile($"{Directory.GetCurrentDirectory()}\\StimulMat\\Reaction\\Type{3}-{4}.gif");

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = System.Drawing.Image.FromFile($"{Directory.GetCurrentDirectory()}\\StimulMat\\Normal\\Type{3}-{1}.gif");

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = System.Drawing.Image.FromFile($"{Directory.GetCurrentDirectory()}\\StimulMat\\Reaction\\Type{4}-{4}.gif");

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = System.Drawing.Image.FromFile($"{Directory.GetCurrentDirectory()}\\StimulMat\\Normal\\Type{4}-{1}.gif");

        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromKnownColor(KnownColor.Highlight); 
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.DimGray;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            nextForm = true;
            this.Hide();
            SetSettingsForm1 form5 = new SetSettingsForm1();
             form5.Show();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
