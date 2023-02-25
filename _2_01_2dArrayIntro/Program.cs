using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_01_2dArrayIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // type [,] name = new type [row,col];
            int[,] arrNums = new int[2, 2];

            //type [,] name = new type [row, col]{{val, val},{val , val}};
            int[,] arrNums1 = new int[2, 2] { { 11,22},{ 33,44} };

            //type [,] name = new type [, ]{{val, val},{val , val}};
            int[,] arrNums2 = new int[,] { { 3, 4 }, { 5, 6 } };

            // type [,] name = {{val, val},{val , val}};
            int[,] arrNums3 = { { 3, 4 }, { 5, 6 } };


            // optional two step definition 
            // type [,] name;
            int[,] arrNums4;
            // name = new type [row,col];
            arrNums4 = new int[2, 2];
            arrNums4[0, 0] = 12;
            arrNums4[0, 1] = 15;
            arrNums4[1, 0] = 1;
            arrNums4[1, 1] = 5;

        }
    }
}
