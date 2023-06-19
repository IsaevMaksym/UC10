using System;
using System.Text.RegularExpressions;
using UC10.Interfaces;
using UC10.Services;

class Program
{
    public static void Main(string[] args)
    {

        IValidationService? _validationService = new ValidationService();

        Console.WriteLine("Please enter your string:");
        string userInput = Console.ReadLine();

        Console.WriteLine("Please enter the maximum allowed string length:");
        var isNumberValid = Int32.TryParse(Console.ReadLine(), out int maxLength);

        if (isNumberValid && _validationService.IsValid(userInput, maxLength))
        {
            Console.WriteLine("Your string is valid.");
        }
        else
        {
            Console.WriteLine("Your inputs are invalid.");
        }

        Console.ReadLine();
    }
}
