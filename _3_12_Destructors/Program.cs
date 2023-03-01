using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_12_Destructors
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

        public Student()
        {

        }
        public void PrintObjectInfo()
        {
            Console.WriteLine("name : {0} , age : {1} ", name, age);
            
        }
        ~Student(){
            Console.WriteLine("Object Was Removed From Memory");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

            Student[] students = new Student[150]; 
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student("ahmed",33);
            }
            Student s1 = new Student("wael",19);
            s1 = null;
            GC.Collect();

        }
    }
}
