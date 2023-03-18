using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_01_PassValue
{
     class Program
    {    
        static void addFive(int x) {

            x += 5;
            Console.WriteLine("inside method value is {0}",x );
        }
        static void Main(string[] args)
        { 
            int z = 15;
            Console.WriteLine("before calling method the value is {0}",z);
            addFive(z);
            Console.WriteLine("After Calling method the value is {0}",z);

        }
    }
}
