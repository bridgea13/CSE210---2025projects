public class Goals
{
    private string _goalName;
    private string _goalDescrip;
    private int _goalPoints;
    private bool _complete;

    private string _goalType;

    public Goals(string goalName, string goalDescrip, int goalPoints, bool complete)
    {
        _goalName = goalName;
        _goalDescrip = goalDescrip;
        _goalPoints = goalPoints;
        _complete = complete;
        _goalType =  SetGoalType();

    }
    public string GetGoalName(){
        return _goalName;
    }
    public string GetDescrip(){
        return _goalDescrip;
    }
    

    public int GetPoints()
    {
        return _goalPoints;
    }

    public virtual void SetComplete()
    {
        _complete = true;
    }
    public virtual bool GetBonusEligible()
    {
        return false;

    }
    public virtual int GetNumComplete(){
        return 0;
    }
    public virtual int GetBonusAmount()
    {
        return 0;

    }
    public virtual string SetGoalType(){
        return  "Goal";
    }
    public string GetGoalType(){
        return _goalType;
    }

    public bool GetComplete()
    {
        return _complete;
    }


}