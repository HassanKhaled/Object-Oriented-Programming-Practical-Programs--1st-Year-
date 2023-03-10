using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_05_ArrOfObts
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] g = { 95, 96, 90, 93, 94 };
            Student[] sts = new Student[3] { new Student(10, "ahmed", g), new Student(20, "wael", g), new Student(25, "sami", g) };
            foreach (var student in sts)
            {
                student.MaxGrade();
                student.MinGrade();
                Console.WriteLine("Average of grades  is {0}",student.averGrades());
            }
        }
    }
    class Student
    {
        public string name;
        public int age;
        public static int count;
        public static int TotalAges;
        public double[] grades;
        public Student(int age, string name, double[] grades)
        {
            this.grades = grades;
            this.name = name;
            this.age = age;
            TotalAges += this.age;
            count++;
        }

        public void MaxGrade() {
            double max = grades[0];
            foreach (var g in grades)
                if (g>max)
                    max = g;

            Console.WriteLine("Max grade is {0}",max);
        }
        public void MinGrade()
        {
            double min = grades[0];
            foreach (var g in grades)
                if (g < min)
                    min = g;
            Console.WriteLine("Minn grade is {0}", min);

        }
         double sumGrades() {
             double sum = 0;
            foreach (var g in grades)
                sum += g;
            return sum;
        }

        public double averGrades() {
            return sumGrades() / grades.Length;
        }


        public static void printCount()
        { Console.WriteLine("# of Students is {0}", count); }
        public static void printAverage()
        { Console.WriteLine("Averrage Age is {0}", TotalAges / count); }
    }
}
