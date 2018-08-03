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

namespace FridayLecture
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Turtle tess;
		// You can have multiple turtles
		Turtle loch;
		public MainWindow()
		{
			// InitializeComponent() initialises GUI components - part of Window class
			InitializeComponent();

			// In the below, the Turtle is positioned at the coordinate (200, 200)
			tess = new Turtle(playground, 200, 200);
			
			// This is hw you add a second turtle to the canvas called playground
			loch = new Turtle(playground);
			// In the bottom version, specific coordinates are not given so the turtle defaults to position (20, 200)

			tess.BrushWidth = 2.0;
			tess.BrushDown = false;
		}

		/// <summary>
		/// Draws footprints on the canvas
		/// </summary>
		private void DrawStamps()
		{
			for (int i = 0; i < 12; i++)
			{
				tess.Forward(75);
				tess.Stamp();
				tess.Forward(-75);
				tess.Left(30);
			}
			
		}
		/// <summary>
		/// Event handler for the Go button click event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnGo_Click(object sender, RoutedEventArgs e)
		{
			// The combo box contains a discrete number of values
			// The Text property takes the text content of the selected item
			string lineColor = cmbColors.Text;

			DrawStamps();
			DrawHands(lineColor);
		}

		/// <summary>
		/// Draws the hands of the clock
		/// </summary>
		/// <param name="lineColor">a color value to draw the line</param>
		private void DrawHands(string lineColor)
		{
			switch (lineColor)
			{
				case "YELLOW": tess.LineBrush = Brushes.Yellow; break;
				case "PURPLE": tess.LineBrush = Brushes.Purple; break;
				default: break;
			}

			for (int i = 0; i < 12; i++)
			{
				tess.Forward(60);
				tess.BrushDown = true;
				tess.Forward(10);
				tess.BrushDown = false;
				tess.Forward(-70);
				tess.Left(30);
			}
		}
	}
}
