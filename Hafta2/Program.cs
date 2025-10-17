using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2
{
    internal class Program
    {
        public static void Main()
        {
            string v = Console.ReadLine();
            int a = Convert.ToInt32(v);
            int b = 10;

            //if condition
            if (a > 20)
            {
                //code to be executed if condition is met true
                Console.WriteLine("a is greater than 20");
            }
            else if (a == 20)
            {
                // code to be executed if a is equal to 20
                Console.WriteLine("a is equal to 20");
            }
            else
            {
                //this will be printed, as a is less than 20
                Console.WriteLine("a is less than 20");
            }

            var result = b > a ? "b is greater than a" : "b is less than a"; 
            Console.WriteLine(result);


            switch (b)
            {
                case 0:
                    Console.WriteLine("Value of x is 5");
                    break;

                case 1:
                    Console.WriteLine("Value of x is 10");
                    break;

            }

            int i = 1;
            while (i < 20)
            {
                i++;

                if ((i % 2) != 0)
                {
                    continue;
                }
                Console.WriteLine("i =" + i);
            }
        }
    }
}
