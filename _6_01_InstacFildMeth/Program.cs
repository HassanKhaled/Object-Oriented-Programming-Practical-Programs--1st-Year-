
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_01_InstacFildMeth
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.name="hamed";
            s1.age = 35;
            s1.PrintInfo();
        }
    }
    class Student
    {
        public string name;
        public int age;
        public void PrintInfo()
        {
            Console.WriteLine("Name : {0} , Age {1}", name, age);
        }
    }
}
