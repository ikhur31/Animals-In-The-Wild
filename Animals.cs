using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
	public class Animals
	{
		private String path = "pack://application:,,,/Assignment2;component/images/";
		private int total_Animals;

		public String Path
		{
			get { return path; }
		}

		public int Total_Animals
		{
			get
			{
				return total_Animals;
			}
			set
			{
				total_Animals = value;
			}
		}
	}

	public class Cricket : Animals
	{
		private int cricketCounter;
		private int cricketSteps;
		private string cricketEats;

		public int CricketCounter
		{
			get
			{
				return cricketCounter;
			}
			set
			{
				cricketCounter = value;
			}
		}

		public int CricketSteps
		{
			get
			{
				return cricketSteps;
			}
			set
			{
				cricketSteps = value;
			}
		}

		public string CricketEats
		{
			get
			{
				return cricketEats;
			}
			set
			{
				cricketEats = value;
			}
		}
	}

	public class Frog : Animals
	{
		private int frogCounter;
		private int frogSteps;
		private string frogEats;

		public int FrogCounter
		{
			get
			{
				return frogCounter;
			}
			set
			{
				frogCounter = value;
			}
		}

		public int FrogSteps
		{
			get
			{
				return frogSteps;
			}
			set
			{
				frogSteps = value;
			}
		}

		public string FrogEats
		{
			get
			{
				return frogEats;
			}
			set
			{
				frogEats = value;
			}
		}
	}

	public class Bird : Animals
	{
		private int birdCounter;
		private int birdSteps;
		private string birdEats;

		public int BirdCounter
		{
			get
			{
				return birdCounter;
			}
			set
			{
				birdCounter = value;
			}
		}

		public int BirdSteps
		{
			get
			{
				return birdSteps;
			}
			set
			{
				birdSteps = value;
			}
		}

		public string BirdEats
		{
			get
			{
				return birdEats;
			}
			set
			{
				birdEats = value;
			}
		}
	}

	public class Mouse : Animals
	{
		private int mouseCounter;
		private int mouseSteps;
		private string mouseEats;

		public int MouseCounter
		{
			get
			{
				return mouseCounter;
			}
			set
			{
				mouseCounter = value;
			}
		}

		public int MouseSteps
		{
			get
			{
				return mouseSteps;
			}
			set
			{
				mouseSteps = value;
			}
		}

		public string MouseEats
		{
			get
			{
				return mouseEats;
			}
			set
			{
				mouseEats = value;
			}
		}
	}

	public class Snake : Animals
	{
		private int snakeCounter;
		private int snakeSteps;
		private string snakeEats;

		public int SnakeCounter
		{
			get
			{
				return snakeCounter;
			}
			set
			{
				snakeCounter = value;
			}
		}

		public int SnakeSteps
		{
			get
			{
				return snakeSteps;
			}
			set
			{
				snakeSteps = value;
			}
		}

		public string SnakeEats
		{
			get
			{
				return snakeEats;
			}
			set
			{
				snakeEats = value;
			}
		}
	}

	public class Hunter : Animals
	{
		private int hunterCounter;
		private int hunterSteps;
		private string hunterEats;

		public int HunterCounter
		{
			get
			{
				return hunterCounter;
			}
			set
			{
				hunterCounter = value;
			}
		}

		public int HunterSteps
		{
			get
			{
				return hunterSteps;
			}
			set
			{
				hunterSteps = value;
			}
		}

		public string HunterEats
		{
			get
			{
				return hunterEats;
			}
			set
			{
				hunterEats = value;
			}
		}
	}
}
