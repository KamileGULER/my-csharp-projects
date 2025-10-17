using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14Homework
{
    internal class Student
    {
        private string name;
        private string surname;
        private int studentNo;
        private int midterm1;
        private int midterm2;
        private int final;
        private string schoolName;

        public Student(string name, string surname, int studentNo, int midterm1, int midterm2, int final, string schoolName)
        {
            this.name = name;
            this.surname = surname;
            this.studentNo = studentNo;
            this.midterm1 = midterm1;
            this.midterm2 = midterm2;
            this.final = final;
            this.schoolName = schoolName;
        }

        public string ShowStudentInfo()
        {
            return $"Name: {name} \n Surname: {surname} \n StudentNo: {studentNo} \n Midterm1: {midterm1} \n Midterm2: {midterm2} \n Final: {final} \n School Name: {schoolName}";
        }

        public double FindExamAvarage()
        {
            double MidtermAvarage = (midterm1 + midterm2)/2;
            double Avarage = (MidtermAvarage * 0.4) + (final * 0.6);
            return Avarage; 
        }

        public string ShowSchoolName()
        {
            return schoolName;
        }
    }

}
