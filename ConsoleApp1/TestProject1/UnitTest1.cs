using NUnit.Framework;
using ConsoleApp1;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(10, 2, 12)]
        [TestCase(-14, 8, -6)]
        [TestCase(0, 3, 3)]
        [TestCase(1, 1, 2)]
        public void AdditionTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Plus(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, 2, 8)]
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 0)]
        public void SubstractionTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Minus(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(-10, 5, -50)]
        [TestCase(0, 0, 0)]
        public void MultiplicationTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Multiply(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, 2, 5)]
        [TestCase(8, 2, 4)]
        [TestCase(10, 0, 0)]
        public void DivisionTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Division(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, 6, 4.0)]
        public void RestOfDivisionTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.RestOfDivide(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(5, 120)]
        public void FactorialTest(double firstArgument, double expectedResult)
        {
            double actualResult = Calc.Factorial(firstArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(2, 1, 2)]
        public void PowerTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Power(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
