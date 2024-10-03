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

				// string test stores user input as a string, int32.tryparse converts into an int, stores into num
				// reassigns as ints[i] moves up the array
				string test = "";
				
				for (int i = 0; i < 5; i++)
				{
					test = Console.ReadLine();	

					if (Int32.TryParse(test, out int num))
					{
						ints[i] = num;
						//assign converted int to array ints[i]
					}
					else
					{
						Console.WriteLine("Not an integer");
						i--;
						//have to go back down to reassign correct values
					}


				}
					return ints;

               // return null;

			}

					//	ints[i] = Convert.ToInt32(Console.ReadLine());

				PrintSum(ints);
				

				PrintHighest(ints);
              

                PrintLowest(ints);
               

                PrintArray(ints);
				

                PrintReverse(ints);
                

			int[] PrintArray(int[] array)
			{
				Console.WriteLine("\nArray printed as provided");
				for (int i = 0; i < 5; i++)
				{
					Console.WriteLine(array[i]);
				}
				return null;
			}


			int[] PrintSum(int[] array)
			{
				int sum = array.Sum();
				Console.WriteLine("\nSum of the array is: "+ sum);
				

				


				return null;

			}

			int[] PrintHighest(int[] array)
			{
				int x = array.Max();
				Console.WriteLine("\nMax value is: " + x);

				return null;
			}

			int[] PrintLowest(int[] array)
			{
				
				int x = array.Min();
				Console.WriteLine("\nMin value is: " + x);
				return null;
			}



			int[] PrintReverse(int[] array)
			{
				Console.WriteLine("\nArray will now be printed in reverse");
				
				Array.Reverse(array);


				// have to convert int to a string 
				foreach (int a in array)
				{
					Console.WriteLine(Convert.ToInt32(a));
				}


				return null;
			}

		}
	}
}

