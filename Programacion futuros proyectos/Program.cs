using System;

namespace EvenOrOddProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable to store the number
            int number;

            // Ask the user to enter a number
            Console.Write("Enter a number: ");

            // Read the number from keyboard and convert it to integer
            number = int.Parse(Console.ReadLine());

            // Check if the number is even or odd
            // If the remainder of division by 2 is 0, it is even
            // If the remainder of division by 2 is 1, it is odd
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is EVEN.");
            }
            else
            {
                Console.WriteLine("The number is ODD.");
            }

            // Wait for a key before closing the program
            Console.ReadKey();
        }
    }
}