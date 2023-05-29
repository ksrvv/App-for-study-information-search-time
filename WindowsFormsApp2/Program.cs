using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ModeChoiceForm());
        }
        public static class OutData
        {
            public static string Name { get; set; }
            public static string Group { get; set; }
            public static int NumberOfRepresentations { get; set; }
            public static int NumberOfIndicators { get; set; }
            public static Dictionary<int, TimeSpan> reprTime = new Dictionary<int, TimeSpan>();
            public static List<int> types = new List<int>();
            public static void ReturnString()
            {
                MessageBox.Show($"Name: {Name}, Group: {Group}.");
            }

        }
        public static class InData
        {
            public static string[] reprNumbers = new string[] { "5 предъявлений", "10 предъявлений", "15 предъявлений", "20 предъявлений", "25 предъявлений", "30 предъявлений", "35 предъявлений", "40 предъявлений" };
            public static string[] indicatorsNumbers = new string[] { "4 индикатора(ов)", "6 индикатора(ов)", "8 индикатора(ов)", "12 индикатора(ов)" };

        }
    }
}
