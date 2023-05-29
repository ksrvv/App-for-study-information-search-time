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
    public partial class GetPersonalDataForm : Form
    {
        bool nextForm = false;
        public ErrorsHandler errorsHandler = new ErrorsHandler();
        public GetPersonalDataForm()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            roundCornerButton1.Location = new Point(this.Width / 2 - roundCornerButton1.Width / 2, 343);
        }

        private void roundCornerButton1_Click(object sender, EventArgs e)
        {
            if (groupTextBox.Texts == String.Empty && nameTextBox.Texts == String.Empty)
            {
                errorsHandler.EmptyData();
            }

            else if (groupTextBox.Texts == String.Empty)
            {
                errorsHandler.EmptyGroupNumber();
            }
            else if (nameTextBox.Texts == String.Empty)
            {
                errorsHandler.EmptyName();
            }
            else if (int.TryParse(groupTextBox.Texts, out int temp) == false || groupTextBox.Texts.Length != 6 || groupTextBox.Texts.StartsWith(" "))
            {
                errorsHandler.InvalidGroupNumber();
            }
            else
            {
                OutData.Name = nameTextBox.Texts;
                OutData.Group = groupTextBox.Texts;
                nextForm = true;
                this.Hide();
                SetSettingsForm1 form5 = new SetSettingsForm1();
                form5.Show();
            }

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void nameTextBox__TextChanged(object sender, EventArgs e)
        {

        }

        protected override void OnResize(EventArgs e)
        {
            //base.OnResize(e);
            //int width = Convert.ToInt32(0.35 * Width);
            //int height = Height;
            //nameTextBox.Location = new Point(width, 200);
            //groupTextBox.Location = new Point(width, 260);
        }
    }
}
