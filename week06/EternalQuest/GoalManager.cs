

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _level;
    private int _score;

    public GoalManager()
    {
        _score = 0;
        _level = 1;
    }

    public void Start()
    {
        Console.WriteLine("Goal Tracker Started");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {_score} | Level: {_level}");
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
        Console.WriteLine($"Total Score: {_score} | Level: {_level}");
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int index)
    {
        if (index >= 1 && index <= _goals.Count)
        {
            _goals[index - 1].RecordEvent();
            _score += _goals[index - 1].GetPoints();
            CheckLevelUp();
        }
    }

    private void CheckLevelUp()
    {
        while (_score >= _level * 10000)
        {
            _level++;
            Console.WriteLine($"Congratulations! You leveled up to Level {_level}!");
        }
    }   

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            writer.WriteLine(_level);
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
            _score = int.Parse(lines[0]);
            _level = int.Parse(lines[1]);
            
            for (int i = 2; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
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
