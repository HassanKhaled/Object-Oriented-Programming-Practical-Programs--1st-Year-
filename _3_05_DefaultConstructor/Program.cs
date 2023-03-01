using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_05_DefaultConstructor
{
    class Student
    {
        public string name;
        public int age;
        // constructor
        public Student()
        {
            Console.WriteLine("Ojbect Created ...");
        }
        //actions 
        public void PrintObjectInfo()
        {
            Console.WriteLine("name : {0} , age : {1} ", name, age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.name = "wael";
            S1.age = 33;

            Student S3 = new Student();
            S3.name = "ahmed";
            S3.age = 25;
            Student[] students = new Student[5] { S1, S3, S3, S1, S3 };
            foreach (var student in students)
                student.PrintObjectInfo();
        }
    }


}
