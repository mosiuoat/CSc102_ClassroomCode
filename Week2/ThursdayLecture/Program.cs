using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThursdayLecture
{
	class Program
	{
		enum Days { Mon, Tues, Wed, Thur, Fri };
		enum Positions : short { Lecturer=3, Senior_Lect=5, Associate_Prof=7, Full_Prof=9};

		// ---- PASSING AN ARGUMENT BY REFERENCE
		static void negate (ref int a)
		{
			a = a * -1;
		}
		// ---- PASSING AN ARGUMENT BY VALUE
		static int negate(int a)
		{
			return a * -1;
		}

		static void Main(string[] args)
		{
			Positions mosPosition = Positions.Senior_Lect;
			short actualValue = 0;
			if (mosPosition == Positions.Associate_Prof) { };
			switch (mosPosition)
			{
				case Positions.Lecturer: { actualValue = (short)Positions.Lecturer; }; break;
				case Positions.Senior_Lect: actualValue = (short)Positions.Senior_Lect; break;
				case Positions.Associate_Prof: actualValue = (short)Positions.Associate_Prof; break;
				case Positions.Full_Prof : actualValue = (short)Positions.Full_Prof; break;
				default: actualValue = -1;  break;
			}
			int a = 9, b = 7;
			negate(ref a);
			a = negate(a);
			
			Console.WriteLine("a is {0}", a);

			Console.ReadLine();

		}
	}
}
