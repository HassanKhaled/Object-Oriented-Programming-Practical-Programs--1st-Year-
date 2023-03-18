using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_05_OperOverLoading
{
    class Student {
        public string name;
        public int age;
        public double grade;
        public Student()
        { }
        public Student(string name, int age , double grade )
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }
        public void PrintInfo() {
            Console.WriteLine("Name :{0}, Age {1} , Grade  {2}",name, age,grade);
        }

        // accessModifier static className operator operatorType (Paramter){ statments}
        public static Student operator +(Student first, Student second) {

            Student result = new Student();
            result.grade=first.grade+ second.grade;
            return result;
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ahmed",32,96);
            Student s2 = new Student("Mohamed", 34, 91);

            Student s3 = new Student();
            s1.PrintInfo();
            s2.PrintInfo();
            s3 = s1 + s2;
            s3.PrintInfo();
        }
    }
}
