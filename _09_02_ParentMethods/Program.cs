using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _09_02_ParentMethods
{
    class Person
    {
        public string name;
        public int age;


        public void PrintPerson() {
            Console.Write("Name : {0} , Age : {1} ",this.name,this.age);
        }
    }
    class Student : Person
    {
        public double grades;
        public void PrintStudent()
        {
            PrintPerson();
            Console.WriteLine("Grades : {0}", this.grades);
        }
    }

    class Teacher : Person
    {
        public string course;
        public double salary;

        public void PrintTeacher() {
            PrintPerson();
            Console.WriteLine("Course : {0} , Salary : {1}",this.course,this.salary);
        }
    }

    class Empolyee : Person
    {
        public string position;

        public void PrintEmpolyee()
        {
            PrintPerson();
            Console.WriteLine("Position : {0}" , this.position);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher();
            t1.name = "Ahmed";
            t1.age = 39;
            t1.salary = 4500;
            t1.course = "OOP";
            t1.PrintTeacher();
        }
    }
}
