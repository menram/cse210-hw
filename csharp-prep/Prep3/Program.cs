using System;

class Program
{
    static void Main(string[] args)
    {
        //======================================
        // Core requirement #1
        Console.Write("What is the magic number? ");
        string stringNumber = Console.ReadLine();
        int number = int.Parse(stringNumber);
        Console.Write("What is your guess? ");
        string stringGuess = Console.ReadLine();
        int guess = int.Parse(stringGuess);
        if (guess == number)
        {
            Console.WriteLine($"You guessed it!");
        }
        else if (guess < number)
        {
            Console.WriteLine($"Higher");
        }
        else
        {
            Console.WriteLine($"Lower");
        }
        Console.WriteLine("");

        // Core requirement #2
        Console.Write("What is the magic number? ");
        stringNumber = Console.ReadLine();
        number = int.Parse(stringNumber);
        Console.Write("What is your guess? ");
        stringGuess = Console.ReadLine();
        guess = int.Parse(stringGuess);
        while (guess != number)
        {
            if (guess < number)
            {
                Console.WriteLine($"Higher");
            }
            else
            {
                Console.WriteLine($"Lower");
            }
            Console.Write("What is your guess? ");
            stringGuess = Console.ReadLine();
            guess = int.Parse(stringGuess);
        }
        Console.WriteLine($"You guessed it!");
        Console.WriteLine("");

        // Core requirement #3
        Random randomGenerator = new Random();
        number = randomGenerator.Next(1, 101);
        Console.Write("What is your guess? ");
        stringGuess = Console.ReadLine();
        guess = int.Parse(stringGuess);
        while (guess != number)
        {
            if (guess < number)
            {
                Console.WriteLine($"Higher");
            }
            else
            {
                Console.WriteLine($"Lower");
            }
            Console.Write("What is your guess? ");
            stringGuess = Console.ReadLine();
            guess = int.Parse(stringGuess);
        }
        Console.WriteLine($"You guessed it!");
        Console.WriteLine("");

        // Stretch
        string play = "yes";
        while (play == "yes")
        {
            number = randomGenerator.Next(1, 101);
            Console.Write("What is your guess? ");
            stringGuess = Console.ReadLine();
            guess = int.Parse(stringGuess);
            int guesses = 1;
            while (guess != number)
            {
                if (guess < number)
                {
                    Console.WriteLine($"Higher");
                }
                else
                {
                    Console.WriteLine($"Lower");
                }
                Console.Write("What is your guess? ");
                stringGuess = Console.ReadLine();
                guess = int.Parse(stringGuess);
                guesses += 1;
            }
            Console.WriteLine($"You guessed it!");
            Console.WriteLine($"It took you {guesses} guesses.");
            Console.WriteLine("");

            Console.Write("Do you want to play again? ");
            play = Console.ReadLine().ToLower();

        }
        //======================================
    }
}