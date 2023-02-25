using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_07_MinAndMaxArr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arrNums1 = new int[2, 2] { { 11, 22 }, { 33, 44 } };
            Console.WriteLine("min is {0}",min2DArray(arrNums1));
            Console.WriteLine("min is {0}", max2DArray(arrNums1));
        }
        static int min2DArray(int[,] arr)
        {
            int min = arr[0,0];
            for (int r = 1; r < arr.GetLength(0); r++)
                for (int c = 1; c < arr.GetLength(1); c++)
                    if (min>arr[r,c])
                        min = arr[r, c];
            return min;
        }
        static int max2DArray(int[,] arr)
        {
            int max = arr[0, 0];
            for (int r = 1; r < arr.GetLength(0); r++)
                for (int c = 1; c < arr.GetLength(1); c++)
                    if (max < arr[r, c])
                        max = arr[r, c];
            return max;
        }

    }
}
