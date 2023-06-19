namespace UC10.Interfaces
{
    public interface IValidationService
    {
        bool IsValid(string input, int maxLength);
    }
}
