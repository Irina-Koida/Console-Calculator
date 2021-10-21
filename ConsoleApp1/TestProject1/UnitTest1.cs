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
        [TestCase(-10, 8, -6)]
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 0)]
        public void SubstractionTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Minus(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, 6, 8)]
        [TestCase(-10, 8, -60)]
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 3)]
        public void MultiplicationTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Multiply(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, 2, 5)]
        [TestCase(-10, 8, -60)]
        [TestCase(10, 0, 0)]
        [TestCase(1, 1, 3)]
        public void DivisionTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Division(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, 6, 8.9)]
        [TestCase(-10, 8, -6.6)]
        [TestCase(0, 0, 0)]
        [TestCase(1, 0, 3)]
        public void RestOfDivisionTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.RestOfDivide(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
