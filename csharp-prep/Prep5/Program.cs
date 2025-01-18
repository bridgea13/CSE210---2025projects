using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string fullName = PromptFullName();
        int favNumber = PromptFavNumber();

        int squaredNumber = SquareNumber(favNumber);

        DisplayResult(fullName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptFullName()
    {
        Console.WriteLine("Please enter your full name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptFavNumber()
    {
        Console.WriteLine("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {square}.");
    }
}