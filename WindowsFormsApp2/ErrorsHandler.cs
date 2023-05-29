using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public  class ErrorsHandler
    {
        public void EmptyName()
        {
            MessageBox.Show("Поле имени не может быть пустым!", "Неверный формат имени");

        }
        public void EmptyGroupNumber()
        {
            MessageBox.Show("Поле номера группы не может быть пустым!", "Неверный формат номера группы");

        }
        public void InvalidGroupNumber()
        {
            MessageBox.Show("Номер группы должен состоять из 6 символов (цифр)!", "Неверный формат номера группы");

        }
        public void EmptyData()
        {
            MessageBox.Show("Поля не могут быть пустым!", "Попытка ввода пустых полей");

        }
        public void ActionNotAllowed()
        {
            MessageBox.Show("Вы не можете перейти к регистрации до тех пор, пока не ознакомитесь с описанием работы.", "Ошибка доступа");

        }
        public void NullSettings()
        {
            MessageBox.Show("Вы не можете перейти к тестированию до тех пор, пока не выставите настройки опыта.", "Ошибка доступа");

        }
       public void EmptyIndicatorTypesList()
        {
            MessageBox.Show("Вы не выбрали ни один из типов индикаторов.", "Ошибка доступа");
        }
    }
}
