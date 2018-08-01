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

namespace TuesdayLecture
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Turtle tess;
		public MainWindow()
		{
			InitializeComponent(); // inituialises the GUI 
			tess = new Turtle(playground, 100, 200);
			// the below also works, but situates tess at the coordinate (20,200)
			// tess = new Turtle(playground);
			tess.BrushWidth = 1.5;
			tess.BodyBrush = Brushes.Blue;
			tess.LineBrush = Brushes.Blue;
		}

		/// <summary>
		/// Event handler for moving tess
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnMove_Click(object sender, RoutedEventArgs e)
		{
			tess.Forward(80.0);   
			tess.Right(90.0);
			tess.Forward(80.0);
			tess.Right(90.0);
			tess.Forward(80.0);
			tess.Right(90.0);
			tess.Forward(80.0);
			tess.Right(90.0);
		}
	}
}
