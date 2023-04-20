using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_06_ExceHandlingFinally
{
     class Program
    {
        static void Main(string[] args)
        {
			try
			{
				int x = int.Parse(Console.ReadLine());
			}
			catch (Exception E)
			{

				Console.WriteLine(E.Message);
			}
			finally {

				Console.WriteLine("this finally block");
			}

        }
    }
}
