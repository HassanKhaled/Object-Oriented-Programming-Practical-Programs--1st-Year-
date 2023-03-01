using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_11_SearchArrObjects
{
    class Student
    {
        public string name;
        public int age;
        public Student(string name, int age)
        {
            this.age = age;
            this.name = name;
        }

        public Student()
        {

        }
        public void PrintObjectInfo()
        {
            Console.WriteLine("name : {0} , age : {1} ", name, age);
        }
    }
    class Program
    {
        static Student SearchStudentByName(string name, Student[] arr)
        {
            Student result = new Student();
            foreach (var student in arr)
                if (student.name == name)
                    result = student;
            return result;
        }
        static void Main(string[] args)
        {
            Student[] students = new Student[5] {new Student("ahmed",15),
                new Student("khaled", 52),
                new Student("sami", 35),
                new Student("sally", 23),
                new Student("saleem", 24) };

            SearchStudentByName("ahmed",students).PrintObjectInfo();
            SearchStudentByName("hassan", students).PrintObjectInfo();
            SearchStudentByName("saleem", students).PrintObjectInfo();

        }
    }
}