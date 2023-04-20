using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_03_StructVsClass
{
    class Student
    {
        public string name;
        public int age;
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void printInfo()
        {
            Console.WriteLine("Name is {0}, Age is {1}", name, age);
        }
    }
    class Program
    {  static void Main(string[] args)
        {
            Student s1 = new Student("Ahmed", 38);
            Student s2 = new Student("Kahled",29);
            s2 = s1;
            s2.printInfo();
            s2.name = "Sami";
            s2.age = 36;
            s2.printInfo();
            s1.printInfo();
        }
    }
}
