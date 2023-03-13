using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_03_indexLoopRead
{
    class Program
    {
        public static void readGradeForObject(Student s) {
            for (int i = 0; i < s.grades.Length; i++)
            {
                Console.WriteLine("Enter Grades {0}", i + 1);
                s[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void printGradesFromObject(Student s)
        {
            for (int i = 0; i < s.grades.Length; i++)
                Console.WriteLine("grade is {0}", s[i]);
        }
        static void Main(string[] args)
        {
            Student s1 = new Student("ahmed", 35, new double[] { 95, 93, 91, 92, 89 });
            readGradeForObject(s1);
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
