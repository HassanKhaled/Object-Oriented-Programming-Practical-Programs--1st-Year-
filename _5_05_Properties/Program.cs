using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _5_05_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("", -25);
            s1.Name = "Ali";
            s1.Age = 15;
            s1.PrintInfo();
        }
    }
    class Student
    {
        public string Name {
            set { name = value; }
            get { return name; }
        }
        public int Age {
            set { age = value; }
            get { return age; }
        }
        private string name;
        private int age;
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Name : {0} , Age {1}", name, age);
        }
    }
}
