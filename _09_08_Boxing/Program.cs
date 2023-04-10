using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_08_Boxing
{
     class Program
    {
        static void Main(string[] args)
        {
            double x = 10.25458;
            object xyz = x;
            Console.WriteLine(xyz.GetType());
            Console.WriteLine(xyz.ToString());
        }
    }
}
