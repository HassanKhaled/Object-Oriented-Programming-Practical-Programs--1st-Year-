using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_07_Throw
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("before exception");
            try
            {
                throw new Exception("Welcome Exception ...");
            }
            catch (Exception E)
            { 
                Console.WriteLine(E.Message);
            }
            Console.WriteLine("after exception");
        }
    }
}
