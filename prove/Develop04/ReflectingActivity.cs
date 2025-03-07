class ReflectingActivity : Activity 
{
    public ReflectingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {
       
    }

    public void RunReflecting()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Think of a time you stood up for someone else?");
        prompts.Add("When was there a time you had to do something very difficult?");
        prompts.Add("Think of a time you helped someone in need?");
        prompts.Add("Think of a time when you were being selfless?");

        List<string> questions = new List<string>(); //random2
        questions.Add("Why was the experience meaningful to you?");
        questions.Add("Have you done anything like this before?");
        questions.Add("How did you feel when it was done?");
        questions.Add("How did you get started?");
        questions.Add("What was your favorite thing about this?");
        questions.Add("What did you learn about yourself?");
                
        int duration = GetDuration();  

        if (duration > 0)
        {
            int passingTime = 0;
            
            Console.WriteLine("Starting countdown...");
            Random random = new Random();
            int index = random.Next(prompts.Count);
            Console.WriteLine(prompts[index]);

            while (passingTime < duration)
            {
                if (passingTime + 5 <= duration)
                {
                    Random random2 = new Random();
                    int index2 = random2.Next(questions.Count);
                    Console.WriteLine(questions[index2]);
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