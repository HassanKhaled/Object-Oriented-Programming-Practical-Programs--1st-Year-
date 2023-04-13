using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_04_Interfaces
{
    public interface IPrint {
         void Print();
    }
    public interface IHello {
        void sayHello();
    }
    abstract class Person
    {
        public string name;
        public int age;
        public void hi()
        {
            Console.WriteLine("Hi !!!");
        }
        public abstract void printInfo();
    }
    class Student : Person , IPrint, IHello
    {
        public double grades;
        public void Print()
        {
            Console.WriteLine("Name {0} , Age {1}",name,age);
        }
        public override void printInfo()
        {
            Console.WriteLine("Name {0} , Age {1} , Grades {2}", name, age, grades);
        }
        public void sayHello()
        {
            Console.WriteLine("Hello World "); 
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
            Student s = new Student();
            s.name = "wael";
            s.age = 39;
            s.Print();
            s.sayHello();
        }
    }
}
