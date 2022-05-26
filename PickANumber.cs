using System;


namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 7;
            Console.Write("Guess a number between 1 and 10: ");
            string guess = Console.ReadLine();
            int guessInt = Int32.Parse(guess);
            if (guessInt > number)
            {
                Console.WriteLine("You guessed too high");
            }
            else if (guessInt < number)
            {
                Console.WriteLine("You guessed too low");
            }
            else
            {
                Console.WriteLine("You guessed it!!!");
            }

        }
    }
}

