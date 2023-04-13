using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_03_SealedClass
{
    sealed class Person
    {
        public string name;
        public int age;
        public void hi()
        {
            Console.WriteLine("Hi !!!");
        }
        public abstract void printInfo();
    }
    class Student : Person
    {
        public double grades;
        public override void printInfo()
        {
            Console.WriteLine("Name {0} , Age {1} , Grades {2}", name, age, grades);
        }
        public void sayHi()
        {
            hi();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
