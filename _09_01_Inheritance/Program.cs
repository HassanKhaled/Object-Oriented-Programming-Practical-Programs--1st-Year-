using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_01_Inheritance
{

    class Person {
        public string name;
        public int age;
    }
    class Student : Person {
        public double grades;
    }

    class Teacher : Person
    {
        public string course;
        public double salary;
    }

    class Empolyee : Person
    {
        public string position;
    }
     class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
