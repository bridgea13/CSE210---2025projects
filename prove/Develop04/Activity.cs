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
        Console.WriteLine("This will be great for relaxation. You can choose for how long to participate in this " + _activityName +  " . Just follow along and we will tell you what to do.");
        Console.WriteLine(_activityName);
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
        Console.WriteLine(_duration);
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

}