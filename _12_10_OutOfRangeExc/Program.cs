using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_10_OutOfRangeExc
{
    class Student {
        public string name;
        public int age;
        public Student(string name , int age)
        {
            this.name = name;
            this.age = age;
        }
        public void setAge(int age) {
            if (age <= 0)
                throw new ArgumentOutOfRangeException("Age must be larger than zero");
            else
                this.age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before Exeption");
            try
            {
                Student s1 = new Student("ahmed", 26);
                s1.setAge(0);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Console.WriteLine("After Exeption");

        }
    }
}
