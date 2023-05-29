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
    public partial class SetSettingsForm1 : Form
    {
        bool nextForm = false;
        public ErrorsHandler errorsHandler = new ErrorsHandler();

        int numOfIndicatorsChecked = -1;
        int numOfReprsChecked = -1;
        int numOfIndicators = 0;
        int numOfReprs = 0;
        public SetSettingsForm1()
        {
            InitializeComponent();
        }
        private void roundCornerButton1_Click(object sender, EventArgs e)
        {
            if (numOfIndicatorsChecked == -1 || numOfReprsChecked == -1)
            {
                errorsHandler.NullSettings();
            }
            else
            {
                OutData.NumberOfRepresentations = numOfReprs;
                OutData.NumberOfIndicators = numOfIndicators;
                nextForm = true;
                this.Hide();
                SetSettingsForm2 form6 = new SetSettingsForm2();
                form6.Show();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label3.Location = new Point(this.Width / 2, 30);
            checkedListBox1.Items.AddRange(InData.reprNumbers);
            checkedListBox2.Items.AddRange(InData.indicatorsNumbers);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Если отмечено больше 2 элементов, то снимаем выделение со всех и отмечаем текущий.
            if (checkedListBox1.CheckedItems.Count > 1)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    checkedListBox1.SetItemChecked(i, false);
                checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, true);

            }
            if (checkedListBox1.SelectedItems.Count > 0 && checkedListBox1.CheckedItems.Count == 0)
            {
                for (int i = 0; i < checkedListBox1.SelectedItems.Count; i++)
                    checkedListBox1.SetSelected(i, false);
            }
            numOfReprsChecked = checkedListBox1.SelectedIndex;
            if (numOfReprsChecked != -1)
                numOfReprs = Convert.ToInt32(checkedListBox1.CheckedItems[0].ToString().Replace(" предъявлений", ""));
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox2.CheckedItems.Count > 1)
            {
                for (int i = 0; i < checkedListBox2.Items.Count; i++)
                    checkedListBox2.SetItemChecked(i, false);
                checkedListBox2.SetItemChecked(checkedListBox2.SelectedIndex, true);

            }
            if (checkedListBox2.SelectedItems.Count > 0 && checkedListBox2.CheckedItems.Count == 0)
            {
                for (int i = 0; i < checkedListBox2.SelectedItems.Count; i++)
                    checkedListBox2.SetSelected(i, false);
            }
            numOfIndicatorsChecked = checkedListBox2.SelectedIndex;
            if (numOfIndicatorsChecked != -1)
                numOfIndicators = Convert.ToInt32(checkedListBox2.CheckedItems[0].ToString().Replace(" индикатора(ов)", ""));
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
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
        private void checkedListBox1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
