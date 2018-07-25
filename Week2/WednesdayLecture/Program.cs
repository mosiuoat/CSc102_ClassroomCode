using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WednesdayLecture
{
	class Program
	{
		enum Days { Mon, Tues, Wed, Thur, Fri };
		enum Something: short { Beginning, Middle, End };
		enum Height : ulong { SHORT, TALL };

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
			
			switch (a)
			{
				case 1000: { b = 10; c = -10; } break;
				case 2000: { b = 20; c = -20; } break;
				case 3000: { b = 30; c = -30; } break;
				default: b = -1; c = -1; break;
			}

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
