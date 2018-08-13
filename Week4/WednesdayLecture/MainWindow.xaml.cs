using System;
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
		Turtle tess;
		enum ROTATION { LEFT, RIGHT};

		public MainWindow()
		{
			InitializeComponent();

			tess = new Turtle(canvas,0,0);
			tess.BrushDown = false;
		}
		/// <summary>
		/// Obtain the direction the turtle is facing
		/// </summary>
		/// <returns>the current Heading of the turtle</returns>
		double getHeading()
		{
			return tess.Heading;
		}
		/// <summary>
		/// Event handler to handle the heading button click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnHeading_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show(string.Format("{0}", getHeading()));
		}

		/// <summary>
		/// Returns the current position of the turtle
		/// </summary>
		/// <returns>The position of the Turtle as a Point</returns>
		Point getPosition()
		{
			return tess.Position;
		}

		/// <summary>
		/// Event handler to handle the position button click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnPosition_Click(object sender, RoutedEventArgs e)
		{
			Point p = getPosition();
			MessageBox.Show(string.Format("X is {0}, Y is {1}", p.X, p.Y));
		}
		/// <summary>
		/// Rotate the turtle in clockwise direction
		/// </summary>
		/// <param name="angle">angle to rotate</param>
		void rotate(double angle)
		{
			tess.Right(angle);
		}
		/// <summary>
		/// Rotate the turtle left or right
		/// </summary>
		/// <param name="rotate">choice of left or right</param>
		/// <param name="angle">angle to rotate</param>
		void rotate(ROTATION rotate, double angle)
		{
			if(rotate == ROTATION.RIGHT)
			{
				tess.Right(angle);
			}
			else
			{
				tess.Left(angle);
			}
		}

		/// <summary>
		/// Event handler to handle the rotate button click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnRotate_Click(object sender, RoutedEventArgs e)
		{
			rotate(ROTATION.LEFT, 270);
		}

		/// <summary>
		/// Warps the turtle to position (X,Y) in canvas coordinates
		/// </summary>
		/// <param name="x">position in x axis to warp to</param>
		/// <param name="y">position in y axis to warp to</param>
		void warpTo(double x, double y)
		{
			tess.WarpTo(x, y);
		}

		/// <summary>
		/// Event handler to handle the warp button click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnWarp_Click(object sender, RoutedEventArgs e)
		{
			double x = Convert.ToDouble(txtXPos.Text);
			double y = Convert.ToDouble(txtYPos.Text);

			warpTo(x, y);
		}

		/// <summary>
		/// Shifts the turtle by the x (left and right) and y values (top to bottom)
		/// </summary>
		/// <param name="x">distance to shift in x direction</param>
		/// <param name="y">distance to shift in y direction</param>
		void shift(double x, double y)
		{
			Point p = tess.Position;
			p.X = p.X + x;
			p.Y = p.Y + y;

			tess.WarpTo(p.X, p.Y);
		}

		/// <summary>
		/// Event handler to handle the shift button click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnShift_Click(object sender, RoutedEventArgs e)
		{
			double x = Convert.ToDouble(txtXPos.Text);
			double y = Convert.ToDouble(txtYPos.Text);
			shift(x, y);
		}

		/// <summary>
		/// Event handler to handle the test button click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnTest_Click(object sender, RoutedEventArgs e)
		{
			Turtle alex = new Turtle(canvas, 0, 0);
			// the Visible property is a bool that makes the turtle visible or invisble
			alex.Visible = false;

			// we test that our constructor above works by testing if tess is at the origin (0,0)
			Tester.TestEq(alex.Position, new Point(0, 0));
			
			// this does the same thing
			Point p = new Point(0, 0);
			Tester.TestEq(alex.Position, p);
			Tester.TestEq(alex.Position.X, p.X);
			Tester.TestEq(alex.Position.Y, p.Y);
		}
	}
}
