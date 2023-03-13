using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_02_indLoop
{
    class Program  
    { 
        public static void printGradesFromObject(Student s) {
            for (int i = 0; i < s.grades.Length; i++)
                Console.WriteLine("grade is {0}", s[i]);
        }
        static void Main(string[] args)
        {
            Student s1 = new Student("ahmed", 35, new double[] { 95, 93, 91, 92, 89 });
            for (int i = 0; i < s1.grades.Length; i++)
                Console.WriteLine( "grade is {0}",s1[i]);
            printGradesFromObject(s1);
        }
    }

    class Student
    {
        public string name;
        public int age;
        public double[] grades;
        public Student(string name, int age, double[] grades)
        {
            this.name = name;
            this.age = age;
            this.grades = grades;
        }

        // public type this [Type Index]  {get{return array[Index];} {set{array[Index]=value;} } 
        public double this[int i]
        {
            get { return grades[i]; }
            set { grades[i] = value; }
        }
    }
}
