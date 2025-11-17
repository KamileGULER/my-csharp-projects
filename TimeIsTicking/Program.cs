using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TimeIsTicking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime GoalTime;


            Console.WriteLine("Please enter a goal date (e.g., 25.12.2025 10:00):");
            string input = Console.ReadLine();

            while (!DateTime.TryParse(input, out GoalTime)) 
            {
                Console.WriteLine("Invalid date format. Please try again (e.g., 25.12.2025 10:00):");
                input = Console.ReadLine();
            }

            while (true)
            {
                DateTime now = DateTime.Now;
                TimeSpan timeRemaining =GoalTime - now;

                if (GoalTime < now) 
                {
                    Console.WriteLine("Gola time has passed!!");
                    break;
                }

                Console.Clear();

                Console.WriteLine($"The goal time is: {GoalTime.ToShortDateString()} {GoalTime.ToShortTimeString()}");
                Console.WriteLine($"Current time is: {now.ToShortDateString()} {now.ToShortTimeString()}");
                Console.WriteLine("-----------------------------------------------------");

                Console.WriteLine($"REMAINING: {timeRemaining.Days} days, {timeRemaining.Hours} hours, {timeRemaining.Minutes} minutes, {timeRemaining.Seconds} seconds.");

                Thread.Sleep(1000);
            }

            Console.ReadLine();
           
        }
    }
}
