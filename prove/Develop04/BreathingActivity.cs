class BreathingPick
{
    public void Pick1()
    {
        Console.WriteLine("This activity is great for relaxation. You can choose for how long to participate in some breathing exercises. Just follow along and we will tell you what to do.");
        Thread.Sleep(3000);
        Console.WriteLine("Enter the amount of time in seconds that you would like to participate: ");

        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            int passingTime = 0;
            Console.WriteLine("Let's begin.");
            Thread.Sleep(1000);
            Console.WriteLine($"Starting countdown...");

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