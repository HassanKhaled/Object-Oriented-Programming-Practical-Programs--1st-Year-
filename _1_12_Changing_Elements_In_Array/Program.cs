using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_12_Changing_Elements_In_Array
{
     class Program
    {
        static void Main(string[] args)
        {

            //11. changing element inside an array 
            int[] arr = { 1, 2, 3, 4, 5 };
            arr[0] = 10;
            arr[3] = 45;
            PrintArray(arr);
        }

        static void PrintArray(int[] arr)
        {

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
