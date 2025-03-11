class Activity
{
    private int _duration;
    private string _activityName;
    private string _activityDescription;

    public Activity(string activityName, string activityDescription)
    {
        
        _activityName = activityName;
        _activityDescription = activityDescription;
    }
    
    public void WelcomeMessage()
    {
        Console.WriteLine("This will be great for mindfulness.");
        Thread.Sleep(1000);
        Console.WriteLine("You can choose for how long to participate. Just follow along and we will tell you what to do.");
        SetDuration();
        Console.WriteLine("Get Ready!");
        Thread.Sleep(1000);
        RunAnimation();
    
    }
    private void SetDuration()
    {
        Console.WriteLine("Enter the amount of time in seconds that you would like to participate: ");
        _duration = Convert.ToInt32 (Console.ReadLine());
        
    }
    protected int GetDuration(){
        return _duration; 
    }
    private void RunAnimation()
    {
        List<string> _animationStrings = new List<string>();
        _animationStrings.Add("|");
        _animationStrings.Add("/");
        _animationStrings.Add("-");
        _animationStrings.Add("\\");
        _animationStrings.Add("|");
        _animationStrings.Add("/");
        _animationStrings.Add("-");
        _animationStrings.Add("\\");

        foreach (string s in _animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }    
    }

    public void EndMessage()
    {
        Console.WriteLine("You did a great job.");
        Thread.Sleep(2000);
        Console.WriteLine($"You completed {_duration} seconds of the {_activityName} activity and are now finished.");
        Thread.Sleep(2000);
    }

}