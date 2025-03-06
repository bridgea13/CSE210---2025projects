using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        BreathingPick breathingPick = new BreathingPick();
        ListingPick listingPick = new ListingPick();
        //ReflectingPick reflectingPick = new ReflectingPick();
        MovementPick movementPick = new MovementPick();

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
                    breathingPick.Pick1();
                    break;
                case "2":
                    Console.WriteLine("Great! Let's do a listing activity...");
                    listingPick.Pick2();
                    break;
                case "3":
                    Console.WriteLine("Great! Let's do a reflecting activity...");
                    //reflectingPick.Pick3();
                    break;
                case "4":
                    Console.WriteLine("Great! Let's do a movement activity...");
                    movementPick.Pick4();
                    break;
                case "5":
                    Console.WriteLine("Thank you for being mindful.");
                    return;
                default:
                    break;
            }

            List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");

            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
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