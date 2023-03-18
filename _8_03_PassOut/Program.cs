using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_03_PassOut
{
    class Program
    {
        static void addFive(out int x)
        {
            x = 10;
            x += 5;
            Console.WriteLine("inside method value is {0}", x);
        }
        static void Main(string[] args)
        {
            int z = 20;
            Console.WriteLine("before calling method the value is {0}", z);
            addFive(out z);
            Console.WriteLine("After Calling method the value is {0}", z);

        }
    }
}
