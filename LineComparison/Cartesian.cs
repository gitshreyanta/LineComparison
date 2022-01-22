using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class Equaltwopoints
    {

        // Function to check if they are identical
        public static void idstrt(double a1, double b1,
                          double c1, double a2,
                          double b2, double c2)
        {
            if ((a1 / a2 == b1 / b2)
                && (a1 / a2 == c1 / c2)
                && (b1 / b2 == c1 / c2))
                Console.WriteLine("The given straight"
                + " lines are identical");

            else
                Console.WriteLine("The given straight"
                    + " lines are not identical");
        }


        public static void LineEqual()
        {
            //Line formula y= ax + bx + c
            //Reading the co-efficent of two lines
            Console.WriteLine("Please enter co-effcient a1");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter co-effcient b1 ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter co-effcient c1");
            double c1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter co-effcient a2");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter co-effcient b2 ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter co-effcient c2");
            double c2 = Convert.ToDouble(Console.ReadLine());

            // Call Method to Check constant ratio
            idstrt(a1, b1, c1, a2, b2, c2);
        }
    }
}