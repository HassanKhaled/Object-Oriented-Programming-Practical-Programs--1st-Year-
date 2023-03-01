using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_10_MinMaxArrObjects
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
        static int minObjectArr(Student[] students)
        {
            int min = students[0].age;
            foreach (Student student in students)
                if (student.age<min)
                    min = student.age;
                
            return min;
        }
        static int maxObjectArr(Student[] students)
        {
            int max = students[0].age;
            foreach (Student student in students)
                if (student.age > max)
                    max = student.age;

            return max;
        }

        static void Main(string[] args)
        {
            Student[] students = new Student[5] {new Student("ahmed",15),
                new Student("khaled", 52),
                new Student("sami", 35),
                new Student("sally", 23),
                new Student("saleem", 24) };
            Console.WriteLine("min age of array is {0}",minObjectArr(students));
            Console.WriteLine("max age of array is {0}", maxObjectArr(students));

        }
    }
}
