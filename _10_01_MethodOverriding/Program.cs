using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_01_MethodOverriding
{

    class Person {
        public string name;
        public int age;

        public void PrintInfo() {
            Console.Write("Person : ");
            Console.WriteLine("Name {0}, Age {1}",name,age);
        }
    }
    class Student : Person {

        public double grades;
        public void PrintInfo()
        {
            Console.Write("Student : ");
            Console.WriteLine("Name {0}, Age {1} , Grades {2}", name, age, grades);
        }
    }
    class Teacher : Person {
        public string course;
        public double salary;
        public void PrintInfo()
        {
            Console.Write("Student : ");
            Console.WriteLine("Name {0}, Age {1} , Course {2} , Salary {3} ", name, age, course,salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "ahmed";
            p.age = 35;
            p.PrintInfo();

            Student s = new Student();
            s.name = "ahmed";
            s.age = 35;
            s.grades = 98;
            s.PrintInfo();

        }
    }
}
