using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_02_staticMemb
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Student s4 = new Student();
            Student s5 = new Student();
            s1.name = "hamed";
            s1.age = 35;
            s1.PrintInfo();
            Console.WriteLine("# of Students is {0}",Student.count);
           
        }
    }
    class Student
    {
        public string name;
        public int age;
       public static int count;

        public Student()
        {
            count++;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Name : {0} , Age {1}", name, age);
        }
    }
}
