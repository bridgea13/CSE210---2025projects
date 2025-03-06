class MovementPick
{
    public void Pick4()
    {
        Console.WriteLine("This activity is great for your body. You can choose for how long to participate in some stretching exercises. Just follow along and we will tell you what to do.");
        Thread.Sleep(3000);
        Console.WriteLine("Enter the amount of time in seconds that you would like to participate: ");

        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            int passingTime = 0;
            Console.WriteLine("Let's begin.");
            Thread.Sleep(1000);
            Console.WriteLine($"Stand with feet shoulder width apart, arms relaxed by your sides.");
            Thread.Sleep(3000);
            Console.WriteLine($"Now lean all the way over to your left, keeping your left arm relaxed by your side, and your right arm reaching up to the sky.");        
            Thread.Sleep(5000);

            while (passingTime < duration)
            {
                if (passingTime + 10 <= duration)
                {
                    Console.WriteLine("Hold that pose for and take in some deep breaths.");
                    for (int i = 10; i > 0; i--)
                    {
                        Console.WriteLine(i);
                        Thread.Sleep(3000);
                    }
                    passingTime += 10;
                } else {
                    break;
                }

                if (passingTime + 10 <= duration)
                {
                    Console.WriteLine("Now switch sides and take in more deep breaths.");
                    for (int i = 10; i > 0; i--)
                    {
                        Console.WriteLine(i);
                        Thread.Sleep(3000);
                    }
                    passingTime += 10;
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