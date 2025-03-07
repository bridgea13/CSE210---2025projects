using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

      
        while (running)
        {
            Console.WriteLine("\nWelcome! We are here to help you be more mindful.");
            Thread.Sleep(1000);
            Console.WriteLine("\nPick an activity from the following options below: ");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Listing");
            Console.WriteLine("3. Reflecting");
            Console.WriteLine("4. Movement");
            Console.WriteLine("5. Quit");
            Console.WriteLine("\nEnter the number of your choice.");

            string userPick = Console.ReadLine();

            

            switch (userPick)
            {
                case "1":
                    Console.WriteLine("Great! Let's do a breathing activity...");
                    Thread.Sleep(2000);
                    BreathingActivity breath = new BreathingActivity("Breath", "This is a breathing exercise.");
                    breath.WelcomeMessage();
                    breath.RunBreathing();
                    break;
                case "2":
                    Console.WriteLine("Great! Let's do a listing activity...");
                    ListingActivity list = new ListingActivity("List", "This is a listing exercise.");
                    list.WelcomeMessage();
                    list.RunListening();
                    break;
                case "3":
                    Console.WriteLine("Great! Let's do a reflecting activity...");
                    ReflectingActivity reflect = new ReflectingActivity("Reflect", "This is a reflecting exercise.");
                    reflect.WelcomeMessage();
                    reflect.RunReflecting();
                    break;
                case "4":
                    Console.WriteLine("Great! Let's do a movement activity...");
                    MovementActivity move = new MovementActivity("Move", "This is a movement exercise");                    
                    break;
                case "5":
                    Console.WriteLine("Thank you for being mindful.");
                    return;
                default:
                    break;
            }

           

            // DateTime startTime = DateTime.Now;
            // DateTime endTime = startTime.AddSeconds(10);

            // while (DateTime.Now < endTime)
            // {
            //     Console.WriteLine(s);
            //     Thread.Sleep(1000);
            // }

            Console.WriteLine("Done.");
        }
    }
}