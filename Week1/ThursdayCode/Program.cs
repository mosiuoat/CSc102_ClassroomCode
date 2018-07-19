using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThursdayCode
{
	class Program
	{
		static void Main(string[] args)
		{
			// Anything in Visual Studio with two forward slashes is a comment 
			/*  A forward slash and a star is also a comment */

			/*	The main method accepts an array of string arguments that can be passed to it when it executes 
				To populate this array of arguments, type a few values in the 'Start Options' box accessible from the following location in the menu:
				Project > ThursdayCode Properties... > Debug > Start Options */

			// We can write some statements using the WriteLine method to print out our arguments
			Console.WriteLine(args[0]);
			Console.WriteLine(args[1]);
			Console.WriteLine(args[2]);
			Console.WriteLine(args[3]);
			Console.WriteLine(args[4]);

			/* Variable Definitions */
			/* C# supports various data types, the main ones we will use include int, double, bool, char and string */
			int inta = 24, intb = -18281, intc = -26161621;
			double dbla = 9.121, dblb = 455544455, dbc = 9191929.2919192;
			bool bla = true, blb = false;
			char cha = 'A', chb = ',', chc = '&', chd = '\u0056';
			string stra = "Hello World", strb = "Hello \"World \"";

			// WriteLine is also an overloaded method, meaning it can write more than just string values to the Console
			Console.WriteLine(string.Format("first {0} then {1} and lastly {2}", args[0], args[1], args[2]));

			Console.ReadLine();
		}
	}
}
