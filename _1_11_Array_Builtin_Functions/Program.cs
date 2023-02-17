using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_11_Array_Builtin_Functions
{
     class Program
    {
        static void Main(string[] args)
        {

            // 1.11 using Array built in methods
            int[] numbers = { 1, 5, 9, 6, 5, 2, 4, 2, 6, 2, 0 };

            Console.WriteLine("Sum = " + numbers.Max());
            Console.WriteLine("Min = " + numbers.Min());
            Console.WriteLine("Max = " + numbers.Sum());
            Console.WriteLine("Average = {0}", numbers.Sum() / numbers.Length);
        }
    }
}
