class ListingPick
{
    public void Pick2()
    {
        Console.WriteLine("This activity is great for gratitude. You can choose for how long to participate in some thoughtful exercises. Just follow along and we will tell you what to do.");
        Thread.Sleep(3000);
        Console.WriteLine("Enter the amount of time in seconds that you would like to participate: ");

        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            int passingTime = 0;
            Console.WriteLine("Grab something to write with. First, you will be presented with a question.");
            Thread.Sleep(1000);
            Console.WriteLine("You will have 10 seconds to think of some answers, then when prompted, start writing down as many answers to that question as you can.");
            Thread.Sleep(1000);
            Console.WriteLine($"Let's begin.");

            while (passingTime < duration)
            {
                if (passingTime + 5 <= duration)
                {
                    Console.WriteLine("Big breath in...");
                    for (int i =5; i > 0; i--)
                    {
                        Console.WriteLine(i);
                        Thread.Sleep(1000);
                    }
                    passingTime += 5;
                } else {
                    break;
                }

                if (passingTime + 5 <= duration)
                {
                    Console.WriteLine("Now breath out...");
                    for (int i =5; i > 0; i--)
                    {
                        Console.WriteLine(i);
                        Thread.Sleep(1000);
                    }
                    passingTime += 5;
                } else {
                    break;
                }
            
            }

            
            Thread.Sleep(2000);
        } else {
            Console.WriteLine("The amount of time in seconds is not valid, please try again.");
        }
    }
}