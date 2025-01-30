using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment first = new Assignment("Brock Samson","Multiplication");
        Console.WriteLine(first.GetSummary());

        MathAssignment second = new MathAssignment("Dean Venture", "Pi", "8", "12-14");
        Console.WriteLine(second.GetSummary());
        Console.WriteLine(second.GetHomeworkList());

        WritingAssignment third = new WritingAssignment("Gary Henchman", "Fantasy", "Character Development");
        Console.WriteLine(third.GetSummary());
        Console.WriteLine(third.GetWritingInformation());
    }
}