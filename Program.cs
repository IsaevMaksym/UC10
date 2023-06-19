using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your string:");
        string userInput = Console.ReadLine();

        Console.WriteLine("Please enter the maximum allowed string length:");
        var isNumberValid = Int32.TryParse(Console.ReadLine(), out int maxLength);

        if (isNumberValid && IsValid(userInput, maxLength))
        {
            Console.WriteLine("Your string is valid.");
        }
        else
        {
            Console.WriteLine("Your inputs are invalid.");
        }

        Console.ReadLine();
    }

    public static bool IsValid(string input, int maxLength)
    {
        // Define the regular expression that validates the string requirements.
        string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!""#$%&'()*+,-./:;<=>?@[\]^_`{|}~])[A-Za-z\d!""#$%&'()*+,-./:;<=>?@[\]^_`{|}~]{1," + maxLength + "}$";

        Regex regex = new Regex(pattern);
        return regex.IsMatch(input);
    }
}
