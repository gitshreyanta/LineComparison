using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
	public class Compare
	{
		// Function to calculate length
		double distance(int x1, int y1, int x2, int y2)
		{
			// Calculating Length
			return Math.Sqrt(Math.Pow(x2 - x1, 2) +
						Math.Pow(y2 - y1, 2) * 1.0);
		}


		public void CompareLines()
		{
			// line1 co-orinates
			Console.WriteLine("Please enter line1 ln1x1");
			int ln1x1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter line1 ln1y1");
			int ln1y1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter line1 ln1x2");
			int ln1x2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter line1 ln1y2");
			int ln1y2 = Convert.ToInt32(Console.ReadLine());

			//Length of line 1
			double length1 = (Math.Round(distance(ln1x1, ln1y1, ln1x2, ln1y2)
									* 100000.0) / 100000.0);
			Console.WriteLine("Length of line1: " + length1);

			//Line2 Co-orinates 
			Console.WriteLine("Please enter line2 ln2x1");
			int ln2x1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter line2 ln2y1");
			int ln2y1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter line2 ln2x2");
			int ln2x2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter line2 ln2y2");
			int ln2y2 = Convert.ToInt32(Console.ReadLine());

			//length of line 2
			double length2 = (Math.Round(distance(ln2x1, ln2y1, ln2x2, ln2y2)
									* 100000.0) / 100000.0);
			Console.WriteLine("Length of line2: " + length2);

			//Comparision of Length
			if (length1 > length2)
			{
				Console.WriteLine("line1 is greater");
			}
			else if (length1 < length2)
			{
				Console.WriteLine("line2 is greater");
			}
			else
			{
				Console.WriteLine("lines are equal");
			}
		}
	}
}