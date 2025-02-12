

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Goal Tracker Started");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {_score}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. [{( _goals[i].IsComplete() ? "X" : " " )}] {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int index)
    {
        int adjustedIndex = index - 1;  // Convert user input (1-based) to list index (0-based)
    
        if (adjustedIndex >= 0 && adjustedIndex < _goals.Count)
        {
            _goals[adjustedIndex].RecordEvent();
            _score += _goals[adjustedIndex].GetPoints();
        }
        else
        {
            Console.WriteLine("Invalid goal number. Please try again.");
        }
    }   

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _goals.Clear();
            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                string type = parts[0];
                string[] details = parts[1].Split(',');

                if (type == "SimpleGoal")
                {
                    _goals.Add(new SimpleGoal(details[0], details[1], int.Parse(details[2])));
                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(details[0], details[1], int.Parse(details[2])));
                }
                else if (type == "ChecklistGoal")
                {
                    _goals.Add(new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), int.Parse(details[4])));
                }
            }
        }
    }
}
