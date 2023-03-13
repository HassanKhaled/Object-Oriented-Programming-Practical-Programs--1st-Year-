using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_07_MthOveClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("ahmed", 35, new double[] { 95, 93, 91, 92, 89 });
            Student.readGradeForObject(s1);
            Student.printGradesFromObject(s1);
        }
    }

    class Student
    {
        public string name;
        public int age;
        public double[] grades;

        // public type this [Type Index]  {get{return array[Index];} {set{array[Index]=value;} } 
        public double this[int i]
        {
            get { return grades[i]; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    grades[i] = value;
                }
                else
                {
                    Console.WriteLine("wrong value entered, using default value instead");
                    grades[i] = 0;
                }
            }
        }
        public Student(string name, int age, double[] grades)
        {
            this.name = name;
            this.age = age;
            this.grades = grades;
        }
        public static void readGradeForObject(Student s)
        {
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

        public static void PrintInfo(Student s)
        {
            Console.WriteLine("Name :{0} , Age {1} ",s.name,s.age);
            printGradesFromObject(s);
        }
        public static void PrintInfo(string name , int age )
        {
            Console.WriteLine("Name :{0} , Age {1} ", name, age);
        }
        public static void PrintInfo( int age, string name)
        {
            Console.WriteLine("Name :{0} , Age {1} ", name, age);
        }
        public static void PrintInfo(string name)
        {
            Console.WriteLine("Name :{0} ", name);
        }
        public static void PrintInfo(int age)
        {
            Console.WriteLine(" Age {1} ", age);  
        }

    }
}
