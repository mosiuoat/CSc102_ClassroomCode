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
			// ------------- IMPLICIT AND EXPLICIT CASTING
			// The ConvertTo() methods are convenience methods to help us convert between types
			// Without these methods we can still perform conversion using casting

			int int_a;
			long lg_a = 38921738921731;
			short sh_a = -23564;
			byte bt_a = 255;
			double dbl_a = 1172771.20191;

			int_a = bt_a; // this implicit cast from byte to int is allowed
			int_a = sh_a; // this implicit cast from short to int is allowed
			sh_a = bt_a; // this implicit cast from byte to short is allowed
			dbl_a = lg_a; // this implicit cast from long to double is allowed
			// int_a = lg_a; // this implicit cast from long to int is not allowed
			// lg_a = dbl_a; this implicit cast from double to long is not allowed

			int_a = (int) lg_a; // this explicit cast from long to int is allowed
			bt_a = (byte) sh_a; // this explicit cast from short to byte is allowed
			lg_a = (long) dbl_a; // this explicit cast from double to long is allowed

			Console.WriteLine(string.Format("{0},{1},{2},{3},{4}", int_a, sh_a, bt_a, lg_a, dbl_a));

			// ------------ BOOLEANS AND CONDITIONAL STATEMENTS
			// Please see http://www.ict.ru.ac.za/resources/ThinkSharply/ThinkSharply/conditionals.html
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
