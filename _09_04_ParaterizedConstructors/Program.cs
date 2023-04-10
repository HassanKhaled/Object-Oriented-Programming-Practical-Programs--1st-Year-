using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_04_ParaterizedConstructors
{
    class Person
    {
        public string name;
        public int age;
        public Person(string name, int age )
        {
            this.name = name;
            this.age = age;
        }
        public void PrintPerson()
        {
            Console.Write("Name : {0} , Age : {1} ", this.name, this.age);
        }
    }
    class Teacher : Person
    {
        public string course;
        public double salary;
        public Teacher(string name, int age ,string course, double salary): base(name,age)
        {
            this.course = course;
            this.salary = salary;
        }
        public void PrintTeacher()
        {
            PrintPerson();
            Console.WriteLine("Course : {0} , Salary : {1}", this.course, this.salary);
        }
    }
  

    class Program
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher("Ahmed",39,"OOP",4500);
            t1.PrintTeacher();

        }
    }
}
