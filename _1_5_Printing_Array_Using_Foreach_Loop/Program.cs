using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5_Printing_Array_Using_Foreach_Loop
{
     class Program
    {
        static void Main(string[] args)
        {

            //1.5 priting array using foreach loop
            int[] nums = { 1, 2, 4, 9, 3, 1, 0 };
            string[] names = { "hassan", "ahmed", "mohamed" };
            double[] dnums = { 1.2, 5.3, 125.3 };

            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }

            foreach (string item in names)
            {
                Console.WriteLine(item);
            }

            foreach (var item in dnums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
