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
			//* int[] ints = GetValues();


			int[] ints = new int[5];

			GetValues();


			int[] GetValues()
			{
				Console.WriteLine("gimme 5 numbers");
				// Int32.Parse()
				string test = "";
				int x = 0;
				for (int i = 0; i < 5; i++)
				{
					ints[i] = Convert.ToInt32(Console.ReadLine());

				}

				PrintSum(ints);
				PrintReverse(ints);
				PrintHighest(ints);
				PrintLowest(ints);
				PrintArray(ints);
				/*
				if (Int32.TryParse(test, out int num))
				{

					x = num;
				}
				return null;
				*/
				return null;

			}

			int[] PrintArray(int[] array)
			{
				for (int i = 0; i < 5; i++)
				{
					Console.WriteLine(array[i]);
				}
				return null;
			}


			int[] PrintSum(int[] array)
			{
				int sum = 0;
				foreach (int num in array)
				{
					sum += num;


					Console.WriteLine("Sum of array is " + sum);

				}


				return null;

			}

			int[] PrintHighest(int[] array)
			{
				int x = array.Max();
				Console.WriteLine("Max value is: " + x);

				return null;
			}

			int[] PrintLowest(int[] array)
			{
				int x = array.Min();
				Console.WriteLine("Min value is: " + x);
				return null;
			}

			int[] PrintReverse(int[] array)
			{
				Array.Reverse(array);

				foreach (int a in array)
				{
					Console.WriteLine(array);
				}


				return null;
			}

		}
	}
}

