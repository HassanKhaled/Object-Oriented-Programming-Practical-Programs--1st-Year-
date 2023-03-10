using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_04_ArrayClasMem
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] g = { 95, 96, 90, 93, 94 };
            Student s1 = new Student(10, "ahmed",g);
            Student s2 = new Student(20, "wael",g);
            Student s3 = new Student(25, "sami",g);
            Student.printCount();
            Student.printAverage();
        }
    }
    class Student
    {   public string name;
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
        public static void printCount()
        { Console.WriteLine("# of Students is {0}", count);  }
        public static void printAverage()
        { Console.WriteLine("Averrage Age is {0}", TotalAges / count); }
    }
}
