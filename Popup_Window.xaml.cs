using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Assignment2
{
	/// <summary>
	/// Interaction logic for Popup_Window.xaml
	/// </summary>
	public partial class Popup_Window : Window
	{
		private int max_Animals;
		private int total_Animals;
		private int birdCounter;
		private int cricketCounter;
		private int frogCounter;
		private int hunterCounter;
		private int mouseCounter;
		private int snakeCounter;

		public Popup_Window()
		{
			InitializeComponent();

			max_Animals = 20;
			total_Animals = 0;
			birdCounter = 0;
			cricketCounter = 0;
			frogCounter = 0;
			hunterCounter = 0;
			mouseCounter = 0;
			snakeCounter = 0;

			Max_Animals.Content = "Max Animals Allowed: " + max_Animals;
		}

		private void Bird_Up_Click(object sender, RoutedEventArgs e)
		{
			if (total_Animals != max_Animals)
			{
				birdCounter++;
				Bird_Counter.Content = birdCounter.ToString();
				Bird_Counter.Foreground = Brushes.Black;
				total_Animals++;
			}
			else
			{
				Bird_Counter.Foreground = Brushes.Red;
			}
		}

		private void Bird_Down_Click(object sender, RoutedEventArgs e)
		{
			if (birdCounter != 0)
			{
				birdCounter--;
				Bird_Counter.Content = birdCounter.ToString();
				Bird_Counter.Foreground = Brushes.Black;
				total_Animals--;
			}
			else
			{
				Bird_Counter.Foreground = Brushes.Red;
			}
		}

		private void Cricket_Up_Click(object sender, RoutedEventArgs e)
		{
			if (total_Animals != max_Animals)
			{
				cricketCounter++;
				Cricket_Counter.Content = cricketCounter.ToString();
				Cricket_Counter.Foreground = Brushes.Black;
				total_Animals++;
			}
			else
			{
				Cricket_Counter.Foreground = Brushes.Red;
			}
		}

		private void Cricket_Down_Click(object sender, RoutedEventArgs e)
		{
			if (cricketCounter != 0)
			{
				cricketCounter--;
				Cricket_Counter.Content = cricketCounter.ToString();
				Cricket_Counter.Foreground = Brushes.Black;
				total_Animals--;
			}
			else
			{
				Cricket_Counter.Foreground = Brushes.Red;
			}
		}

		private void Frog_Up_Click(object sender, RoutedEventArgs e)
		{
			if (total_Animals != max_Animals)
			{
				frogCounter++;
				Frog_Counter.Content = frogCounter.ToString();
				Frog_Counter.Foreground = Brushes.Black;
				total_Animals++;
			}
			else
			{
				Frog_Counter.Foreground = Brushes.Red;
			}
		}

		private void Frog_Down_Click(object sender, RoutedEventArgs e)
		{
			if (frogCounter != 0)
			{
				frogCounter--;
				Frog_Counter.Content = frogCounter.ToString();
				Frog_Counter.Foreground = Brushes.Black;
				total_Animals--;
			}
			else
			{
				Frog_Counter.Foreground = Brushes.Red;
			}
		}

		private void Hunter_Up_Click(object sender, RoutedEventArgs e)
		{
			if (total_Animals != max_Animals)
			{
				hunterCounter++;
				Hunter_Counter.Content = hunterCounter.ToString();
				Hunter_Counter.Foreground = Brushes.Black;
				total_Animals++;
			}
			else
			{
				Hunter_Counter.Foreground = Brushes.Red;
			}
		}

		private void Hunter_Down_Click(object sender, RoutedEventArgs e)
		{
			if (hunterCounter != 0)
			{
				hunterCounter--;
				Hunter_Counter.Content = hunterCounter.ToString();
				Hunter_Counter.Foreground = Brushes.Black;
				total_Animals--;
			}
			else
			{
				Hunter_Counter.Foreground = Brushes.Red;
			}
		}

		private void Mouse_Up_Click(object sender, RoutedEventArgs e)
		{
			if (total_Animals != max_Animals)
			{
				mouseCounter++;
				Mouse_Counter.Content = mouseCounter.ToString();
				Mouse_Counter.Foreground = Brushes.Black;
				total_Animals++;
			}
			else
			{
				Mouse_Counter.Foreground = Brushes.Red;
			}
		}

		private void Mouse_Down_Click(object sender, RoutedEventArgs e)
		{
			if (mouseCounter != 0)
			{
				mouseCounter--;
				Mouse_Counter.Content = mouseCounter.ToString();
				Mouse_Counter.Foreground = Brushes.Black;
				total_Animals--;
			}
			else
			{
				Mouse_Counter.Foreground = Brushes.Red;
			}
		}

		private void Snake_Up_Click(object sender, RoutedEventArgs e)
		{
			if (total_Animals != max_Animals)
			{
				snakeCounter++;
				Snake_Counter.Content = snakeCounter.ToString();
				Snake_Counter.Foreground = Brushes.Black;
				total_Animals++;
			}
			else
			{
				Snake_Counter.Foreground = Brushes.Red;
			}
		}

		private void Snake_Down_Click(object sender, RoutedEventArgs e)
		{
			if (snakeCounter != 0)
			{
				snakeCounter--;
				Snake_Counter.Content = snakeCounter.ToString();
				Snake_Counter.Foreground = Brushes.Black;
				total_Animals--;
			}
			else
			{
				Snake_Counter.Foreground = Brushes.Red;
			}
		}

		private void Confirm_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
