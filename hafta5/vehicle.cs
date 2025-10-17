using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyApplication
{
    class Vehicle  // Base class
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()
        // Vehicle method  
        {
            Console.WriteLine("Tuut,tuut!"); 
        }
    }
}