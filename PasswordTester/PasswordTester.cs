using System;


namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!@#$%^&*-+";
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            int score = 0;
            if (password.Length >= minLength)
            {
                score++;
            }
            if (Tools.Contains(password, upperCase))
            {
                score++;
            }
            if (Tools.Contains(password, lowerCase))
            {
                score++;
            }
            if (Tools.Contains(password, digits))
            {
                score++;
            }
            if (Tools.Contains(password, specialChars))
            {
                score++;
            }

            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("Wow! Your password is STRONG!");
                    break;
                case 3:
                    Console.WriteLine("Nice! Your password is pretty good!");
                    break;
                case 2:
                    Console.WriteLine("Eh....Your password is okay I guess.");
                    break;
                case 1:
                    Console.WriteLine("Ouch! Your password is pretty terrible!");
                    break;
                default:
                    Console.WriteLine("I'm sorry, your password does not meet any of our requirements.");
                    break;

            }

        }
    }
}

