using System.Diagnostics;

class BreathingActivity : Activity 
{
    public BreathingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {
       
    }
    
    public void RunBreathing()
    {
        int duration = GetDuration();
        

        if (duration > 0)
        {
            int passingTime = 0;
                

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