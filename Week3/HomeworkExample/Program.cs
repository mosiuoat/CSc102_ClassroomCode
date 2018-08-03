using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkExample
{
	/// <summary>
	/// This is skeleton code for the Homework problem
	/// The code below should get you a head start on attacking the problem
	/// </summary>
	class Program
	{
		/// <summary>
		/// Converts a double into a long
		/// </summary>
		/// <param name="dbl">the number to be converted</param>
		/// <param name="num">the number to take on the converted value</param>
		/// <returns></returns>
		static bool toInt64(double dbl, ref long num)
		{
			// check if its positive or negative
			if (dbl > 0.0)
			{
				if(dbl > 9223372036854775807.5)
				{
					return false;
				}
				else
				{
					num = (long)dbl;
					// now you need to figure out how to check if you need to round num up or down
					// if the balance between dbl and num is > 0.5 round up
					// if the balance between dbl and num is < 0.5 round down
					
					// TODO
				}
			}
			else
			{
				// TODO 
			}
			return true;
		}
		static void Main(string[] args)
		{
			// instead of fixed values, the code should read from the command line argumentes
			double myDouble = 57838747837843;

			long myLong = 0;

			// you must pass myLong by reference not values in order to preserve changes to it made in your methods
			bool success = toInt64(myDouble, ref myLong);
		}
	}
}
