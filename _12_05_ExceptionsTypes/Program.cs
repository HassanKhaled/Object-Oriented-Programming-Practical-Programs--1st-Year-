using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_05_ExceptionsTypes
{
    class Student {
        public string name;
        public int age;
    }
     class Program
    {
        static void Main(string[] args)
        {
            // out of bounds exception 
            //int[] nums = { 10, 20, 30, 40, 50 };
            //Console.WriteLine(nums[5]);

            // division by zero 
            //int x = 10, y = 0;
            //Console.WriteLine(x/y);

            //  null object reference exception
            Student s1 = null;
            s1.name = "Ahmed";
        }
    }
}
