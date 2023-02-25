using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_02_Priting2DArrays
{
     class Program
    {
        static void Main(string[] args)
        {
         
            int[,] arrNums1 = new int[2, 2] { { 11, 22 }, { 33, 44 } };
            Print2DArray(arrNums1);

        }

        static void Print2DArray(int[,] arr) {

            for (int r = 0; r < arr.GetLength(0); r++)
            {
                for (int c = 0; c < arr.GetLength(1); c++)
                {
                    Console.Write(arr[r,c]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
