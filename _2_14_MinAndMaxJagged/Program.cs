using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _2_14_MinAndMaxJagged
{
     class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][] {
                new int[] { 1,2,3,4,5},
                new int[] {6,7,8 },
                new int[] { 8,9,10,11} };
            Console.WriteLine("Max is {0}", MaxJaggedArray(jagged));
        }

        static int MaxJaggedArray(int[][] arr)
        { int max = arr[0][0];

            for (int i = 0; i < arr.Length; i++)
            {

                for (int x = 0; x < arr[i].Length; x++)
                {
                    if (max < arr[i][x])
                    {
                        max = arr[i][x];
                    }
                }
            }
            return max;
        }
    }
}
