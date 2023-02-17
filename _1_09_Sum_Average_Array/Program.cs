using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_9_Sum_Average_Array
{
     class Program
    {
        static void Main(string[] args)
        {
            //1.9 sum and average of an array 
            int[] numbers = { 1, 5, 9, 6, 5, 2, 4, 2, 6, 2, 0 };
            Console.WriteLine(average(numbers));
        }

        static double average(int[] arr)
        {

            return SumArray(arr) / arr.Length;
        }

        static int SumArray(int[] arr)
        {
            int sum = 0;
            foreach (var i in arr)
            {
                sum += i;
            }
            return sum;
        }

    }
}
