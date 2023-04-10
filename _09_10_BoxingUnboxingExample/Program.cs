using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _09_10_BoxingUnboxingExample
{
     class Program
    {
        static void Main(string[] args)
        {
            //boxing
            object[] things = new object[5];
            things[0] = "thing";
            things[1] = 150;
            things[2] = 12.2441;
            things[3] = true;
            things[4] = 'h';

            foreach (var thing  in things)
            {
                if (thing is System.Double)
                {
                    //unboxing
                    Console.WriteLine((double)thing * (double)thing);
                }
                if (thing is System.Int32)
                {
                    //unboxing
                    Console.WriteLine((int)thing * (int)thing);
                }
                Console.WriteLine(thing);
            }
        }
    }
}
