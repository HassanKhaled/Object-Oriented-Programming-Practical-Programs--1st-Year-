
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_01_indexers
{    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("ahmed", 35, new double[] { 95, 93, 91, 92, 89 });
            Console.WriteLine(s1[0]);
            s1[1] = 100;
            Console.WriteLine(s1[1]);
        }
    }

    class Student {
        public string name;
        public int age;
        public double[] grades;
        public Student(string name, int age , double[] grades)
        {
            this.name = name;
            this.age = age;
            this.grades = grades;
        }

        // public type this [Type Index]  {get{return array[Index];} {set{array[Index]=value;} } 
        public double this[int i] 
        { 
            get { return grades[i];}
            set { grades[i] = value; } 
        }
    }
}
