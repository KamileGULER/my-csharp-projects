using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Library
{
    internal class Book
    {
        private string name;
        private string author;
        private int publishDate;

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int PublishDate
        {
            get { return publishDate; }
            set { publishDate = value; }
        }

        public void Punish_Calculate(int day) 
        {
            int money = 0;
            if (day >= 1 && day <= 7)
            {
                money = day * 5;
                Console.WriteLine($"Punish Money: {money} $");
            }
            else if (day > 7 && day <= 15)
            {
                money = day * 10;
                Console.WriteLine($"Punish Money : {money}");
            }
            else 
            {
                Console.WriteLine("Invalid number of day !!");
            }
        }

        public void BookInfo() 
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Author    : {Author}");
            Console.WriteLine($"Publish Date: {PublishDate}\n");
        }
    }


}
