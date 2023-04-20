using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_08_DivideByZeroExc
{
     class Program
    { 
        static double divide(int first, int second) {
            if (second != 0)
            {
                return first / second;
            }
            else
            {
                throw new DivideByZeroException("the second number is zero ");
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Before Exception");
            try
            {
                divide(10, 0);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);   
            }
            Console.WriteLine("After Exception");

        }
    }
}
