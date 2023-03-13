using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_08_ParamsArray
{
    
     class Program
    {

        static int sumNumbers(int x, int y, params int[] arr) {
            int sum = x+y;
            foreach (var item in arr)
               sum += item;
            
            return sum;
        }
        static int minNumbers(int x, int y, params int[] arr)
        {
            int min = x;
            if (min >y)
                min = y;
            foreach (var item in arr)
                if (min>item)
                    min = item;
               
            return min;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("sum is {0}",sumNumbers(10,20));
            Console.WriteLine("sum is {0}",sumNumbers(10, 20,50));
            Console.WriteLine("sum is {0}",sumNumbers(10, 20,70,50));
            Console.WriteLine("sum is {0}",sumNumbers(10, 20,60,89,45));
            Console.WriteLine("sum is {0}",sumNumbers(10, 20, 60, 89, 45,89,45));
            Console.WriteLine("min is {0}", minNumbers(10, 20));
            Console.WriteLine("min is {0}", minNumbers(10, 20, 50));
            Console.WriteLine("min is {0}", minNumbers(10, 20, 70, 50));
            Console.WriteLine("min is {0}", minNumbers(10, 20, 60, 89, 45));
            Console.WriteLine("min is {0}", minNumbers(10, 20, 60, 89, 45, 89, 45));
        }
    }
}
