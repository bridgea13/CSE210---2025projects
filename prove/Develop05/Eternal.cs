public class Eternal: Goals
{
    public Eternal(string goalName, string goalDescrip, int goalPoints, bool complete) : base( goalName,  goalDescrip,  goalPoints,  complete)
    {

    }

    public override void  SetComplete()
    {
        Console.WriteLine("Eternal Goals are never complete!!! But we can always keep trying.");
         
    }
     public override string SetGoalType(){
        return  "Eternal";
    }
}