using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_14_Count_Odd_Even_Elements_Array
{
     class Program
    {
        static void Main(string[] args)
        {

            // 1.14 Count odd and even and specifice elements inside array 
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Numbers of Odd Elements is {0}", countOdd(arr));
            Console.WriteLine("Numbers of Even Elements is {0}", countEven(arr));
            Console.WriteLine("Numbers of 2 in array is {0}", countElement(arr, 2));
        }

        static int countElement(int[] arr, int element)
        {

            int count = 0;
            foreach (var i in arr)
                if (i == element)
                    count++;
            return count;
        }
        static int countEven(int[] arr)
        {
            int count = 0;
            foreach (var i in arr)
                if (i % 2 == 0)
                    count++;
            return count;
        }
        static int countOdd(int[] arr)
        {
            int count = 0;
            foreach (var i in arr)
                if (i % 2 == 1)
                    count++;
            return count;
        }
    }
}
