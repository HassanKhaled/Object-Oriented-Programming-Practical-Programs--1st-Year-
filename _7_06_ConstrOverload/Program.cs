using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_06_ConstrOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("ahmed", 35, new double[] { 95, 93, 91, 92, 89 });
     
        }
    }

    class Student
    {
        public string name;
        public int age;
        public double[] grades;


        public Student()
        {

        }
        public Student(string name, int age, double[] grades)
        {
            this.name = name;
            this.age = age;
            this.grades = grades;
        }
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
           
        }
        public Student( int age, string name)
        {
            this.name = name;
            this.age = age;

        }
        public Student(double[] grades,string name, int age )
        {
            this.name = name;
            this.age = age;
            this.grades = grades;
        }
        public Student( string name, double[] grades, int age)
        {
            this.name = name;
            this.age = age;
            this.grades = grades;
        }

    }
}
