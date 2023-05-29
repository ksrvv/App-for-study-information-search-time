using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Data
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public  string Group { get; set; }
        public  int NumberOfRepresentations { get; set; }
        public  int NumberOfIndicators { get; set; }
        public  string ReprTime { get; set; }
        public string Types { get; set; }
        public string AverageTime { get; set; }
        public DateTime date = DateTime.Now;
    }
}
