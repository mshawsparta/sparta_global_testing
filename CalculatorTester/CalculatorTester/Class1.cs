using System;

namespace CalculatorTester
{
    public class Calculator
    {
        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
        public double Divide(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
        public double Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
        public double Remainder(double num1, double num2)
        {
            double result = num1 % num2;
            return result;
        }
        public double Subtract(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }
        public double CircleArea(double radius)
        {
            double result = (3.1416 * (radius * radius));
            return result;
        }

    }
}
