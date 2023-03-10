using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_03_PrivateAccMod
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student("", -25);
            s1.PrintInfo();
        }
    }
    class Student
    {
        // string name;
        // int age;
        private string name;
        private int age;

        public Student(string name , int age )
        {   if (name != "")
                this.name = name;
            else
                this.name = "name";
            if (age > 0)
                this.age = age;
            else
                this.age = 18;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Name : {0} , Age {1}", name, age);
        }
    }
}
