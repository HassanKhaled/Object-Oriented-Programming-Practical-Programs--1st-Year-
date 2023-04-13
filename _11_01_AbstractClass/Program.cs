using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_01_AbstractClass
{
    abstract class Person {
        public string name;
        public int age;
    }
    class Student : Person { 
        public double grades;
    }
     class Program
    {
        static void Main(string[] args)
        {
            // can not create instance (object)
            // only for inheritance
            Person p = new Person();
            Student s1 = new Student();
        }
    }
}
