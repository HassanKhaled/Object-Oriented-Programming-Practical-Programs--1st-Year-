using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_05_SumAndAver2DArray
{
     class Program
    {
        static void Main(string[] args)
        {
            int[,] arrNums1 = new int[2, 2] { { 11, 22 }, { 33, 44 } };
            Console.WriteLine("Sum is {0}",Sum2DArray(arrNums1));
            Console.WriteLine("Average is {0}", Average2Darray(arrNums1));

        }
        static int Sum2DArray(int[,] arr)
        {
            int sum = 0;

            for (int r = 0; r < arr.GetLength(0); r++)
            {
                for (int c = 0; c < arr.GetLength(1); c++)
                {
                    sum += arr[r, c];
                }
            }
            return sum;
        }
        static double Average2Darray(int[,] arr) {

            return Sum2DArray(arr) / arr.Length;
        }
    }
}
