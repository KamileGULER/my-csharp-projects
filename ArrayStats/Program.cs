using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student[] students = new student[3];

            students[0] = new student();
            students[0].id = 0;
            students[0].name = "Sefer";
            students[0].midterm = 100;
            students[0].final = 100;

            students[1] = new student();
            students[1].id = 1;
            students[1].name = "Kamile";
            students[1].midterm = 90;
            students[1].final = 55;

            students[2] = new student();
            students[2].id = 2;
            students[2].name = "Nefise";
            students[2].midterm = 80;
            students[2].final = 50;

            student theNameOfHighestMid = FindHighestMidtermStudent(students);

            Console.WriteLine("The student with highest midterm score:" + theNameOfHighestMid.name);
            Console.WriteLine("Midterm score:" + theNameOfHighestMid.midterm);

            foreach (student s in students)
            {
                Console.WriteLine("Student Name:" + s.name + " " + "Avarage: " + s.CalculateAvarage());
            }

        }
        public static student FindHighestMidtermStudent(student[] studentlist)
        {
            if (studentlist == null || studentlist.Length == 0)
            {
                Console.WriteLine("This list is empty.");
                return null;
            }

            student SuccessfullStudent = studentlist[0];

            for (int i = 0; i < studentlist.Length; i++)
            {
                if (studentlist[i].midterm > SuccessfullStudent.midterm)
                {
                    SuccessfullStudent = (studentlist[i]);
                }
            }

            return SuccessfullStudent;
        }
    }
}
