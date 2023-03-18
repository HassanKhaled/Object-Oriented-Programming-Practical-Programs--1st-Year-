using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_04_PassOutClass
{
    class MathOperations {
        public static void SquareArea(double length, out double area) {
            area = length * length;
        }
        public static void SqaureCirm(double length, out double cirm) {

            cirm = length * 4;
        }
        public static void SqaureCirmArea(double length, out double cirm, out double area)
        {
            area = length * length;
            cirm = length * 4;
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            double len=10.5, ar, cir;
            MathOperations.SqaureCirm(len, out cir);
            MathOperations.SquareArea(len, out ar);
            Console.WriteLine("the Cirm {0} and Area :{1} of square of length {2}",cir,ar,len);
        }
    }

}
