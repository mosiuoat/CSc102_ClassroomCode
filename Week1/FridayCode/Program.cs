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
			int num1 = 5 + 6;
			int num2 = 7 - num1;
			int num3 = 6 / 8;
			int num4 = 5 + (6 * 2) / 4;

			Console.WriteLine(string.Format("{0}", num3));
			Console.ReadLine();
		}
	}
}
