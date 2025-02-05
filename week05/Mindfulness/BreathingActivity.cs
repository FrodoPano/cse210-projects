
public class BreathingActivity : Activity{

    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing."){

    }

    public void Run(){
        DisplayStartingMessage();
        for (int i = 0; i < _duration / 6; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.Write("\b \b");
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
            Console.Write("\b \b");
        }
        DisplayEndingMessage();
    }
}