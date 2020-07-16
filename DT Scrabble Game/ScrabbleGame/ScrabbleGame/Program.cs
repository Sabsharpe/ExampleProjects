using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ScrabbleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    // Get input from keyboard/user
                    string inputString = Console.ReadLine();

                    // Split into individual strings in array
                    string[] words = inputString.Split(' ');

                    // Check only two parameters entered
                    if (words.Length != 2)
                        throw new Exception(inputString + " must contain two and only two parameters");

                    // Check each paramter is a string
                    if (!isValid(inputString))
                        throw new Exception(inputString + " params must contain only A-Z a-z");

                    Console.WriteLine(inputString);
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR : " + e.Message    );
                }
            }
        }

        private static bool isValid(String str)
        {
            return Regex.IsMatch(str, @"^[a-zA-Z ]+$");
        }
    }
}
