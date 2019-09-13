using System;
using System.Collections.Generic;

namespace RandomSquaresExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            // Create a list
            List<int> randomNumberList = new List<int>();
            List<int> randomNumberSquaredList = new List<int>();

            // Populate the list
            int counter = 20;

            for (var i = 0; i < counter; i++)
            {
                randomNumberList.Add(random.Next(1,50));
            }

            Console.WriteLine("20 random numbers ranges 1 - 50");

            foreach (var num in randomNumberList)
            {
                Console.Write($"{num}, ");
                var squareNum = Math.Pow(num, 2);
                randomNumberSquaredList.Add(Convert.ToInt32(squareNum));
            }

            Console.WriteLine("Then each number's square root");

            foreach (var squareNum in randomNumberSquaredList)
            {
                Console.Write($"{squareNum}, ");
            }

            randomNumberSquaredList.RemoveAll(i => i % 2 != 0);

            Console.WriteLine("Now the squared numbers, but without any odd numbers");

            foreach (var squareNum in randomNumberSquaredList)
            {
                Console.Write($"{squareNum}, ");
            }
        }
    }
}
