using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRevision
{
	class Program
	{
		enum CHOICE { YES, NO };
		static int midPoint(int[] nums)
		{
			int midpoint = 0;
			if (nums.Length % 2 == 0)
			{
				int num1, num2;
				num1 = nums[nums.Length / 2];
				num2 = nums[(nums.Length / 2) - 1];
				midpoint = (num1 + num2) / 2;
			}
			else
			{
				midpoint = nums[nums.Length / 2];
			}
			return midpoint;
		}
		static int average(int[] nums)
		{
			int average = 0;
			average = sum(nums) / nums.Length;
			return average;
		}
		static int sum(int[] nums)
		{
			int sum = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				sum += nums[i];
			}
			return sum;
		}
		static void q15()
		{
			//char choice = 'y';
			// The problems with the below switch are that:
			// (1) There are no break statements at the end of the case statements
			// (2) There is no default case

			//switch(choice)
			//{
			//	case 'y': Console.WriteLine("The lady is for turning");
			//	case 'n': Console.WriteLine("They lady is not for turning");
			//}

			CHOICE choice = CHOICE.YES;
			switch(choice)
			{
				case CHOICE.YES: Console.WriteLine("The lady is for turning"); break;
				case CHOICE.NO: Console.WriteLine("They lady is not for turning"); break;
				default: break;
			}
		}
		static void q14()
		{
			int []nums = new int[] { 1, 2, 3, 4};
			int mid = midPoint(nums);

			Console.WriteLine(string.Format("Midpoint is {0}",midPoint(nums)));
		}
		static void q13()
		{
			int[] nums = { 1, 2, 3, 4, 5 };
			int avg = average(nums);

			Console.WriteLine(string.Format("Average is {0}",avg));
		}
		static void q12()
		{
			int[] nums = { 1, 2, 3, 4, 5 };
			int summation = sum(nums);

			Console.WriteLine(string.Format("Sum is {0}", summation));
		}
		
		static void q10()
		{
			int x = 15, y = 10;

			Console.WriteLine(string.Format("{0}/{1} gives {2}", x, y, x / y));
		}
		static void q9()
		{
			int p = 11, q = 1;
			if (p / 3 > 3)
			{
				p = p * 2 - 1;
				q = p / 4;
			}
			else
			{
				if (p == 4)
				{
					p = p - 2;
					q = p % 2;
				}
				else
				{
					p = (p - 2) - (p - 3);
					q = p + 1;
				}
			}
			Console.WriteLine(string.Format("p is {0} q is {1}", p, q));
		}
		static void q8()
		{
			int k = 0, a = 20;
			while (k < 7)
			{
				a = a / 3;
				k = k + a;
			}
			Console.WriteLine(string.Format("k is {0} a is {1}", k, a));
		}
		static void Main(string[] args)
		{
			q8();
			q9();
			q10();
			q12();
			q13();
			q14();
			q15();

			Console.ReadLine();
		}
	}
}
