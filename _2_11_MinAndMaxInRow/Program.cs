using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_11_MinAndMaxInRow
{
     class Program
    {
        static void Print2DArray(int[,] arr)
        {
            for (int r = 0; r < arr.GetLength(0); r++)
            {
                for (int c = 0; c < arr.GetLength(1); c++)
                    Console.Write(arr[r, c] + " ");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] arrNums1 = new int[2, 2] { { 11, 22 }, { 33, 44 } };
            Print2DArray(arrNums1);
            Console.WriteLine("Min is {0}",minCol2DArray(arrNums1,0));
            Console.WriteLine("Max is {0}", maxCol2DArray(arrNums1, 0));

        }
        static int maxCol2DArray(int[,] arr, int col)
        {
            int max = arr[0, col];
            for (int r = 1; r < arr.GetLength(0); r++)
                if (max< arr[r, col])
                    max = arr[r, col];
            return max;
        }
        static int minCol2DArray(int[,] arr, int col) {
            int min = arr[1, col];
            for (int r = 0; r < arr.GetLength(0); r++)
                if (min > arr[r,col])
                    min = arr[r, col];
            return min;
        }
    }
}
