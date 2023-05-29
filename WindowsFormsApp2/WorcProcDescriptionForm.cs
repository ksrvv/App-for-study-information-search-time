using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class WorcProcDescriptionForm : Form
    {
        bool nextForm = false;
        public ErrorsHandler errorsHandler = new ErrorsHandler();
        public WorcProcDescriptionForm()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            label3.Location = new Point(this.Width / 2, 30);
            label2.Text = "Для выполнения опыта вам необходимо выставить настройки: количество предъявлений, количество индикаторов в поисковом поле, тип индикаторов. \nДо начала опыта вы можете пройти тренировочную серию - ее результаты не будут учитываться.\n" +
                "В ходе опыта вам будет необходимо опознавать индикатор отображающий критические показатели и нажимать на него кнопкой мыши. При правильном выборе индикатора набор индикаторов изменится. \n" +
                "Критические показатели индикаторов:\nТип 1 (график конического сканирования) - наибольшая высота,\nТип 2 (радар) - обнаруженые объекта (красная зона),\nТип 3 (осциллограмма на выходе фазового детектора) - наибольшая амплитуда среднего сигнала,\nТип 4 (цифровой сигнал) - наибольшая амплитуда и частота.\n" +
                "В опытах рекомендуется использовать один тип индикатора. \nРезультаты будут отображены на экране после завершения тестирования. Подробные сведения вы можете просмотреть в файле с вашим результатом.";
            checkBox1.Location = new Point(90, roundCornerButton1.Location.Y + roundCornerButton1.Height / 2);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
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

        private void checkBox1_MouseEnter(object sender, EventArgs e)
        {
            checkBox1.ForeColor = Color.FromKnownColor(KnownColor.Highlight);
        }

        private void checkBox1_MouseLeave(object sender, EventArgs e)
        {
            checkBox1.ForeColor = Color.DimGray;
        }

        private void roundCornerButton1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                nextForm = true;
                this.Hide();
                GetPersonalDataForm form4 = new GetPersonalDataForm();
                form4.Show();
            }
            else
            {
                errorsHandler.ActionNotAllowed();
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
