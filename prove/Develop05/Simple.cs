using System.Runtime.CompilerServices;

class Simple : Goals
{
    public Simple(string goalName, string goalDescrip, int goalPoints, bool complete) : base( goalName,  goalDescrip,  goalPoints,  complete)
    {

    }
    public override string SetGoalType(){
        return  "Simple";
    }
}