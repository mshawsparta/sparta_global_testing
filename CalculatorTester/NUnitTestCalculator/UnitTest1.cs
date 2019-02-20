using NUnit.Framework;
using CalculatorTester;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAdd()
        {
            double num1 = 6.0;
            double num2 = 2.0;
            Calculator calc = new Calculator();

            double result = calc.Add(num1, num2);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void TestSubtract()
        {
            double num1 = 6.0;
            double num2 = 2.0;
            Calculator calc = new Calculator();

            double result = calc.Subtract(num1, num2);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void TestMultiply()
        {
            double num1 = 6.0;
            double num2 = 2.0;
            Calculator calc = new Calculator();

            double result = calc.Multiply(num1, num2);
            Assert.AreEqual(12, result);
        }

        [Test]
        public void TestDivide()
        {
            double num1 = 6.0;
            double num2 = 2.0;
            Calculator calc = new Calculator();

            double result = calc.Divide(num1, num2);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void TestRemainder()
        {
            double num1 = 6.0;
            double num2 = 2.0;
            Calculator calc = new Calculator();

            double result = calc.Remainder(num1, num2);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestCircleArea()
        {
            double num1 = 0.56;
            
            Calculator calc = new Calculator();

            double result = calc.CircleArea(num1);
            Assert.AreEqual(0.98520576000000015, result);
            //Consider refactoring to include Math.Pi
        }
    }
}