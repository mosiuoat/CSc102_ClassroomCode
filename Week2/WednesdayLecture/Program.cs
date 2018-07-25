using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WednesdayLecture
{
	class Program
	{
		// ----- ENUMERATED TYPES
		// This code defines three enum types and lists their constants
		enum Days { Mon, Tues, Wed, Thur, Fri };
		enum Race: short { Beginning, Middle, End };
		enum Height : ulong { Short, Tall };

		static void Main(string[] args)
		{
			int a = 1200, b = 0, c = 0;
			if (a > 0 && a < 1000)
			{
				b = 10;
				c = -10;
			}
			else if (a >= 1000 && a < 2000)
			{
				b = 20;
				c = -20;
			}
			else 
			{
				b = 30;
				c = -30;
			}
			
			// ------- SWITCH STATEMENT
			// This code switches on an integer variable
			switch (a)
			{
				case 1000: { b = 10; c = -10; } break;
				case 2000: { b = 20; c = -20; } break;
				case 3000: { b = 30; c = -30; } break;
				default: b = -1; c = -1; break;
			}

			// ------ SWITCH STATEMENT
			// This code switches on an enum type
			Days myDay = Days.Wed;
			switch(myDay)
			{
				case Days.Mon: b = 10; break;
				case Days.Tues: b = 20; break;
				default: break;
			}

			Console.ReadLine();
		}
	}
}
