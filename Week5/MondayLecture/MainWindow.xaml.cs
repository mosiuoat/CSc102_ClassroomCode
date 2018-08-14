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

namespace MondayLecture
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Turtle tess;
		enum ROTATION { LEFT, RIGHT };
		public MainWindow()
		{
			InitializeComponent();

			tess = new Turtle(canvas, 0, 0);
			tess.BrushDown = false;
		}

		private void btnTest_Click(object sender, RoutedEventArgs e)
		{
			Turtle alex = new Turtle(canvas, 0, 0);
			// the Visible property is a bool that makes the turtle visible or invisible
			alex.Visible = false;

			// we test that our constructor above works by testing if tess is at the origin (0,0)
			Tester.TestEq(alex.Position, new Point(0, 0));

			// this does the same thing
			// Test Question: is the correctly turtle positioned at (0,0)
			Point startingPosition = new Point(0, 0);
			Tester.TestEq(alex.Position, startingPosition);
			Tester.TestEq(alex.Position.X, startingPosition.X);
			Tester.TestEq(alex.Position.Y, startingPosition.Y);

			// Test Question: is the turtle's heading correctly set to 0 when I rotate it four times?
			rotate(alex);
			rotate(alex);
			rotate(alex);
			rotate(alex);
			Tester.TestEq(alex.Heading, 0);

			// Test Question: does rotate() affect the position of the turtle?
			Tester.TestEq(alex.Position, startingPosition);

			// Test Question: does warpto() affect the position of the turtle?
			warpTo(alex, 200, 100);
			Tester.TestFailEq(alex.Position, startingPosition);

			// Test Question: does warpto() correctly set the X and Y coorindinates?
			Tester.TestEq(alex.Position, new Point(200, 100));
			Tester.TestFailEq(alex.Position, startingPosition);

			Turtle leo = new Turtle(canvas);
			leo.Visible = false;

			// Test Question: does Stamp consistently manage Footprints collection?
			stamp(leo);
			Tester.TestEq(leo.Footprints.Count, 1);

			warpTo(leo, 100, 100);

			// Test Question: does Stamp consistently manage Footprints collection?
			stamp(leo);
			Tester.TestEq(leo.Footprints.Count, 2);
			warpTo(leo, 200, 100);

			// Test Question: does Stamp consistently manage Footprints collection?
			stamp(leo);
			Tester.TestEq(leo.Footprints.Count, 3);
			warpTo(leo, 300, 100);

			// Test Question: does Stamp consistently manage Footprints collection?
			stamp(leo);
			Tester.TestEq(leo.Footprints.Count, 4);

			foreach (Footprint fp in leo.Footprints)
			{
				MessageBox.Show(string.Format("Turtle was at X pos {0} Y pos {1}", fp.Position.X, fp.Position.Y));
			}
		}
		
		/// <summary>
		/// Obtain the direction the turtle is facing
		/// </summary>
		/// <returns>the current Heading of the turtle</returns>
		double getHeading(Turtle t)
		{
			return t.Heading;
		}
		
		/// <summary>
		/// Event handler to handle the heading click event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnHeading_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show(string.Format("{0}", getHeading(tess)));
		}
		/// <summary>
		/// Rotates the turtle by 90 degrees clockwise
		/// </summary>
		/// <param name="t"></param>
		void rotate(Turtle t)
		{
			t.Right(90);
		}
		/// <summary>
		/// Rotate the turtle always in a clockwise direction
		/// </summary>
		/// <param name="angle">angle to rotate</param>
		void rotate(Turtle t, double angle)
		{
			t.Right(angle);
		}
		/// <summary>
		/// Rotate the turtle left or right
		/// </summary>
		/// <param name="rotate">choice of left or right</param>
		/// <param name="angle">angle to rotate</param>
		void rotate(Turtle t, ROTATION rotate, double angle)
		{
			if (rotate == ROTATION.RIGHT)
			{
				tess.Right(angle);
			}
			else
			{
				tess.Left(angle);
			}
		}

		/// <summary>
		/// Event handler to handler to rotate button click event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnRotate_Click(object sender, RoutedEventArgs e)
		{
			rotate(tess, ROTATION.RIGHT, 90);
		}

		/// <summary>
		/// Returns the current position of the turtle
		/// </summary>
		/// <returns>The position of the Turtle as a Point</returns>
		Point getPosition(Turtle t)
		{
			return t.Position;
		}

		/// <summary>
		/// Event handler to handle the position button click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnPosition_Click(object sender, RoutedEventArgs e)
		{
			Point p = getPosition(tess);
			MessageBox.Show(string.Format("X is {0}, Y is {1}", p.X, p.Y));
		}

		/// <summary>
		/// Warps the turtle to position (X,Y) in canvas coordinates
		/// </summary>
		/// <param name="x">position in x axis to warp to</param>
		/// <param name="y">position in y axis to warp to</param>
		void warpTo(Turtle t, double x, double y)
		{
			t.WarpTo(x, y);
		}
		
		/// <summary>
		/// Event handler to handle the button warp event click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>

		private void btnWarp_Click(object sender, RoutedEventArgs e)
		{
			if(txtXPos.Text.Length > 0 &&  txtYPos.Text.Length > 0)
			{
				double x = Convert.ToDouble(txtXPos.Text);
				double y = Convert.ToDouble(txtYPos.Text);

				warpTo(tess, x, y);
				return;
			}
			MessageBox.Show("Enter a value for the X and Y coorindates!!");
		}

		/// <summary>
		/// Shifts the turtle by the x (left and right) and y values (top to bottom)
		/// </summary>
		/// <param name="x">distance to shift in x direction</param>
		/// <param name="y">distance to shift in y direction</param>
		void shift(Turtle t, double x, double y)
		{
			Point p = tess.Position;
			p.X = p.X + x;
			p.Y = p.Y + y;

			warpTo(t, p.X, p.Y);
		}
		
		/// <summary>
		/// Event handler to handle the button shift event click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnShift_Click(object sender, RoutedEventArgs e)
		{
			if (txtXPos.Text.Length > 0 && txtYPos.Text.Length > 0)
			{
				double x = Convert.ToDouble(txtXPos.Text);
				double y = Convert.ToDouble(txtYPos.Text);

				shift(tess, x, y);
				return;
			}

			MessageBox.Show("Missing values for the X and Y co-orindates!!");
		}
		
		/// <summary>
		/// Stamps a footprint onto the canvas
		/// </summary>
		/// <param name="t">The stamping turtle</param>
		void stamp(Turtle t)
		{
			t.Stamp();
		}

		/// <summary>
		/// Event handler to handle the stamp event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnStamp_Click(object sender, RoutedEventArgs e)
		{
			stamp(tess);
		}
	}
}
