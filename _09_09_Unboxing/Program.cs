using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_09_Unboxing
{
     class Program
    {
        static void Main(string[] args)
        {
            double x = 10.25458;
            object xyz = x;

            double z = (double)xyz;
            Console.WriteLine(z);

        }
    }
}
