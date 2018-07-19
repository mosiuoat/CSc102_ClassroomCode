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
			// This is writeline stuff 
			/*  anything i write here is also a comment */
			Console.WriteLine(args[0]);
			Console.WriteLine(args[1]);
			Console.WriteLine(args[2]);
			Console.WriteLine(args[3]);
			Console.WriteLine(args[4]);

			Console.WriteLine(string.Format("first {0} then {1} and lastly {2}", args[0], args[1], args[2]));

			Console.ReadLine();
		}
	}
}
