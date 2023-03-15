namespace Classwork_UnitTest.Tests
{
    internal class CalculatorTests
    {
        int numberOne;
        int numberTwo;

        [SetUp]
        public void Setup()
        {
            numberOne = 33;
            numberTwo = 7;
        }

        [Test]
        public void Test_Calculator_Addinion()
        {
            // Arrange
            int expectedResult = 40;

            // Act
            int actualResult = Calculator.Addition(numberOne, numberTwo);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Test_Calculator_Subtraction()
        {
            // Arrange
            int expectedResult = 26;

            // Act
            int actualResult = Calculator.Subtraction(numberOne, numberTwo);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Test_Calculator_Multiplication()
        {
            // Arrange
            int expectedResult = 231;

            // Act
            int actualResult = Calculator.Multiplication(numberOne, numberTwo);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Test_Calculator_Division()
        {
            // Arrange
            int expectedResult = 4;

            // Act
            int actualResult = Calculator.Division(numberOne, numberTwo);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Test_Calculator_DivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(()=>Calculator.Division(2,0));
        }
    }
}