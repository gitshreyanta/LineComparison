using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
	public class Cartesian
	{
		// Function to calculate length
		double distance(int x1, int y1, int x2, int y2)
		{
			// Calculating length
			return Math.Sqrt(Math.Pow(x2 - x1, 2) +
						Math.Pow(y2 - y1, 2) * 1.0);
		}

		// take the cooranites of line
		public void Lengthoftwopoints()
		{
			Console.WriteLine("Please enter x1");
			int x1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter y1");
			int y1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter x2");
			int x2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter y2");
			int y2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(Math.Round(distance(x1, y1, x2, y2)
									* 100000.0) / 100000.0);
		}
	}
}


