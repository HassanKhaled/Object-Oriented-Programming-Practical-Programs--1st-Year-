
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2_13_PritingJaggedArray
{
     class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][] {
                new int[] { 1,2,3,4,5},
                new int[] {6,7,8 },
                new int[] { 8,9,10,11} };

            PrintJaggedArray(jagged);

        }
        static void PrintJaggedArray(int[][] arr)
        {
          
            for (int i = 0; i < arr.Length; i++)
            {
                foreach (var item in arr[i])
                {
                    Console.Write(item);
                }
                //for (int x = 0; x < arr[i].Length; x++)
                //{
                //    Console.Write(arr[i][x]+" ");
                //}
                Console.WriteLine();
            }  
        }
    }
}
