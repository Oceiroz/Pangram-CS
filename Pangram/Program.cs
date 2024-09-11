using System;

namespace Pangram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string statement = GetStringInput("input a sentence to see if it is a pangram");
            CountLetters(statement);
        }
        static string GetStringInput(string inputMessage)
        {
            string userInput = String.Empty;
            while (true)
            {
                Console.WriteLine($"{inputMessage}\n");
                string rawInput = Console.ReadLine();
                try
                {
                    userInput = rawInput;
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("This is not a valid input\n");
                }
            }
            return userInput;
        }
        static void CountLetters(string statement)
        {
            string formatStatement = statement.ToUpper();
            int letters = 0;
            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (formatStatement.Contains(c) == true)
                {
                    letters++;
                }
            }
            if (letters == 26)
            {
                Console.WriteLine("This is a Pangram");
            }
            else
            {
                Console.WriteLine("not a pangram");
            }
        }
    }
}
