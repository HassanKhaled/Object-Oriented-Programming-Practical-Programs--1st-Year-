using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_7_Passing_Array_As_Parameters
{
     class Program
    {
        static void Main(string[] args)
        {
            //1.7 passing array as paramters
            int[] nums = { 1, 2, 4, 9, 3, 1, 0 };

            int[] nums1 = new int[3];
            ReadArray(nums1);
            PrintArray(nums1);

        }

        static void ReadArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter element number : " + i);
                arr[i] = int.Parse(Console.ReadLine());
            }
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
