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

			// ---------- ORDER OF PRECEDENCE
			// The order goes 1. brackets, 2. multiplication and division, 3. addition and subtraction
			int num4 = 5 + (6 * 2) / 4;
			int num5 = 8 % (10 / 5) * 5;
			int num6 = (9 * 5) % 2 / 3;

			Console.WriteLine(string.Format("{0},{1},{2},{3},{4},{5}", num1,num2,num3,num4, num5, num6));
			Console.ReadLine();
		}
	}
}
