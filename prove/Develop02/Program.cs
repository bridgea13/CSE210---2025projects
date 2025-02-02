using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        Journal journal = new Journal();

        while (choice !=5)
        {
            Console.WriteLine("\nWelcome to your journal.");
            Console.WriteLine("Please pick an action.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice (1-5): ");

            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1: 
                    Console.WriteLine("You chose to write an entry.");
                    journal.add_entry();
                    break;
                case 2: 
                    Console.WriteLine("You chose to display all entries.");
                    journal.display_entry();
                    break;
                case 3: 
                    Console.WriteLine("You chose to save all entries.");
                    journal.save_entry();
                    break;
                case 4: 
                    Console.WriteLine("You chose to load all entries from a file.");
                    journal.load_entry();
                    break;
                case 5: 
                    Console.WriteLine("You chose to exit the program.");
                    break;
                default: 
                    Console.WriteLine("Invalid choice, try again.");
                    break;

            }
        }
    }
}