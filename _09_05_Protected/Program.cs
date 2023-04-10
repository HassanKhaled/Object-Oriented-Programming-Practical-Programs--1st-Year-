using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_05_Protected
{
    class Person
    {
        public string name;
        public int age;
        protected string familyName;
        public Person(string name, int age, string familyName)
        {
            this.name = name;
            this.age = age;
            this.familyName = familyName;
        }
        public void PrintPerson()
        {
            Console.Write("Name : {0} , Age : {1} , FamilyName : {2} ", this.name, this.age,this.familyName);
        }
    }
    class Teacher : Person
    {
        public string course;
        public double salary;
        public Teacher(string name, int age, string course, double salary,string familyName) : base(name, age,familyName)
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
            Teacher t1 = new Teacher("Ahmed", 39, "OOP", 4500,"alKhaled");
            //t1.familyName = "";
            t1.PrintTeacher();
        }
    }
}
