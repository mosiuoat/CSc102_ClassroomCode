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

namespace MondayLecture
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		/// <summary>
		/// This is a special method called a 'constructor' which has the same name as the class
		/// </summary>
		public MainWindow()
		{
			// The InitializeComponent method is a special method belonging to MainWindow that initializes the GUI elements
			InitializeComponent();
			
			// only type in any initialization code after this line
		}

		/// <summary>
		/// Event handler for the onClick event
		/// </summary>
		/// <param name="sender">the object that invoked the event that fired the event handler</param>
		/// <param name="e">contains information about the event</param>
		private void btnSend_Click(object sender, RoutedEventArgs e)
		{
			// MessageBox is a pre-existing class that belongs to the System.Windows namespace
			// It has an overloaded Show() method that can be used to print content in the MessageBox
			MessageBox.Show(string.Format("Your message to {0} has been sent!", txtBoxMessage.Text));

			// The sender points to the originator of the event, in this case, the button
			MessageBox.Show(string.Format("You clicked on {0} button", e.Source));
		}
	}
}
