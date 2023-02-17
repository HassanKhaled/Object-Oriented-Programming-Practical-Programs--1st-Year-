using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4_Priting_Array_Using_For_Loop
{
     class Program
    {
        static void Main(string[] args)
        {
            //1.4 priting array elements using for loop
            int[] nums = { 1, 2, 4, 9, 3, 1, 0 };
            string[] names = { "hassan", "ahmed", "mohamed" };
            double[] dnums = { 1.2, 5.3, 125.3 };

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(nums[i]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            Console.WriteLine(nums[0]);
            Console.WriteLine(names[2]);
            Console.WriteLine(dnums[1]);
        }
    }
}
