using System.Text.RegularExpressions;
using UC10.Interfaces;

namespace UC10.Services
{
    public class ValidationService : IValidationService
    {
        public bool IsValid(string input, int maxLength)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!""#$%&'()*+,-./:;<=>?@[\]^_`{|}~])[A-Za-z\d!""#$%&'()*+,-./:;<=>?@[\]^_`{|}~]{1," + maxLength + "}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input);
        }
    }
}
