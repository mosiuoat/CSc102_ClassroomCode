using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ThinkLib;

namespace WednesdayLecture
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Turtle turtle;

		public MainWindow()
		{
			InitializeComponent();
			turtle = new Turtle(canvas, 0, 0);
			runTests();
		}

		int odds(int[] numbers)
		{
			int oddNums = 0;
			if (numbers == null) return -1;
			foreach (int num in numbers)
			{
				if (num % 2 == 1) oddNums++;
			}
			return oddNums;
		}

		double distInX(FootprintCollection fcp)
		{
			double dist = 0;
			Point p = new Point(0, 0);
			foreach(Footprint foot in fcp)
			{
				dist += Math.Abs(foot.Position.X - p.X);
				p = foot.Position;
			}

			return dist;
		}
		void runTests()
		{
			int[] nums = new int[] { 1, 2, 3, 4, 5 };

			Tester.TestEq(odds(nums), 3);

			nums = null;
			Tester.TestEq(odds(nums), -1);

			nums = new int[] { };
			Tester.TestEq(odds(nums), 0);

			turtle.WarpTo(50, 50);
			turtle.Stamp();

			Tester.TestEq(distInX(turtle.Footprints), 50);

			turtle.WarpTo(100, 50);
			turtle.Stamp();

			Tester.TestEq(distInX(turtle.Footprints), 100);

			turtle.WarpTo(150, 50);
			turtle.Stamp();

			Tester.TestEq(distInX(turtle.Footprints), 150);

			turtle.WarpTo(20, 50);
			turtle.Stamp();

			Tester.TestEq(distInX(turtle.Footprints), 280);
		}
	}
}
