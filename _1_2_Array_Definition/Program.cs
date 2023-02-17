using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_Array_Definition
{
     class Program
    {
        static void Main(string[] args)
        {

            // 1.2 Array definition 
            
            //type[] name = new type[size];
            int[] nums = new int[5];

            // type [] name = new type []{value1,value2,value3};
            int[] nums2 = new int[] { 1, 7, 8, 5, 9, 6, 4, 2, 3, 3 };

            // type [] name = new type [size]{val1,val2,va3};
            int[] name = new int[3] { 1, 2, 3 };

            // type [] name = {value1,value2,value2};
            int[] nums1 = { 1, 2, 3, 4, 5, 6, };
        }
    }
}
