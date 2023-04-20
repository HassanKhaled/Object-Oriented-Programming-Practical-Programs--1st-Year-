using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_09_NullExc
{
     class Program
    {
        static void printArr (int[] arr)
        {
            if (arr==null)
                throw new NullReferenceException("Array Refeence is null");
            else
                foreach (var item in arr) 
                    Console.WriteLine(item);
        }
        static void Main(string[] args)
        {
            int[] myArr = null;
            Console.WriteLine("Before Exception");
            try
            {
                printArr(myArr);
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
            Console.WriteLine("After Exception");
        }
    }
}
