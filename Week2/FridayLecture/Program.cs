using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayLecture
{
	class Program
	{
		// this variable is visible throughout the class and in all methods defined
		// static means that the varibale belongs to the class Program
		static int num1 = 8;
		
		/// <summary>
		/// A convenience method that writes out a string to the console
		/// </summary>
		/// <param name="text">string to write out</param>
		static void wr(string str)
		{
			Console.WriteLine("{0}", str);
		}
		/// <summary>
		/// A convenience method that writes out a string to the console
		/// </summary>
		/// <param name="str1">first string</param>
		/// <param name="str2">second string</param>
		/// <param name="str3">third string</param>
		static void wr(string str1, string str2, string str3)
		{
			Console.WriteLine("{0},{1},{2}", str1, str2, str3);
		}
		
		/// <summary>
		/// A convenience method that writes an integer to the console
		/// </summary>
		/// <param name="num2">integer to print out</param>
		static void wr(int num2)
		{
			Console.WriteLine("{0}", num2);
			num2 = 8;
		}
		
		/// <summary>
		/// Negates the value of the argument
		/// </summary>
		/// <param name="a">an integer to negate</param>
		static void negate(int a)
		{
			// 'a' is a local variable that only 'lives' inside the method
			// since the argument is passed by value not reference, the change is made locally but the argument in Main remains unchanged
			a = a * -1;
		}
		/// <summary>
		/// Negates the value of an argument
		/// </summary>
		/// <param name="a">an integer to negate</param>
		static void negate(ref int a)
		{
			// 'a' is a local variable that only 'lives' inside the method
			// the ref keyword ensures that the argument is passed by reference not value
			// thus the value in the argument in the argument list below is changed
			a = a * -1;
		}
		
		/// <summary>
		/// A method that adds together the numbers in an array
		/// </summary>
		/// <param name="args">string array from startup options</param>
		/// <returns></returns>
		static int add(string[] args)
		{
			int result = 0;
			int counter = 0;
			while (counter < args.Length)
			{
				//result = result + Convert.ToInt32(args[counter]);
				result += Convert.ToInt32(args[counter]);
				counter++;
			}

			return result;
		}

		/// <summary>
		/// Adds together the numbers in an array
		/// </summary>
		/// <param name="args">string array from startup options</param>
		/// <param name="forever">flag to indicate infinite loop</param>
		/// <returns></returns>
		static int add(string[] args, bool forever)
		{
			int result = 0;
			int counter = 0;
			// the below is an 'infinite' loop which we need to 'break' from to exit
			while (true)
			{
				if (counter == args.Length)
					break;
				result += Convert.ToInt32(args[counter]);
				counter++;
			}

			return result;
		}
		
		/// <summary>
		/// Main method
		/// </summary>
		/// <param name="args">string array from startup options</param>
		static void Main(string[] args)
		{
			int num1 = 6; // this has different 'scope' from num1 at the top
			string text = "Hello World";
			wr(text);

			wr(text, "Hello World", "\"Hello World\"");

			int num2 = 9;
			negate(num2);
			wr(num2);

			negate(ref num2);
			wr(num2);

			int result = add(args);
			wr(result);

			result = add(args, true);
			wr(result);

			Console.ReadLine();
		}
	}
}
