using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_03_Print2DArrAsVectors
{
     class Program
    {
        static void Main(string[] args)
        {
            int[,] arrNums = { { 11, 22,12,45 }, { 33, 44,78,89 } };
            Print2DArrayAsVector(arrNums);
        }

        static void Print2DArrayAsVector(int[,] arr) {
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
