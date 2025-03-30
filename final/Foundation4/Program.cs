using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Creating Events:\nRunning\nCycling\nSwmming\n#########################################");
        List<Activity> activitiesList = new List<Activity>();
        activitiesList.Add(new Running("30 March 2025", 25, 2));
        activitiesList.Add(new Cycling("25 March 2025", 15, 12));
        activitiesList.Add(new Swimming("28 March 2025", 60, 50));
        Console.WriteLine("Summary of Activities: \n");
        foreach (Activity activity in activitiesList)
        {
            activity.OutputSummary();
        }
    }
}