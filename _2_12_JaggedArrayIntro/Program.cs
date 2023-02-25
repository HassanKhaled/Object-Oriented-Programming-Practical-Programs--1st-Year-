using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_12_JaggedArrayIntro
{
     class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][] {
                new int[] { 1,2,3,4,5}, 
                new int[] {6,7,8 }, 
                new int[] { 8,9,10,11} };
            int[][] jagged1 = new int[][] {
                new int[] { 1,2,3,4,5},
                new int[] {6,7,8 },
                new int[] { 8,9,10,11} };
            int[][] jagged2=  {
                new int[] { 1,2,3,4,5},
                new int[] {6,7,8 },
                new int[] { 8,9,10,11} };
            int[][] jagged4 = new int[3][];
            int[][] jagged5;
            jagged1 = new int[4][];
        }
    }

}
