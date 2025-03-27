using System.IO.Enumeration;

public class GoalCoordinator
{
    private List<Goals> _goals;
    private int _totalPoints;

    public GoalCoordinator(int totalPoints)
    {
        _totalPoints = totalPoints;
        _goals = new List<Goals>();
    }
    public void CreateGoal()
    {


        Console.WriteLine("\nWhat type of goal would you like to create?");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.WriteLine("\nPlease make a choice: ");
        string userPick = Console.ReadLine();

        switch (userPick)
        {
            case "1":
                string name = GoalCoordinator.GetGoalName();
                string descrip = GoalCoordinator.GetGoalDescription();
                int points = GoalCoordinator.GetGoalPoints();

                Simple simple = new Simple(name, descrip, points, false);
                _goals.Add(simple);
                break;
            case "2":
                name = GoalCoordinator.GetGoalName();
                descrip = GoalCoordinator.GetGoalDescription();
                points = GoalCoordinator.GetGoalPoints();

                Eternal eternal = new Eternal(name, descrip, points, false);
                _goals.Add(eternal);
                break;
            case "3":
                name = GoalCoordinator.GetGoalName();
                descrip = GoalCoordinator.GetGoalDescription();
                points = GoalCoordinator.GetGoalPoints();
                int times = GoalCoordinator.GetGoalTimes();
                int bonus = GoalCoordinator.GetGoalBonus();
                Checklist checklist = new Checklist(name, descrip, points, false, times, 0, bonus);
                _goals.Add(checklist);
                break;






        }
    }

    private static int GetGoalBonus()
    {
        Console.WriteLine("What is the bonus amount when all rounds are complete?");
        string input = Console.ReadLine();
        return Convert.ToInt32(input);

    }
    private static int GetGoalTimes()
    {
        Console.WriteLine("How many times do I have to do this goal?");
        string input = Console.ReadLine();
        return Convert.ToInt32(input);

    }
    private static string GetGoalName()
    {
        Console.WriteLine("What is the goal name?");
        return Console.ReadLine();
    }
    private static string GetGoalDescription()
    {
        Console.WriteLine("What is the description of the goal?");
        return Console.ReadLine();
    }
    private static int GetGoalPoints()
    {
        Console.WriteLine("How many points is this goal?");
        string input = Console.ReadLine();
        return Convert.ToInt32(input);
    }
    public void ListAllGoals()
    {

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine(GetGoalString(i));
        }



    }
    private string GetGoalString(int goalNum)
    {
        string name = _goals[goalNum].GetGoalName();
        string descrip = _goals[goalNum].GetDescrip();
        string type = _goals[goalNum].GetGoalType();
        bool complete = _goals[goalNum].GetComplete();
        

        //add header
        if (type == "Checklist")
        {
            int numComplete = _goals[goalNum].GetNumComplete();
            goalNum = goalNum + 1;
            return goalNum + "," + name + "," + descrip + "," + type + "," + complete + "," + numComplete;
        }
        else
        {
            goalNum = goalNum + 1;
            return goalNum + "," + name + "," + descrip + "," + type + "," + complete;
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                string line =GetGoalString(i);
                line += ","+  _goals[i].GetPoints();
                string type = _goals[i].GetGoalType();
                if (type == "Checklist"){
                    //i--;
                    line += ","+ _goals[i].GetTotalTimes()+","+ _goals[i].GetBonusAmount();
                }
                //, points,  totalTimes, bonus
                //goalNum + "," + name + "," + descrip + "," + type + "," + complete + "," + numComplete;

                outputFile.WriteLine(line);
            }
        }
    }

    public void LoadGoal(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string goalNum = parts[0];
            string name = parts[1];
            string descrip = parts[2];
            string type = parts[3];
            int points = int.Parse(parts[5]);
            bool complete = bool.Parse(parts[4]);
            if (type == "Checklist"){
                int numComplete = int.Parse(parts[6]);
                int totalTimes= int.Parse(parts[7]);
                int bonus = int.Parse(parts[8]);
                Checklist checklist = new Checklist(name, descrip, points, complete, numComplete, totalTimes, bonus);

                _goals.Add(checklist);
            }else if (type == "Simple"){
                Simple simple = new Simple(name, descrip, points, complete);
                _goals.Add(simple);
            }else if (type == "Eternal"){
                Eternal eternal = new Eternal(name, descrip, points, complete);
                _goals.Add(eternal);
            }


        }

    }

    public void RecordGoal()
    {
        //List all goals
        ListAllGoals();
        //get goal number
        Console.WriteLine("What number goal do you want to complete?");
        //get goal points
        string numGoal = Console.ReadLine();
        int number = Convert.ToInt32(numGoal);
        number--;
        if (_goals[number].GetGoalType() == "Simple")
        {
            _totalPoints += _goals[number].GetPoints();
            _goals[number].SetComplete();
        }
        else if (_goals[number].GetGoalType() == "Eternal")
        {
            _totalPoints += _goals[number].GetPoints();
            _goals[number].SetComplete();
        }
        else if (_goals[number].GetGoalType() == "Checklist")
        {
            _totalPoints += _goals[number].GetPoints();
            _goals[number].SetComplete();
            bool bonus = _goals[number].GetBonusEligible();
            if (bonus)
            {
                _totalPoints += _goals[number].GetBonusAmount();
            }
        }



        Console.WriteLine();
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }


}