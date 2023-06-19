using UC10.Interfaces;
using UC10.Services;

namespace RegexTests
{
    public class Tests
    {
        private IValidationService _validationService;

        [SetUp]
        public void SetUp()
        {
            _validationService = new ValidationService();
        }

        [Test]
        public void TestTooShortInput()
        {
            int maxLength = 16;
            Assert.IsFalse(_validationService.IsValid("", maxLength));
        }

        [Test]
        public void TestTooLongInput()
        {
            int maxLength = 16;
            Assert.IsFalse(_validationService.IsValid("A1#aA1#aA1#aA1#aA1#aA1#aA1#aA1#a", maxLength));
        }

        [Test]
        public void TestMatchingInputLength()
        {
            int maxLength = 16;
            Assert.IsTrue(_validationService.IsValid("A1#aA1#aA1#aA1#", maxLength));
        }

        [Test]
        public void TestMissingUppercaseLetter()
        {
            int maxLength = 16;
            Assert.IsFalse(_validationService.IsValid("a1#a1#a1#a1#", maxLength));
        }

        [Test]
        public void TestMissingLowercaseLetter()
        {
            int maxLength = 16;
            Assert.IsFalse(_validationService.IsValid("A1#AA1#AA1#AA1#", maxLength));
        }

        [Test]
        public void TestMissingSpecialCharacter()
        {
            int maxLength = 16;
            Assert.IsFalse(_validationService.IsValid("A1aA1aA1aA1a", maxLength));
        }

        [Test]
        public void TestMissingDigit()
        {
            int maxLength = 16;
            Assert.IsFalse(_validationService.IsValid("A#aA#aA#aA#a", maxLength));
        }

        [Test]
        public void TestWhitespaceAtBeginningAndEnd()
        {
            int maxLength = 16;
            Assert.IsFalse(_validationService.IsValid(" A1#aA1#a ", maxLength));
        }

        [Test]
        public void TestWhitespaceInMiddle()
        {
            int maxLength = 16;
            Assert.IsFalse(_validationService.IsValid("A1# aA1#aA1#a", maxLength));
        }
    }


}