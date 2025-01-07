using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int num = 0;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do{
            Console.WriteLine("Number: ");
            num = int.Parse(Console.ReadLine());

            if(num != 0)
            {
                numbers.Add(num);
            }

        }while(num != 0);

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"the sum of the list is: {sum}");

        float average = 0.0f;
        float sum1 = sum;
        average = sum1 / numbers.Count;

        Console.WriteLine($"The average in the list is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The highest number is: {max}");

        
    }
}