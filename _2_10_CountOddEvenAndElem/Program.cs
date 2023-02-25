using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_10_CountOddEvenAndElem
{
     class Program
    {
        static void Main(string[] args)
        {
            int[,] arrNums1 = new int[2, 2] { { 11, 22 }, { 33, 44 } };
            Console.WriteLine("Odd Numbers {0} Counts ",countOddIn2DArray(arrNums1));
            Console.WriteLine("Even Numbers {0} Counts ", countEvenIn2DArray(arrNums1));
            Console.WriteLine("Number Numbers divisiable by 11 : {0} Counts ",countDivisableIn2DArray(arrNums1,11));
        }
        static int countDivisableIn2DArray(int[,] arr,int divisable)
        {
            int count = 0;
            for (int r = 0; r < arr.GetLength(0); r++)
                for (int c = 0; c < arr.GetLength(1); c++)
                    if (arr[r, c] % divisable == 0)
                        count++;
            return count;
        }
        static int countEvenIn2DArray(int[,] arr)
        {
            int count = 0;
            for (int r = 0; r < arr.GetLength(0); r++)
                for (int c = 0; c < arr.GetLength(1); c++)
                    if (arr[r, c] % 2 == 0)
                        count++;
            return count;
        }
        static int countOddIn2DArray(int[,] arr) {
            int count = 0;
            for (int r = 0; r < arr.GetLength(0); r++)
                for (int c = 0; c < arr.GetLength(1); c++)
                    if ( arr[r, c]%2==1)
                        count++;
            return count;
        }
    }
}
