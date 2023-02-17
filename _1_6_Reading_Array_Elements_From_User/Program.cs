using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_6_Reading_Array_Elements_From_User_For_Loop
{
     class Program
    {
        static void Main(string[] args)
        {
            //5 reading elements from user using for loop 
            int[] nums = new int[3];
            Console.WriteLine();
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("enter element number" + i);
                nums[i] = int.Parse(Console.ReadLine());
            }

            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
