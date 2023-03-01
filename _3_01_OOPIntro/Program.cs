using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_01_OOPIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // make program to print student names and ages 
            //classic solution form first term 
            int a1 = 20, a2 = 21, a3 = 25, a4 = 16, a5 = 19;
            string n1 = "ahmed", n2 = "mohamed", n3 = "sami", n4 = "wael", n5 = "khaled";
            Console.WriteLine("name is {0}  age is {1}",n1,a1);
            Console.WriteLine("name is {0}  age is {1}", n2, a2);
            Console.WriteLine("name is {0}  age is {1}", n3, a3);
            Console.WriteLine("name is {0}  age is {1}", n4, a4);
            Console.WriteLine("name is {0}  age is {1}", n5, a5);
            Console.WriteLine("___________________________________________");
            // lastest approch using arrays as mentioned in first sections
            int[] ages = { 20, 21, 25, 16, 19 };
            string[] names = { "ahmed", "mohamed", "sami", "wael", "khaled" };
            for (int i = 0; i < ages.Length; i++)
                Console.WriteLine("name is {0}  age is {1}", names[i], ages[i]);

            // is there a way to gruop both names and ages in one container (OOP)

        }
    }
}
