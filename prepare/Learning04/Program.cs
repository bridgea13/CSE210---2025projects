using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Patrick Henry", "History");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Patrick Henry", "Subtraction", "12", "8-10");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Patrick Henry", "History", "A Biography of George Washington");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());

    }
}