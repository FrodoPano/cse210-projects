public class ListingActivity : Activity{

    private int _count;
    private List<string> _prompts = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many as you can."){

    }

    public void Run(){
        DisplayStartingMessage();
        GetRandomPrompt();
        ShowSpinner(3);
        List<string> items = GetListFromUser();
        _count = items.Count;
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt(){
        Console.WriteLine(_prompts[new Random().Next(_prompts.Count)]);
    }

    public List<string> GetListFromUser(){
        List<string> items = new();
        Console.WriteLine("Start listing items now:");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                items.Add(input);
        }
        return items;
    }


}
