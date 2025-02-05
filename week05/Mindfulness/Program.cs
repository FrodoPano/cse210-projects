using System;

class Program
{
    static void Main(string[] args)
    {
        while(true){
            Console.Clear();

            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("1.- Breathing Activity");
            Console.WriteLine("2.- Reflecting Activity");
            Console.WriteLine("3.- Listing Activity");
            Console.WriteLine("4.- Exit");
            Console.WriteLine("Choose an option: ");

            switch(Console.ReadLine()){
                case "1": new BreathingActivity().Run(); break;
                case "2": new ReflectingActivity().Run(); break;
                case "3": new ListingActivity().Run(); break;
                case "4": return;
                default: Console.WriteLine("Invalid option. Try again."); break;
            }
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }  
    }
}