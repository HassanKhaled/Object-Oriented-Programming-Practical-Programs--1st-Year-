using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_08_LoopParamterConstructor
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
        static void Main(string[] args)
        {
           
            Student[] students = new Student[5];
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Enter Name of {0} Student:",i+1);
                string name = Console.ReadLine();
                Console.WriteLine("Enter Age  of {0} Studnet:",i+1);
                int age = int.Parse(Console.ReadLine());
                students[i] = new Student(name, age);
            }
        }
    }
}
