using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_09_SumAverArrObjects
{
    class Student
    {
        public string name;
        public int age;
        public Student(string name, int age)
        {
            this.age = age;
            this.name = name;
        }
        public void PrintObjectInfo()
        {
            Console.WriteLine("name : {0} , age : {1} ", name, age);
        }
    }
    class Program
    {
        static int sum(Student[] studnets) {
            int sum = 0;
            foreach (Student student in studnets) 
                sum += student.age;
            return sum;
        }
        static double average(Student[] students) {
            return sum(students) / students.Length;
        }
        static void Main(string[] args)
        {

            Student[] students = new Student[5] {new Student("ahmed",15), 
                new Student("khaled", 52), 
                new Student("sami", 35),
                new Student("sally", 23),
                new Student("saleem", 24) };
            Console.WriteLine("Sum is {0}",sum(students));
            Console.WriteLine("Average is {0}",average(students));
            
        }
    }
}
