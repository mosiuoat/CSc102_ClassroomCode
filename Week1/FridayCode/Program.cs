using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayCode
{
	class Program
	{
		static void Main(string[] args)
		{
			// --------- OPERATORS AND OPERANDS
			// C# mostly supports the same operators that Python does
			int num1 = 5 + 6;
			int num2 = 7 - num1;
			int num3 = 6 / 8; // this chops off the trailing digits after the .
			int num4 = 5 + (6 * 2) / 4;
			// the below does not work as the RHS is a double and the LHS an integer
			//int num5 = 16 / 2.0; 

			Console.WriteLine(string.Format("{0},{1},{2},{3}", num1,num2,num3,num4));
			Console.ReadLine();
		}
	}
}
