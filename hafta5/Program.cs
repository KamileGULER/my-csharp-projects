using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta5
{
    internal class Program
    {
        public string color = "red";
        public string model;
        public int year;

        public Program(string modelName, string modelColor, int modelYear)
        {
            color= modelColor;
            model= modelName;
            year= modelYear;    
        }

        static void Main(string[] args)
        {
           /*  Program n = new Program();
            Console.WriteLine(n.color);

            Car car = new Car();
            Console.WriteLine(car.name);
            car.fullThrottle();

            Program Ford = new Program();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Program Opel = new Program();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
           */

            Program ford = new Program("Mustang", "red", 1969); 
            Console.WriteLine(ford.model+ " " + ford.color + " " + ford.year);

            Car car = new Car();
            car.Name = "Kamile";
            car.honk();

            Console.WriteLine(car.brand + " " + car.modelName);

        }
    }
}
