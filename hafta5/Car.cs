using MyApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta5
{
    internal class Car:Vehicle
    {
       // public string name = "Kamile";
        private int p_id = 24;

        private string name;  // field 
        public string Name    // property 
        { 
            get { return name; } 
            set { name = value; } 
        } 
        public int P_id { get; set; }  // property    

        public string modelName = "Mustang";
        public void fullThrottle()   // method 
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

    }
}
