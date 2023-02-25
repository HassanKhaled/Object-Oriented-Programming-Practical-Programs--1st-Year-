using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_09_Search2DArray
{
     class Program
    {
        static void Main(string[] args)
        {
            int[,] arrNums1 = new int[2, 2] { { 11, 22 }, { 33, 44 } };
            Console.WriteLine("does {0} exist in Array : {1}",1,ElementExistIn2DArray(arrNums1,1));
            Console.WriteLine("does {0} exist in Array : {1}", 44, ElementExistIn2DArray(arrNums1, 44));
            Console.WriteLine("Row of {0} of {1}",33,GetElementRowIn2DArray(arrNums1,33));
            Console.WriteLine("Col of {0} of {1}", 33, GetElementColIn2DArray(arrNums1, 33)); 
        }
        static int GetElementColIn2DArray(int[,] arr, int element)
        {
            int col = -1;

            for (int r = 0; r < arr.GetLength(0); r++)
            {
                for (int c = 0; c < arr.GetLength(1); c++)
                {
                    if (element == arr[r, c])
                    {
                        col = r;
                    }
                }
            }
            return col;
        }


        static int GetElementRowIn2DArray(int[,] arr, int element)
        {
            int row = -1;

            for (int r = 0; r < arr.GetLength(0); r++)
            {
                for (int c = 0; c < arr.GetLength(1); c++)
                {
                    if (element == arr[r, c])
                    {
                        row = r;
                    }
                }
            }
            return row;
        }

        static bool ElementExistIn2DArray(int[,] arr, int element) {
            bool flag = false;

            for (int r = 0; r < arr.GetLength(0); r++)
            {
                for (int c = 0; c < arr.GetLength(1); c++)
                {
                    if (element== arr[r, c])
                    {
                flag = true;
                    }
                }
            }
            return flag;
        }


    }
}
