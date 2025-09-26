using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1._2
{
    class Bread
    {
        public int counter;
    }

    static class Butter
    {
        public static int counter;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //instance of class "Butter" required
            Bread a = new Bread();
            a.counter = 5;
            Console.WriteLine("Bread: " + a.counter);

            //no instance required
            Butter.counter = 7;
            Console.WriteLine("Butter:" + Butter.counter);
        }
    }
}
