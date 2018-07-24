using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuesdayLecture
{
	class Program
	{
		static void Main(string[] args)
		{
			bool cond1 = true || false;
			cond1 = true && false;
			cond1 = true || (5 < 7);
			cond1 = !true && !false;
			cond1 = (5 < 8) && !(9 < 7);
			int num = 9;
			bool flag = num < 0 ? true : false;
			int x = 0;
			x = x < 0 ? x + 1 : x - 1;
			x = x < 0 ? 0 : 1;

			x = -9;

			if(x.CompareTo(0) == 0)
			{
				if (x < 5)
				{
					x = x + 1;
					x = x + 2;
				}
				Console.WriteLine("Less than 10");
			}
			else if(x.CompareTo(0) < 0)
			{
				Console.WriteLine("Less than 0");
			}
			else 
			{
			Console.WriteLine("Greater than 0");
			}




			Console.ReadLine();
		}
	}
}
