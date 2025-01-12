using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();

        int x = int.Parse(gradePercentage);
        string letter ="";
        

        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "D";;
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine("Your grade is a "+letter);

        if (x >= 70)
        {
            Console.WriteLine("You Passed!!!");
        }
        else{
            Console.WriteLine("You failed.");
        }
    }
}