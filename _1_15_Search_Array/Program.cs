using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_15_Search_Array
{
     class Program
    {
        static void Main(string[] args)
        {
            //1.15 search array for a specific element
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("does {0} exist in array {1}", 2, SearchArray(arr, 2));
            Console.WriteLine("does {0} exist in array {1}", 10, SearchArray(arr, 10));
            Console.WriteLine("index of {0} is {1}", 4, getIndex(arr, 4));
            Console.WriteLine("index of {0} is {1}", 9, getIndex(arr, 9));
            Console.WriteLine("enter element");
            int search = int.Parse(Console.ReadLine());
            Console.WriteLine("index of {0} is {1}", search, getIndex(arr, search));
        }

        static int getIndex(int[] arr, int element)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == element)
                    index = i;
            return index;
        }

        static bool SearchArray(int[] arr, int element)
        {
            bool flag = false; foreach (var i in arr)
                if (i == element)
                    flag = true;
            return flag;
        }
    }
}
