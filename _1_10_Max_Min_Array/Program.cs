using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_10_Max_Min_Array
{
     class Program
    {
        static void Main(string[] args)
        {
            //1.10 max and min of an array
            int[] numbers = { 1, 5, 9, 6, 5, 2, 4, 2, 6, 2, 0 };
            Console.WriteLine(maxArray(numbers));
            Console.WriteLine(minArray(numbers));
        }

        static int minArray(int[] arr)
        {

            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
                if (min > arr[i])
                    min = arr[i];
            return min;
        }
        static int maxArray(int[] arr)
        {

            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
                if (max < arr[i])
                    max = arr[i];
            return max;
        }
    }
}
