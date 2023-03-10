using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myNameSpace
{
    public class Human
    {
        public string name;
        public int age;
        internal double salary;
    }
    public class Test {
        public void CreateHuman() {

            Human h1 = new Human();
            h1.salary = 1000;
            h1.age = 35;
            h1.name = "Hany";
        }
    }
}
