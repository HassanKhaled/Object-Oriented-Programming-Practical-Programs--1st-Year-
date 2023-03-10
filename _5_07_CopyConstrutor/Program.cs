using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_07_CopyConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Def= new Student("Default Name", 18);
            Student s1 = new Student(Def);
            s1.PrintInfo();
            Def.PrintInfo();
        }
    }
    class Student
    { 
        public string name;
        public int age;
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Student(Student s) {
            name = s.name;
            age = s.age;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Name : {0} , Age {1}", name, age);
        }
    }
}
