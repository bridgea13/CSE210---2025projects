class ListingActivity : Activity
{
    

    public ListingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {
       
    }
    public void RunListening()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are your personal strengths?");
        prompts.Add("Who are people you have helped this week?");
        prompts.Add("How have you felt the Holy Ghost this month?");
        prompts.Add("Who are your heroes?");
        
        int duration = GetDuration();
        if (duration > 0)
        {
            int passingTime = 0;
            Console.WriteLine("Grab something to write with. First, you will be presented with a question.");
            Thread.Sleep(5000);
            Console.WriteLine("When prompted, start writing down as many answers to that question as you can.");
            Thread.Sleep(5000);
            Random random = new Random();
            int index = random.Next(prompts.Count);
            Console.WriteLine(prompts[index]);

            while (passingTime < duration)
            {
                if (passingTime + 5 <= duration)
                {
                    Console.WriteLine("Think about it...");
                    Thread.Sleep(5000);
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
                    Console.WriteLine("Now write!");
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