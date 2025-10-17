using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Kamile", "Güler", 12345, 85, 90, 88, "Karabük University");

            while (true) 
            {
                Console.WriteLine("--- MENÜ ---");
                Console.WriteLine("1- Öğrenci Bilgileri Göster");
                Console.WriteLine("2- Öğrenci Ortalaması Göster");
                Console.WriteLine("3- Öğrencinin Okulunu Öğren");
                Console.WriteLine("4- Çıkış Yap");
                Console.Write("Seçiminiz (1-4): ");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("\n" + student.ShowStudentInfo());
                        break;

                    case "2":
                        Console.WriteLine("\n" + student.FindExamAvarage());
                        break;

                    case "3":
                        Console.WriteLine("\n" + student.ShowSchoolName());
                        break;

                    case "4":
                        Console.WriteLine("Çıkılıyor.." );
                        return;
                }
            }
        }
    }
}
