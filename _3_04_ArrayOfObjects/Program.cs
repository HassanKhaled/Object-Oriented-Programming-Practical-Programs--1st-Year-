using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_04_ArrayOfObjects
{
    class Student
    {
        public string name;
        public int age;
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
            Student S2 = new Student();
            S2.name = "khaled";
            S2.age = 22;
            Student S3 = new Student();
            S3.name = "ahmed";
            S3.age = 25;
            Student[] students = new Student[5] {S1,S2,S3,S1,S3};
            foreach (var student in students)
                student.PrintObjectInfo();
        }
    }
}
