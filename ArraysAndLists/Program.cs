using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            var myIntArray = new int[1,2,3,4,5,6,7,8,9,10];

            // Create an int Array and populate numbers 1-10

            var evens = new List<int>();
            var odds = new List<int>();

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            for (int i = 0; i <= 17; i++)
            {
                //Console.WriteLine($"\nWhat number would you like to add?");
                //var addThisNum = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    //var result = addThisNum;
                    evens.Add(i);
                }

                else if (i % 2 != 0)
                {
                    //var result = addThisNum;
                    odds.Add(i);
                }

                else
                {
                    Console.WriteLine($"\nInvalid input. Please try again");
                }

            }

            Console.WriteLine($"\nEven numbers = {evens.Count}");

            Console.WriteLine($"\nOdd numbers = {odds.Count}");


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            int iOne = 0;
            Console.WriteLine("\nEvens List:");
            for (iOne = 1; iOne <= 17; iOne++)
            {
                if (iOne % 2 == 0)
                {
                    Console.Write(iOne + " ");
                }

            }

            Console.WriteLine("\nOdds List:");
            for (iOne = 1; iOne <= 17; iOne++)
            {
                if (iOne % 2 != 0)
                {
                    Console.Write(iOne + " ");
                }
            }


        }
    }
}
