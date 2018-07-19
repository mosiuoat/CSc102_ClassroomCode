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
			// -------------- COMMENTS ------------------------------------
			// Anything in Visual Studio with two forward slashes is a comment 
			/*  A forward slash and a star is also a comment */

			/*	The main method accepts an array of string arguments that can be passed to it when it executes 
				To populate this array of arguments, type a few values in the 'Start Options' box accessible from the following location in the menu:
				Project > ThursdayCode Properties... > Debug > Start Options */

			// -------------- WRITING TO THE CONSOLE ------------------------
			/* We can write some statements using the WRITELINE method to print out our arguments */
			Console.WriteLine(args[0]);
			Console.WriteLine(args[1]);
			Console.WriteLine(args[2]);
			Console.WriteLine(args[3]);
			Console.WriteLine(args[4]);

			// -------------- WRITING FORMATTED TEXT TO THE CONSOLE ------
			/* WriteLine is also an OVERLOADED METHOD with 19 different signatures for writing different data types to the console */
			Console.WriteLine(string.Format("arguments are {0}, followed by {1}, {2}, {3}, and lastly {4}", args[0], args[1], args[2], args[3], args[4]));

			// -------------- LOCAL VARIABLE DECLARATION AND ASSIGNMENT ---
			/* C# supports various DATA TYPES, the main ones we will use include int, double, bool, char and string */
			int inta = 24, intb = -1828181;
			double dbla = 12219.1211221, dblb = 4;
			bool bla = true, blb = false;
			char cha = 'A', chb = ',', chc = '&';
			string stra = "Hello World";

			Console.WriteLine(string.Format("inta has value {0} ", inta));

			// --------------- CONVERTING BETWEEN TYPES ---------------------
			/* You can perform a conversion between different types using the CONVERT class */
			stra = "192";
			inta = Convert.ToInt32(stra);
			Console.WriteLine(string.Format("inta has value {0} ", inta));

			stra = "-1222112";
			dbla = Convert.ToDouble(stra);
			Console.WriteLine(string.Format("dbla has value {0} ", dbla));
			
			stra = "true";
			bla = Convert.ToBoolean(stra);
			Console.WriteLine(string.Format("bla a has value {0} ", bla));

			// ------------------- TERMINATING THE CONSOLE ------------------
			// The CONSOLE terminates once it reaches the end of the MAIN METHOD so we read a line to keep it open ---
			Console.ReadLine();
		}
	}
}
