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

			// the below does not work as the RHS is a double and the LHS an integer
			//int num5 = 16 / 2.0; 

			// ------------- ORDER OF PREDENCE
			// The order goes 1. brackets, 2. multiplication and division, 3. addition and subtraction
			int num4 = 5 + (6 * 2) / 4;

			Console.WriteLine(string.Format("{0},{1},{2},{3}", num1,num2,num3,num4));
			Console.ReadLine();
		}
	}
}
