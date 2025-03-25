using System;

class Program
{
    static void Main(string[] args)
    {
        int tempPoints = 0;
        GoalCoordinator coordinator = new GoalCoordinator(tempPoints);
        bool running = true;

        while (running)
        {
            Console.WriteLine($"\nYou have {coordinator.GetTotalPoints()} points.");
            Console.WriteLine("\nMenu Options: ");
            Console.WriteLine("\n1. Create");
            Console.WriteLine("2. List");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("\nSelect a choice: ");

            string userPick = Console.ReadLine();

            

            switch (userPick)
            {
                case "1":
                    coordinator.CreateGoal();
                    break;
                case "2":
                    
                    coordinator.ListAllGoals();
                    break;
                case "3":
                    Console.WriteLine("What is the file name?");
                    String fileName = Console.ReadLine();
                    coordinator.SaveGoals(fileName);
                    break;
                case "4":
                    Console.WriteLine("What is the file name?");
                    fileName = Console.ReadLine();
                    coordinator.LoadGoal(fileName);
                    break;
                case "5":
                    coordinator.RecordGoal();
                    break;
                case "6":
                    Console.WriteLine("Goodbye.");
                    return;
                default:
                    break;

            }
        }
    }
}