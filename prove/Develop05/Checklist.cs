public class Checklist : Goals
{
    private int _totalTimes;
    private int _numberCompleted;
    private int _bonusAmount;
    private bool _bonusEligible;

    public Checklist(string goalName, string goalDescrip, int goalPoints, bool complete, int totalTimes, int numberComplete, int bonusAmount) : base(goalName, goalDescrip, goalPoints, complete)
    {
        _totalTimes = totalTimes;
        _numberCompleted = 0;
        _bonusAmount = bonusAmount;
        _bonusEligible = false;
    }
    public override string SetGoalType()
    {
        return "Checklist";
    }
    public override void SetComplete()
    {
        _numberCompleted += 1;
        if (_numberCompleted >= _totalTimes)
        {
            _bonusEligible = true;
            _complete = true;
        }
    }
    public override bool GetBonusEligible()
    {
        return _bonusEligible;
    }
    public override int GetBonusAmount()
    {
        return _bonusAmount;
    }
    public override int GetNumComplete()
    {
        return _numberCompleted;
    }
    public override int GetTotalTimes()
    {
        return _totalTimes;
    }

}
