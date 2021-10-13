using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Fisher_Yates_Shuffle
{
	class Shuffler
	{
		Random rand = new Random();

		public Shuffler()
		{
			SetNumbers();
		}

		//Sets the contents of the list as numbers 1-6
		public void SetNumbers()
		{
			List<int> Numbers = new List<int>();

			for (int i = 1; i < 7; i++)
			{
				Numbers.Add(i);
			}

			WriteBefore(Numbers);
		}

		//Writes the contents of the list to the console pre-shuffle
		public void WriteBefore(List<int> Numbers)
		{
			Write("Before Shuffle: ");
			foreach (int i in Numbers)
			{
				Write(i + ", ");
			}
			Write("\n");

			Shuffle(Numbers);
		}

		//Starts the shuffle
		public void Shuffle(List<int> Numbers)
		{
			for (int i = Numbers.Count - 1; i > 0; i--)
			{
				Swap(Numbers, i, GetRandomNumber(i));
			}

			WriteAfter(Numbers);
		}

		//For swapping numbers
		public void Swap(List<int> Numbers, int i, int j)
		{
			int temp = Numbers[i];
			Numbers[i] = Numbers[j];
			Numbers[j] = temp;
		}

		//Gets a random number
		public int GetRandomNumber(int i)
		{
			return rand.Next(i + 1);
		}

		//Writes contents of the list to the console post-shuffle
		public void WriteAfter(List<int> Numbers)
		{
			Write("After Shuffle: ");
			foreach (int i in Numbers)
			{
				Write(i + ", ");
			}
			Write("\n");
		}
	}
}
