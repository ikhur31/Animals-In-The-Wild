using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Imaging;

namespace Assignment2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		String[,] rowColumn;
		int maxAnimals;
		Animals animals;
		Bird bird;
		Cricket cricket;
		Frog frog;
		Hunter hunter;
		Mouse mouse;
		Snake snake;

		public MainWindow()
		{
			InitializeComponent();

			Save.IsEnabled = false;
			Advance.IsEnabled = false;
			Settings.IsEnabled = false;
		}

		public string[,] MoveAnimals()
		{
			Random rnd = new Random();
			Animals animalImagePaths = new Animals();
			String[,] rowColumnTemp = new String[10,10];
			int noSpace;

			for (int row = 0; row < 10; row++)
			{
				for (int column = 0; column < 10; column++)
				{
					noSpace = 0;
					Get_Move: int move = rnd.Next(1, 5); // creates a number between 1 and 4

					int movement = 0;

					if (rowColumn[row, column] != null && rowColumn[row, column].Equals("bird.png"))
					{
						movement = bird.BirdSteps;
					}
					else if (rowColumn[row, column] != null && rowColumn[row, column].Equals("cricket.png"))
					{
						movement = cricket.CricketSteps;
					}
					else if (rowColumn[row, column] != null && rowColumn[row, column].Equals("frog.png"))
					{
						movement = frog.FrogSteps;
					}
					else if (rowColumn[row, column] != null && rowColumn[row, column].Equals("hunter.png"))
					{
						movement = hunter.HunterSteps;
					}
					else if (rowColumn[row, column] != null && rowColumn[row, column].Equals("mouse.png"))
					{
						movement = mouse.MouseSteps;
					}
					else if (rowColumn[row, column] != null && rowColumn[row, column].Equals("snake.png"))
					{
						movement = snake.SnakeSteps;
					}

					/*if(rowColumn[row,column] != null && rowColumn[row,column].Equals("bird.png"))
					{
						if(bird.BirdSteps == 0)
						{
							if (column != 9)
							{
								column++;
							}
							else
							{
								if (row != 9)
								{
									row++;
									column = 0;
								}
								else
								{
									break;
								}

							}

							goto Get_Move;
						}
					}
					else if (rowColumn[row, column] != null && rowColumn[row, column].Equals("cricket.png"))
					{
						if (cricket.CricketSteps == 0)
						{
							if (column != 9)
							{
								column++;
							}
							else
							{
								if (row != 9)
								{
									row++;
									column = 0;
								}
								else
								{
									break;
								}

							}

							goto Get_Move;
						}
					}
					else if (rowColumn[row, column] != null && rowColumn[row, column].Equals("frog.png"))
					{
						if (frog.FrogSteps == 0)
						{
							if (column != 9)
							{
								column++;
							}
							else
							{
								if (row != 9)
								{
									row++;
									column = 0;
								}
								else
								{
									break;
								}

							}

							goto Get_Move;
						}
					}
					else if (rowColumn[row, column] != null && rowColumn[row, column].Equals("hunter.png"))
					{
						if (hunter.HunterSteps == 0)
						{
							if (column != 9)
							{
								column++;
							}
							else
							{
								if (row != 9)
								{
									row++;
									column = 0;
								}
								else
								{
									break;
								}

							}

							goto Get_Move;
						}
					}
					else if (rowColumn[row, column] != null && rowColumn[row, column].Equals("mouse.png"))
					{
						if (mouse.MouseSteps == 0)
						{
							if (column != 9)
							{
								column++;
							}
							else
							{
								if (row != 9)
								{
									row++;
									column = 0;
								}
								else
								{
									break;
								}

							}

							goto Get_Move;
						}
					}
					else if (rowColumn[row, column] != null && rowColumn[row, column].Equals("snake.png"))
					{
						if (snake.SnakeSteps == 0)
						{
							if (column != 9)
							{
								column++;
							}
							else
							{
								if (row != 9)
								{
									row++;
									column = 0;
								}
								else
								{
									break;
								}

							}

							goto Get_Move;
						}
					}*/

					if (noSpace == 4)
					{
						column++;
						noSpace = 0;
					}

					if ((row == 0 && move == 1) || (row == 9 && move == 3) || (column == 0 && move == 4) || (column == 9 && move == 2))
					{
						goto Get_Move;
					}

					if (rowColumn[row, column] == null || (rowColumnTemp[row, column] != null && rowColumnTemp[row,column].Equals("done")))
					{
						// do nothing
						//rowColumnTemp[row, column] = rowColumn[row, column];
					}
					else
					{
						if (move == 1) // move up
						{
							if(row - movement > -1)
							{
								if (movement == 0)
								{

								}
								else if (rowColumn[row - movement, column] == null)
								{
									rowColumn[row - movement, column] = rowColumn[row, column];
									rowColumn[row, column] = null;
									rowColumnTemp[row - movement, column] = "done";
								}

								
							}
							else
							{
								noSpace++;
								goto Get_Move;
								
							}
						}
						else if (move == 2) // move right
						{
							if (column + movement < 10)
							{
								if (movement == 0)
								{

								}
								else if (rowColumn[row, column + movement] == null)
								{
									rowColumn[row, column + movement] = rowColumn[row, column];
									rowColumn[row, column] = null;
									rowColumnTemp[row, column + movement] = "done";
								}

								
							}
							else
							{
								noSpace++;
								goto Get_Move;
							}
						}
						else if (move == 3) // move down
						{
							if (row + movement < 10)
							{
								if (movement == 0)
								{

								}
								else if (rowColumn[row + movement, column] == null)
								{
									rowColumn[row + movement, column] = rowColumn[row, column];
									rowColumn[row, column] = null;
									rowColumnTemp[row + movement, column] = "done";
								}

								
							}
							else
							{
								noSpace++;
								goto Get_Move;
							}
						}
						else if (move == 4) // move left
						{
							if (column - movement > -1)
							{
								if(movement == 0)
								{

								}
								else if(rowColumn[row, column - movement] == null)
								{
									rowColumn[row, column - movement] = rowColumn[row, column];
									rowColumn[row, column] = null;
									rowColumnTemp[row, column - movement] = "done";
								}
							}
							else
							{
								noSpace++;
								goto Get_Move;
							}
						}
					}
				}
			}

			for (int row = 0; row < 10; row++)
			{
				for (int column = 0; column < 10; column++)
				{
					if(rowColumn[row, column] != null && !rowColumn[row,column].Equals("done"))
					{
						var img = new Image { Width = 50, Height = 50 };
						var bitmapImage = new BitmapImage(new Uri(animalImagePaths.Path + rowColumn[row, column], UriKind.RelativeOrAbsolute));

						img.Source = bitmapImage;

						img.SetValue(Grid.RowProperty, row);
						img.SetValue(Grid.ColumnProperty, column);

						main_Grid.Children.Add(img);
					}

				}
			}

			return rowColumn;
		}

		public string[,] UpdateAnimals()
		{
			for(int row = 0; row < 10; row++)
			{
				for (int column = 0; column < 10; column++)
				{
					bool animalDied = false;

					if (rowColumn[row, column] == null)
					{
						// do nothing
					}
					else if (rowColumn[row,column].Equals("bird.png"))
					{
						if(row > 0)
						{
							if (rowColumn[row - 1, column] == null)
							{

							}
							else if (rowColumn[row - 1, column].Equals(bird.BirdEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}

						if(row < 9)
						{
							if (rowColumn[row + 1, column] == null)
							{

							}
							else if (rowColumn[row + 1, column].Equals(bird.BirdEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}

						if(column > 0)
						{
							if (rowColumn[row, column - 1] == null)
							{

							}
							else if (rowColumn[row, column - 1].Equals(bird.BirdEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}

						if(column < 9)
						{
							if (rowColumn[row, column + 1] == null)
							{

							}
							else if (rowColumn[row, column + 1].Equals(bird.BirdEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}
					}
					else if (rowColumn[row, column].Equals("snake.png")) 
					{
						if (row > 0)
						{
							if (rowColumn[row - 1, column] == null)
							{

							}
							else if (rowColumn[row - 1, column].Equals(snake.SnakeEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}

						if (row < 9)
						{
							if (rowColumn[row + 1, column] == null)
							{

							}
							else if (rowColumn[row + 1, column].Equals(snake.SnakeEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}

						if (column > 0)
						{
							if (rowColumn[row, column - 1] == null)
							{

							}
							else if (rowColumn[row, column - 1].Equals(snake.SnakeEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}

						if (column < 9)
						{
							if (rowColumn[row, column + 1] == null)
							{

							}
							else if (rowColumn[row, column + 1].Equals(snake.SnakeEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}
					}
					else if (rowColumn[row, column].Equals("cricket.png"))
					{
						if(row > 0)
						{
							if (rowColumn[row - 1, column] == null)
							{

							}
							else if (rowColumn[row - 1, column].Equals(cricket.CricketEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}

						if(row < 9)
						{
							if (rowColumn[row + 1, column] == null)
							{

							}
							else if (rowColumn[row + 1, column].Equals(cricket.CricketEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}
						
						if (column > 0)
						{
							if (rowColumn[row, column - 1] == null)
							{

							}
							else if (rowColumn[row, column - 1].Equals(cricket.CricketEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}

						if (column < 9)
						{
							if (rowColumn[row, column + 1] == null)
							{

							}
							else if (rowColumn[row, column + 1].Equals(cricket.CricketEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}
					}
					else if (rowColumn[row, column].Equals("frog.png"))
					{
						if(row > 0)
						{
							if (rowColumn[row - 1, column] == null)
							{

							}
							else if (rowColumn[row - 1, column].Equals(frog.FrogEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}

						if (row < 9)
						{
							if (rowColumn[row + 1, column] == null)
							{

							}
							else if (rowColumn[row + 1, column].Equals(frog.FrogEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}

						if (column < 9)
						{
							if (rowColumn[row, column + 1] == null)
							{

							}
							else if (rowColumn[row, column + 1].Equals(frog.FrogEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}

						if(column > 0)
						{
							if (rowColumn[row, column - 1] == null)
							{

							}
							else if (rowColumn[row, column - 1].Equals(frog.FrogEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}
					}
					else if (rowColumn[row, column].Equals("hunter.png"))
					{
						if (row > 0)
						{
							if (rowColumn[row - 1, column] == null)
							{

							}
							else if (rowColumn[row - 1, column].Equals(hunter.HunterEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}

						if (row < 9)
						{
							if (rowColumn[row + 1, column] == null)
							{

							}
							else if (rowColumn[row + 1, column].Equals(hunter.HunterEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}

						if (column > 0)
						{
							if (rowColumn[row, column - 1] == null)
							{

							}
							else if (rowColumn[row, column - 1].Equals(hunter.HunterEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}

						if (column < 9)
						{
							if (rowColumn[row, column + 1] == null)
							{

							}
							else if (rowColumn[row, column + 1].Equals(hunter.HunterEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}
					}
					else if (rowColumn[row, column].Equals("mouse.png"))
					{
						if (row > 0)
						{
							if (rowColumn[row - 1, column] == null)
							{

							}
							else if (rowColumn[row - 1, column].Equals(mouse.MouseEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}

						if (row < 9)
						{
							if (rowColumn[row + 1, column] == null)
							{

							}
							else if (rowColumn[row + 1, column].Equals(mouse.MouseEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}

						if (column > 0)
						{
							if (rowColumn[row, column - 1] == null)
							{

							}
							else if (rowColumn[row, column - 1].Equals(mouse.MouseEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}

						if (column < 9)
						{
							if (rowColumn[row, column + 1] == null)
							{

							}
							else if (rowColumn[row, column + 1].Equals(mouse.MouseEats))
							{
								rowColumn[row, column] = null;
								animalDied = true;
							}
						}
					}

					if(animalDied == true)
					{
						maxAnimals--;
					}
				}
			}

			return rowColumn;
		}

		public string[,] GetAnimals()
		{
			Random rnd = new Random();
			maxAnimals = animals.Total_Animals;

			for(int i = 0; i < bird.BirdCounter; i++)
			{
				int row = rnd.Next(0, 10); // creates a number between 0 and 10
				int column = rnd.Next(0, 10); // creates a number between 0 and 10

				if (rowColumn[row, column] == null)
				{
					var img = new Image { Width = 50, Height = 50 };
					var bitmapImage = new BitmapImage(new Uri(animals.Path + "bird.png", UriKind.RelativeOrAbsolute));

					img.Source = bitmapImage;

					img.SetValue(Grid.RowProperty, row);
					img.SetValue(Grid.ColumnProperty, column);

					main_Grid.Children.Add(img);
					rowColumn[row, column] = "bird.png";
				}
				else
				{
					i--;
				}
			}

			for (int i = 0; i < cricket.CricketCounter; i++)
			{
				int row = rnd.Next(0, 10); // creates a number between 0 and 10
				int column = rnd.Next(0, 10); // creates a number between 0 and 10

				if (rowColumn[row, column] == null)
				{
					var img = new Image { Width = 50, Height = 50 };
					var bitmapImage = new BitmapImage(new Uri(animals.Path + "cricket.png", UriKind.RelativeOrAbsolute));

					img.Source = bitmapImage;

					img.SetValue(Grid.RowProperty, row);
					img.SetValue(Grid.ColumnProperty, column);

					main_Grid.Children.Add(img);
					rowColumn[row, column] = "cricket.png";
				}
				else
				{
					i--;
				}
			}

			for (int i = 0; i < frog.FrogCounter; i++)
			{
				int row = rnd.Next(0, 10); // creates a number between 0 and 10
				int column = rnd.Next(0, 10); // creates a number between 0 and 10

				if (rowColumn[row, column] == null)
				{
					var img = new Image { Width = 50, Height = 50 };
					var bitmapImage = new BitmapImage(new Uri(animals.Path + "frog.png", UriKind.RelativeOrAbsolute));

					img.Source = bitmapImage;

					img.SetValue(Grid.RowProperty, row);
					img.SetValue(Grid.ColumnProperty, column);

					main_Grid.Children.Add(img);
					rowColumn[row, column] = "frog.png";
				}
				else
				{
					i--;
				}
			}

			for (int i = 0; i < hunter.HunterCounter; i++)
			{
				int row = rnd.Next(0, 10); // creates a number between 0 and 10
				int column = rnd.Next(0, 10); // creates a number between 0 and 10

				if (rowColumn[row, column] == null)
				{
					var img = new Image { Width = 50, Height = 50 };
					var bitmapImage = new BitmapImage(new Uri(animals.Path + "hunter.png", UriKind.RelativeOrAbsolute));

					img.Source = bitmapImage;

					img.SetValue(Grid.RowProperty, row);
					img.SetValue(Grid.ColumnProperty, column);

					main_Grid.Children.Add(img);
					rowColumn[row, column] = "hunter.png";
				}
				else
				{
					i--;
				}
			}

			for (int i = 0; i < mouse.MouseCounter; i++)
			{
				int row = rnd.Next(0, 10); // creates a number between 0 and 10
				int column = rnd.Next(0, 10); // creates a number between 0 and 10

				if (rowColumn[row, column] == null)
				{
					var img = new Image { Width = 50, Height = 50 };
					var bitmapImage = new BitmapImage(new Uri(animals.Path + "mouse.png", UriKind.RelativeOrAbsolute));

					img.Source = bitmapImage;

					img.SetValue(Grid.RowProperty, row);
					img.SetValue(Grid.ColumnProperty, column);

					main_Grid.Children.Add(img);
					rowColumn[row, column] = "mouse.png";
				}
				else
				{
					i--;
				}
			}

			for (int i = 0; i < snake.SnakeCounter; i++)
			{
				int row = rnd.Next(0, 10); // creates a number between 0 and 10
				int column = rnd.Next(0, 10); // creates a number between 0 and 10

				if (rowColumn[row, column] == null)
				{
					var img = new Image { Width = 50, Height = 50 };
					var bitmapImage = new BitmapImage(new Uri(animals.Path + "snake.png", UriKind.RelativeOrAbsolute));

					img.Source = bitmapImage;

					img.SetValue(Grid.RowProperty, row);
					img.SetValue(Grid.ColumnProperty, column);

					main_Grid.Children.Add(img);
					rowColumn[row, column] = "snake.png";
				}
				else
				{
					i--;
				}
			}

			return rowColumn;
		}

		private void Advance_Click(object sender, RoutedEventArgs e)
		{
			main_Grid.Children.Clear();
			UpdateAnimals();
			rowColumn = MoveAnimals();
		}

		private void New_Click(object sender, RoutedEventArgs e)
		{
			main_Grid.Children.Clear();

			Popup_Window popup_Window = new Popup_Window();
			popup_Window.ShowDialog();

			Popup_Animal_Behavior popup_Animal_Behavior = new Popup_Animal_Behavior();
			popup_Animal_Behavior.ShowDialog();

			Save.IsEnabled = true;
			Advance.IsEnabled = true;
			Settings.IsEnabled = true;

			animals = new Animals();
			bird = new Bird();
			cricket = new Cricket();
			frog = new Frog();
			hunter = new Hunter();
			mouse = new Mouse();
			snake = new Snake();

			bird.BirdCounter = Int32.Parse(popup_Window.Bird_Counter.Content.ToString());
			cricket.CricketCounter = Int32.Parse(popup_Window.Cricket_Counter.Content.ToString());
			frog.FrogCounter = Int32.Parse(popup_Window.Frog_Counter.Content.ToString());
			hunter.HunterCounter = Int32.Parse(popup_Window.Hunter_Counter.Content.ToString());
			mouse.MouseCounter = Int32.Parse(popup_Window.Mouse_Counter.Content.ToString());
			snake.SnakeCounter = Int32.Parse(popup_Window.Snake_Counter.Content.ToString());
			animals.Total_Animals = bird.BirdCounter + cricket.CricketCounter + frog.FrogCounter + hunter.HunterCounter 
				+ mouse.MouseCounter + snake.SnakeCounter;

			bird.BirdSteps = Int32.Parse(((ComboBoxItem)popup_Animal_Behavior.Bird_Steps.SelectedItem).Tag.ToString());
			cricket.CricketSteps = Int32.Parse(((ComboBoxItem)popup_Animal_Behavior.Cricket_Steps.SelectedItem).Tag.ToString());
			frog.FrogSteps = Int32.Parse(((ComboBoxItem)popup_Animal_Behavior.Frog_Steps.SelectedItem).Tag.ToString());
			hunter.HunterSteps = Int32.Parse(((ComboBoxItem)popup_Animal_Behavior.Hunter_Steps.SelectedItem).Tag.ToString());
			mouse.MouseSteps = Int32.Parse(((ComboBoxItem)popup_Animal_Behavior.Mouse_Steps.SelectedItem).Tag.ToString());
			snake.SnakeSteps = Int32.Parse(((ComboBoxItem)popup_Animal_Behavior.Snake_Steps.SelectedItem).Tag.ToString());

			bird.BirdEats = ((ComboBoxItem)popup_Animal_Behavior.Bird_Eats.SelectedItem).Content.ToString() + ".png";
			cricket.CricketEats = ((ComboBoxItem)popup_Animal_Behavior.Cricket_Eats.SelectedItem).Content.ToString() + ".png";
			frog.FrogEats = ((ComboBoxItem)popup_Animal_Behavior.Frog_Eats.SelectedItem).Content.ToString() + ".png";
			hunter.HunterEats = ((ComboBoxItem)popup_Animal_Behavior.Hunter_Eats.SelectedItem).Content.ToString() + ".png";
			mouse.MouseEats = ((ComboBoxItem)popup_Animal_Behavior.Mouse_Eats.SelectedItem).Content.ToString() + ".png";
			snake.SnakeEats = ((ComboBoxItem)popup_Animal_Behavior.Snake_Eats.SelectedItem).Content.ToString() + ".png";


			rowColumn = new String[10, 10];

			rowColumn = GetAnimals();
		}
		

		private void Save_Click(object sender, RoutedEventArgs e)
		{

		}

		private void Close_Click(object sender, RoutedEventArgs e)
		{
			System.Windows.Application.Current.Shutdown();
		}

		private void Change_Behavior_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
