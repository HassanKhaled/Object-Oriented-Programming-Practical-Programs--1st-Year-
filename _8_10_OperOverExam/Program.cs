using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10_OperOverExam
{
    class Student
    {
        public string name;
        public int age;
        public double grade;
        public Student()
        { }
        public Student(string name, int age, double grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Name :{0}, Age {1} , Grade  {2}", name, age, grade);
        }

        // accessModifier static className operator operatorType (Paramter){ statments}
        public static Student operator +(Student first, Student second)
        {
            Student result = new Student();
            result.grade = first.grade + second.grade;
            result.age = first.age + second.age;
            return result;
        }
        public static Student operator ++(Student first)
        {
            Student result = new Student();
            first.grade += 10;

            return first;
        }
        public static Student operator --(Student first)
        {
            Student result = new Student();
            first.grade -= 10;

            return first;
        }
        public static Student operator -(Student first)
        {
            Student result = new Student();
            first.grade = -first.grade;

            return first;
        }
        public static Student operator +(Student first, double second)
        {
            Student result = new Student();
            result.grade = first.grade + second;

            return result;
        }
        public static Student operator +(double first, Student second)
        {
            Student result = new Student();
            result.grade = first + second.grade;
            return result;
        }

        public static Student operator -(Student first, Student second)
        {
            Student result = new Student();
            result.grade = first.grade - second.grade;
            result.age = first.age - second.age;
            return result;
        }
        public static Student operator *(Student first, Student second)
        {
            Student result = new Student();
            result.grade = first.grade * second.grade;
            return result;
        }

        public static Student operator /(Student first, Student second)
        {
            Student result = new Student();
            result.grade = first.grade / second.grade;
            result.age = first.age / second.age;
            return result;
        }
        public static Student operator %(Student first, Student second)
        {
            Student result = new Student();
            result.grade = first.grade % second.grade;
            result.age = first.age % second.age;
            return result;
        }

        public static Student operator >(Student first, Student second)
        {
            Student result = new Student();
            if (first.age > second.age)
                result.age = first.age - second.age;
            return result;
        }
        public static Student operator <(Student first, Student second)
        {
            Student result = new Student();
            if (first.age < second.age)
                result.age = second.age - first.age;
            return result;
        }
        public static Student operator >=(Student first, Student second)
        {
            Student result = new Student();
            if (first.age >= second.age)
                result.age = first.age - second.age;
            return result;
        }
        public static Student operator <=(Student first, Student second)
        {
            Student result = new Student();
            if (first.age <= second.age)
                result.age = second.age - first.age;
            return result;
        }
        public static Student operator !=(Student first, Student second)
        {
            Student result = new Student();
            if (first.age != second.age)
                result.age = second.age - first.age;
            return result;
        }
        public static Student operator ==(Student first, Student second)
        {
            Student result = new Student();
            if (first.age == second.age)
                result.age = second.age - first.age;
            return result;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] sts = { new Student("Ahmed", 32, 96) ,
            new Student("Wal", 25, 86),
            new Student("Karim", 23, 78),
            new Student("sami", 42, 89),
            new Student("Ahmed", 32, 92)};
            
            Student result = new Student();
            foreach (var s in sts)
                result += s;

            Console.WriteLine("Total Age is {0} , total grades is {1}",result.age,result.grade);
            Console.WriteLine("Average Age is {0} , Average grades is {1}", result.age/sts.Length, result.grade/sts.Length);
        }
    }
}
