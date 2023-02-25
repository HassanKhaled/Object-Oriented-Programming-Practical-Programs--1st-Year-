using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_08_SumAverDiagonSquaArr
{
     class Program
    {
        static void Main(string[] args)
        {
            int[,] arrNums1 = new int[2, 2] { { 11, 22 }, { 33, 44 } };
            Console.WriteLine("Sum of Diagonal is {0}",SumDiagonalSquare(arrNums1));
            Console.WriteLine("Average od Diagnoal is {0}",AverageDiagonalSquare(arrNums1));
        }
        static bool isSquare(int[,] arr)
        {
            return arr.GetLength(0) == arr.GetLength(1);
        }
        static int SumDiagonalSquare(int[,] arr) {
            int sum = 0;

            if (isSquare(arr))
            {
                for (int r = 0; r < arr.GetLength(0); r++)
                    for (int c = 0; c < arr.GetLength(1); c++)
                        if (r == c)
                            sum += arr[r, c];
            }
            return sum;
        }
        static double AverageDiagonalSquare(int[,] arr) {
            return SumDiagonalSquare(arr) / arr.GetLength(0);
        
        }
    }
}
