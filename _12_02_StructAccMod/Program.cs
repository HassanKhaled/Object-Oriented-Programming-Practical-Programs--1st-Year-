using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_02_StructAccMod
{

    // no static access modifier
    // no abstract access modifier 
    // no sealed access modifier
    struct Student
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
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ahmed", 38);
            s1.printInfo();
        }
    }
}
