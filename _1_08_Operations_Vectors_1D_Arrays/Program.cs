using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_8_Operations_Vectors_1D_Arrays
{
     class Program
    {
        static void Main(string[] args)
        {
            //7. Operation on vectors (1D Array)
            int[] vector1 = { 1, 2, 3 };
            int[] vector2 = { 4, 5, 6 };
            int[] results = new int[3];

            sumVectors(vector1, vector2, results);
        }
        static void sumVectors(int[] v1, int[] v2, int[] r)
        {
            for (int i = 0; i < 3; i++)
            {
                r[i] = v1[i] + v2[i];
                Console.WriteLine("{0}+{1}={2}", v1[i], v2[i], r[i]);
            }

        }
    }
}
