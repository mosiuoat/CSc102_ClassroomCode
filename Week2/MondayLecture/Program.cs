using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayLecture
{
	class Program
	{
		static void Main(string[] args)
		{
			int int_a;
			long la_a = 38921738921731;
			short sh_a = 78;
			byte bt_a = 6;
			int_a = bt_a;
			int_a = sh_a;
			int_a = (int) la_a;
			Console.WriteLine(int_a);

			bool bool_a = (5 < 7);

			int x = 5;
			if(x > 5)
			{
				Console.WriteLine("The value is greater than 5");
			}
			else
			{
				if (x == 5) Console.WriteLine("the value is 5");
				else Console.WriteLine("Value is less than 5");
			}

			Console.ReadLine();
		}
	}
}
