using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemFourApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is Problem Four.....

            int diffTenNumber, diffHundredNumber, sumSquareTen, squareSumTen, sumSquareHundred, squareSumHundred;

            sumSquareTen = CalculateSumSquare(10);
            squareSumTen = CalculateSquareSum(10);
            sumSquareHundred = CalculateSumSquare(100);
            squareSumHundred = CalculateSquareSum(100);

            diffTenNumber = squareSumTen - sumSquareTen;

            diffHundredNumber = squareSumHundred - sumSquareHundred;

            Console.WriteLine("\nSquare of the Sum of the First Ten number : " + squareSumTen);
            Console.WriteLine("\nSum of the Square of the First Ten number : " + sumSquareTen);
            Console.WriteLine("\n\nDifference : " + diffTenNumber);

            Console.WriteLine("\n\nSquare of the Sum of the First Hundred number : " + squareSumHundred);
            Console.WriteLine("\nSum of the Square of the First Hundred number : " + sumSquareHundred);
            Console.WriteLine("\n\nDifference : " + diffHundredNumber);

            Console.ReadKey();
        }

        static int CalculateSumSquare(int limit)
        {
            int sumSquare = 0, i;

            for (i = 1; i <= limit; i++)
            {
                sumSquare = sumSquare + i * i;
            }

            return sumSquare;
        }

        static int CalculateSquareSum(int limit)
        {
            int squareSum = 0, i;

            for (i = 1; i <= limit; i++)
            {
                squareSum = squareSum + i;
            }

            squareSum = squareSum * squareSum;

            return squareSum;
        }
    }
}
