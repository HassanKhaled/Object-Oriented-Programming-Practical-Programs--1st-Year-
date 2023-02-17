using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_13_String_As_1D_Array
{
     class Program
    {
        static void Main(string[] args)
        {
            // 1.13 string variable as 1d charachter array
            string name = "Ahmed Mohamed";
            foreach (var c in name)
            {
                Console.WriteLine(c);
            }
        }
    }
}
