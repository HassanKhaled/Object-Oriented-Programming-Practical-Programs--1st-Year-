using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_07_ConstrutorOverloading
{
    class Student
    {
        public string name;
        public int age;
        public Student()
        {
            Console.WriteLine("Ojbect Created ...");
        }
        public Student(string name, int age)
        {
            this.age = age;
            this.name = name;
        }
        public Student(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
        public Student(string name)
        {
            this.name = name;
        }
        public Student(int age)
        {
            this.age = age;
        }

        public void PrintObjectInfo()
        {
            Console.WriteLine("name : {0} , age : {1} ", name, age);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student("Ahmed", 33);
            Student S2 = new Student("Wael", 35);
            Student S3 = new Student("Khaled", 39);
            Student S4 = new Student("Mohamed", 32);
            Student S5 = new Student("Samir", 36);
            Student[] students = new Student[5] { S1, S2, S3, S4, S5 };
            foreach (var student in students)
                student.PrintObjectInfo();
        }
    }
}
