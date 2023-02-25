using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_06_SquareArrCheck
{
     class Program
    {
        static void Main(string[] args)
        {
            int[,] arrNums1 = new int[2, 2] { { 11, 22 }, { 33, 44 } };
            int[,] arrNums2 = new int[2, 3];

            Console.WriteLine("is first Array Square {0}",isSquare(arrNums1));
            Console.WriteLine("is first Array Square {0}", isSquare(arrNums2));
        }
        static bool isSquare(int[,] arr) {
           return arr.GetLength(0)==arr.GetLength(1);
        }


    }
}
