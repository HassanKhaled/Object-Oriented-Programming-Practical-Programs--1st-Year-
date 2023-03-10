using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_03_staticMeth
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(10,"ahmed");
            Student s2 = new Student(20, "wael");
            Student s3 = new Student(25, "sami");
            Student.printCount();
            Student.printAverage();
        }
    }
    class Student
    {
        public string name;
        public int age;
        public static int count;
        public static int TotalAges;
        public Student(int age , string name)
        {
            this.name = name;
            this.age = age;
            TotalAges += this.age;
            count++;
        }
        public static void printCount() {
            Console.WriteLine("# of Students is {0}", count);
        }
        public static void printAverage() {
            Console.WriteLine("Averrage Age is {0}",TotalAges/ count);
        }
    }
}
