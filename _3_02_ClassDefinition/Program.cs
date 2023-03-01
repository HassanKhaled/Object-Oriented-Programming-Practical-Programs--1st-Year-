using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_02_ClassDefinition
{

    // class nameOfClass { Attributes  & Actions }

    class Student {
        // accees modifer type variableName;
        public string name;
        public int age;
    
    }

     class Program
    {
        static void Main(string[] args)
        {
            // className variableName = new className();
            Student S1 = new Student();
            
            // array is object because of using new keyword
            int[] arr = new int[10];
            // write operation
            //objectName.attributeName = value;
            S1.name = "ahmed";
            S1.age = 25;

            //read operation
            //objectName.attributeName
            Console.WriteLine("Name: {0}",S1.name);
            Console.WriteLine("Age : {0}",S1.age);
        }
    }
}
