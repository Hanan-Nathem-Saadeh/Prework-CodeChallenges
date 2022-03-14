using System;


namespace Array_Max_Result
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Challenge1();
			Challenge2();
		}
		static void Challenge1()
		{
			int[] arr1 = new int [5];
			Console.WriteLine("please insert five numbers between 1-10  ");
			for (int i = 0; i < arr1.Length; i++)
            {

			arr1[i] = int.Parse(Console.ReadLine());

            }
			Console.Write("choose a num from [" + string.Join(", ", arr1) + "] ");
			int number = int.Parse(Console.ReadLine());
			int counter = 0;
			foreach (int i in arr1)
			{
				if (i == number)
				{
					counter++;
				}
			}

			Console.WriteLine($"The number {number} has a score of { number * counter}");
		}
		static void Challenge2()
        {
			int year;
			Console.Write("Please insert a Year to check if this year is leap year or not :");
			year =int.Parse(Console.ReadLine());
			if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
				Console.WriteLine(year + " is a leap year ");
			else
				Console.WriteLine(year + " is not a leap year ");

		}




	}
}
