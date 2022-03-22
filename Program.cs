using System;

namespace SelectionStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------------------Exercise 1
            // Create a program that allows a user to play a game where they must guess what your favorite number is.
            // 1. Initialize an integer to represent a favorite number and assign a value with a number of
            //      your choosing or you can assign a random number to this variable:
                    //var r = new Random();
                    //var favNumber = r.Next(1, 1000);
                    //var userInput = int.Parse(Console.ReadLine());

            Console.WriteLine("You get one chance to guess my favorite number.  Pick a number between 1 and 10:");
            var r = new Random();
            var favNumber = r.Next(1, 10);
            //var favNumber = 3;
            var userInput = int.Parse(Console.ReadLine());

            // 2. Create an if-statement that if the guessed number is below the initial value, print out “too low”.
            if (userInput < favNumber)
            {
                Console.WriteLine("too low");
            }
            // 3. Create an else-if statement that if the number is higher than the initial value, print out “too high”.
            else if (userInput > favNumber)
            {
                Console.WriteLine("too high");
            }
            // 4. Create an else statement that prints out “Nevermind”.
            else
            {
                Console.WriteLine("Nevermind, you got it.");
            }
        }
    }
}
