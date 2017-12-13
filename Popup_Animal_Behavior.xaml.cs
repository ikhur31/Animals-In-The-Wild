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
using System.Windows.Shapes;

namespace Assignment2
{
	/// <summary>
	/// Interaction logic for Popup_Animal_Behavior.xaml
	/// </summary>
	public partial class Popup_Animal_Behavior : Window
	{
		public Popup_Animal_Behavior()
		{
			InitializeComponent();
		}

		private void Confirm_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
