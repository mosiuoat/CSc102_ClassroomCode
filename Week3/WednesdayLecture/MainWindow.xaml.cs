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
		// We call tess an object aka an instance of type Turtle
		// Turtle is the class, tess is the object (instance of the Turtle class)
		enum OPERATOR {  ADD, MINUS, MULT, DIV, ERROR, EXIT };
		Turtle tess;
		
		public MainWindow()
		{
			// InitializeComponent() initialises GUI components - part of Window class
			InitializeComponent();

			// A constructor is a special method which bears the same name as the class
			// When you call a constructor, it creates an instance of the class and returns it on the LHS
			// The constructor has a retyrn type that corresponds to the class

			// The Turtle() constructor is overloaded and has two versions
			// A Turtle is tied to a canvas, so the canvas name is an argument in the constructor
			// In the below, the Turtle is positioned at the coordinate (200, 200)
			tess = new Turtle(playground, 200, 200);
			// In the bottom version, specific coordinates are not given so the turtle defaults to position (20, 200)
			// tess = new Turtle(playground)

			// The turtle has properties - these can only be set once you've created an instance
			// A failure to create an instance, leads to a null exception (runtime error)
			tess.BrushWidth = 2.0;
			tess.BrushDown = false;
		}

		/// <summary>
		/// Event handler for the Go button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnGo_Click(object sender, RoutedEventArgs e)
		{
			tess.Forward(75);
			tess.Stamp();
			tess.Forward(-75);
			tess.Left(30);
			tess.Forward(75);
			tess.Stamp();
			tess.Forward(-75);
		}
	}
}
