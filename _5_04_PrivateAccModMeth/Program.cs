using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_04_PrivateAccModMeth
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
        private string name;
        private int age;
        public Student(string name, int age)
        {
            setName(name);
            setAge(age);
        }
        public void setName(string name) {
            if (name != "")
                this.name = name;
            else
            {
                Console.WriteLine("You Have Entered Wrong Name");
                Console.WriteLine("Enter Correct value");
                this.name = Console.ReadLine();
            }
        }
        public void setAge(int age) {
            if (age > 0)
                this.age = age;
            else
            {
                Console.WriteLine("You Have Entered Wrong Age");
                Console.WriteLine("Enter Correct value");
                this.age = int.Parse(Console.ReadLine());
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine("Name : {0} , Age {1}", name, age);
        }
    }
}
