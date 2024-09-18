using System;
using System.Runtime.CompilerServices;


/*
 * write a fun that lets the user enter 5 values into an array
 * write a function that prints the sum of the elements in an integer array
 * write a fun that prints the highest int in an array
 * write a fun that prints the lowest int an an array
 */

namespace ArrayExcercises
{


	internal class Game
	{

		public void Run()
		{
			int[] ints = GetValues();
			PrintArray(ints);
			PrintReverse(ints);
			PrintSum(ints);
			PrintHighest(ints);
			PrintLowest(ints);
		}

		int GetArray()

		{
			return 0;
		}



		int[] GetValues()
		{
			// Int32.Parse()
			string test = "5";
			int x = 0;
			if (Int32.TryParse(test, out int num))
			{
				x = num;
			}
			return null;
		}

		int[] PrintArray(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
				{
				Console.WriteLine(array[i]);
			}
			return null;
		}

		
		int[] PrintSum(int[] array)
		{
			
		
			
			return null;

		}

		int[] PrintHighest(int[] array)
		{
			return null;
		}

		int[] PrintLowest(int[] array)
		{
			
			return null;
		}

		int[] PrintReverse(int[] array)
		{
			Console.WriteLine();
			return null;
		}

	}
}

