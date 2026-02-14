using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Declare variables of different types, assign values and print them
        int age = 20;
        double height = 1.75;
        char letter = 'A';
        bool isStudent = true;
        string name = "John";

        Console.WriteLine("Integer value: " + age);
        Console.WriteLine("Double value: " + height);
        Console.WriteLine("Character value: " + letter);
        Console.WriteLine("Boolean value: " + isStudent);
        Console.WriteLine("String value: " + name);

        // 2. Declare a constant and print its value
        const int Number_of_constand = 3;
        Console.WriteLine("Constant value number: " + Number_of_constand);

        // if later i put another variable like Number_of_constand = 7; That one will be a wrong cuz:
        // ERROR: You cannot change the value of a constant

        // 3. Declare an integer, increment, decrement and do operations
        int number = 10;

        number++; // Increment
        Console.WriteLine("Incremented value: " + number);

        number--; // Decrement
        Console.WriteLine("Decremented value: " + number);

        int result = number + 5;
        Console.WriteLine("Result of addition operation: " + result);

        int result_2 = number - 10;
        Console.WriteLine("Result of subtraction operation: " + result_2);

        // 4. Declare a float and a byte
        float myFloat = 10152466.25f;
        byte myByte = (byte)(5 + myFloat);

        Console.WriteLine("Float value: " + myFloat);
        Console.WriteLine("Byte value: " + myByte);

        // 5. One-line comment
        // This is a single-line comment

        /*
           This is a multi-line comment
           in C#
        */

        Console.WriteLine("Current Date and Time: " + DateTime.Now);

        Console.ReadKey();
    }
}