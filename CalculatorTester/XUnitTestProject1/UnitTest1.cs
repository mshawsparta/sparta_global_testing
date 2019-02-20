using CalculatorTester;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double num1 = 6.0;
            double num2 = 2.0;
            Calculator calc = new Calculator();

            double result = calc.Add(num1, num2);
            Assert.Equal(8, result);


        }
        [Fact]
        public void TestSubtract()
        {
            double num1 = 6.0;
            double num2 = 2.0;
            Calculator calc = new Calculator();

            double result = calc.Subtract(num1, num2);
            Assert.Equal(4, result);
        }
        [Fact]
        public void TestMultiply()
        {
            double num1 = 6.0;
            double num2 = 2.0;
            Calculator calc = new Calculator();

            double result = calc.Multiply(num1, num2);
            Assert.Equal(12, result);
        }

        [Fact]
        public void TestDivide()
        {
            double num1 = 6.0;
            double num2 = 2.0;
            Calculator calc = new Calculator();

            double result = calc.Divide(num1, num2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void TestRemainder()
        {
            double num1 = 6.0;
            double num2 = 2.0;
            Calculator calc = new Calculator();

            double result = calc.Remainder(num1, num2);
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestCircleArea()
        {
            double num1 = 0.56;

            Calculator calc = new Calculator();

            double result = calc.CircleArea(num1);
            Assert.Equal(0.98520576000000015, result);
            //Consider refactoring to include Math.Pi
        }
    }
}
