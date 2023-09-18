using ConsoleCalculator;

namespace ConsoleCalculatorTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void AddNumbers_InputTwoInts_GetCorrectAddition()
        {
            // Arrange
            Calculator calculator = new();

            // Act
            int result = calculator.AddNumbers(10, 20);

            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void AddNumbersDouble_InputTwoDoubles_GetCorrectAddition()
        {
            // Arrange
            Calculator calculator = new();

            // Act
            double result = calculator.AddNumbersDouble(17.6, 13.7);

            // Assert
            Assert.That(result, Is.EqualTo(31.3));
        }

        [Test]
        public void IsOddChecker_InputEvenNumber_ReturnFalse()
        {
            // Arrange
            Calculator calculator = new();

            // Act
            bool isOdd = calculator.IsOddNumber(10);

            // Assert
            Assert.That(isOdd, Is.EqualTo(false));
            Assert.IsFalse(isOdd);
        }

        [Test]
        [TestCase(11)]
        [TestCase(13)]
        public void IsOddChecker_InputOddNumber_ReturnTrue(int a)
        {
            // Arrange
            Calculator calculator = new();

            // Act
            bool isOdd = calculator.IsOddNumber(a);

            // Assert
            Assert.That(isOdd, Is.EqualTo(true));
            Assert.IsTrue(isOdd);
        }

        [Test]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(11, ExpectedResult = true)]
        public bool IsOddChecker_InputNumber_ReturnTrueIfOdd(int a) 
        {
            // Arrange
            Calculator calculator = new();

            // Act
            return calculator.IsOddNumber(a);
        }
    }
}