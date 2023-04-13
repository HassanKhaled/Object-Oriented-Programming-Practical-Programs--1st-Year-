using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_02_MOverridingEx1
{
    class Person
    {
        public string name;
        public int age;

        public virtual void PrintInfo()
        {
            
            Console.Write("Name {0}, Age {1}", name, age);
        }
    }
    class Student : Person
    {

        public double grades;
        public override void PrintInfo()
        {
            Console.Write("Student : ");
            base.PrintInfo();
            Console.WriteLine(" , Grades {0} ", grades);
        }
    }
    class Teacher : Person
    {
        public string course;
        public double salary;
        public override void PrintInfo()
        {
            Console.Write("Teacher : ");
            base.PrintInfo();
            Console.WriteLine(" , Course {0} , Salary {1}", course, salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            t.name = "mohamed";
            t.age = 35;
            t.salary = 4500;
            t.course = "OOP";
            t.PrintInfo();

            Student s = new Student();
            s.name = "ahmed";
            s.age = 35;
            s.grades = 98;
            s.PrintInfo();

        }
    }
}
