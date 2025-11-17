using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStats
{
    internal class student
    {
        public int id;
        public string name;
        public int midterm;
        public int final;

        public double CalculateAvarage() 
        {
            return (midterm * 0.4 + final * 0.60);
        }
    }
}
