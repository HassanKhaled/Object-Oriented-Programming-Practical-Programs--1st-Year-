using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_04_Read2DArray
{
     class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2];
            Read2DArray(arr);
        }

        static void Read2DArray(int[,] arr)
        {

            for (int r = 0; r < arr.GetLength(0); r++)
            {
                for (int c = 0; c < arr.GetLength(1); c++)
                {
                    Console.Write( "Enter Element [{0},{1}] ",r,c);
                    arr[r, c] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }
    }


}
