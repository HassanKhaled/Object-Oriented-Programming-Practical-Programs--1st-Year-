using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _10_06_NestedCMethods
{
    class Container
    {
        public static string title = "this is just my title";
        public string name = "this is my name";
        public Container()
        {
            Console.WriteLine("Container ");
        }
        public void outerClassMethod() {

            Console.WriteLine("Outer Class Method");
        }
        public class Nested
        {
            public Nested()
            {
                Console.WriteLine("Nested Object Created ...");
            }
            public void InnerClassMethod() {

                Console.WriteLine(" Your Title is {0}", title);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Container c = new Container();
            Container.Nested n = new Container.Nested();
            c.outerClassMethod();
            n.InnerClassMethod();
        }
    }
}
