using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is the magic number? ");
        //string guess = Console.ReadLine();
        //int number = int.Parse(guess);
        string answer = "";

        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            int number2 = 0;
            int count = 0;

            while(number2 != number)
            {
                Console.WriteLine("What is your guess? ");
                number2 = int.Parse(Console.ReadLine());


                if (number2 > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (number2 < number)
                {
                    Console.WriteLine("Higher");
                }
                else 
                {
                    Console.WriteLine("You guessed it!");
                }

                count++;

            
            }

            Console.WriteLine($"You tried {count} times");
            Console.WriteLine("Try again? ");
            answer = Console.ReadLine();
        }while(answer == "yes");
        

        
    }
}