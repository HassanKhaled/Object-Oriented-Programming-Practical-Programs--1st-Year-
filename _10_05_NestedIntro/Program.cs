using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_05_NestedIntro
{
    class Container {
        public Container()
        {
            Console.WriteLine("Container ");
        }
        public class Nested {
            public Nested()
            {
                Console.WriteLine("Nested Object Created ...");
            }
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            Container c = new Container();
            Container.Nested n = new Container.Nested();
        }
    }
}
