using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AimDescriptionForm : Form
    {
        bool nextForm = false;
        public AimDescriptionForm()
        {
            InitializeComponent();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Form2_Load(object sender, EventArgs e)
        {
            roundCornerButton1.Location = new Point(90, 322);
            label4.Location = new Point(this.Width - 200, 322 + roundCornerButton1.Height / 2);
            label3.Location = new Point(this.Width / 2, 30);
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromKnownColor(KnownColor.Highlight);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.DimGray;
        }

        private void roundCornerButton1_Click(object sender, EventArgs e)
        {
            nextForm = true;
            this.Hide();
            WorcProcDescriptionForm form3 = new WorcProcDescriptionForm();
            form3.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            nextForm = true;
            this.Hide();
            GetPersonalDataForm form4 = new GetPersonalDataForm();
            form4.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
