using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book();    

            book1.Name = "The Little Prince";
            book1.Author = "A. De Saint";
            book1.PublishDate = 1990;

            book2.Name = "The Art Of War";
            book2.Author = "Sun TZU";
            book2.PublishDate = 1960;

            int choice;

            do 
            { 
            Console.WriteLine("\n=== LIBRARY MENU ===");
            Console.WriteLine("1 - Book Info");
            Console.WriteLine("2 - Calculate Punish");
            Console.WriteLine("0 - Exit");
            Console.Write("\nSelect an option: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Please enter a valid number!\n");
                continue;
             }

            Console.WriteLine();

                switch (choice)
            {
                case 1:
                    Console.WriteLine("\nWhich book info do you want to see? (1 or 2): ");
                    int infoChoice = Convert.ToInt32(Console.ReadLine());

                    if (infoChoice == 1)
                        book1.BookInfo();
                    else if (infoChoice == 2)
                        book2.BookInfo();
                    else
                        Console.WriteLine("Invalid book selection!");
                    break;

                case 2:
                    Console.WriteLine("\nFor which book? (1 or 2): ");
                    int punishChoice = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter number of delayed days (1–15): ");
                    int days = Convert.ToInt32(Console.ReadLine());

                    if (punishChoice == 1)
                        book1.Punish_Calculate(days);
                    else if (punishChoice == 2)
                        book2.Punish_Calculate(days);
                    else
                        Console.WriteLine("Invalid book selection!");
                    break;
               
                case 0:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;

            }

                if (choice != 0)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (choice != 0);
        }
    }
}