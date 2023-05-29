using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp2.Program;

namespace WindowsFormsApp2
{
    public partial class ModeChoiceForm : Form
    {
        bool nextForm = false;
        public ModeChoiceForm()
        {
            InitializeComponent();
            label1.Text = "Лабораторная работа \n\"Исследование времени информационного поиска\"";
            OutData.types.Clear();
            OutData.reprTime.Clear();
        }

        private void roundCornerButton1_Click(object sender, EventArgs e)
        {
            nextForm = true;
            this.Hide();
            AimDescriptionForm form2 = new AimDescriptionForm();
            form2.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void roundCornerButton2_Click(object sender, EventArgs e)
        {
            nextForm = true;
            this.Hide();
            AllResultsForm form9 = new AllResultsForm();
            form9.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
