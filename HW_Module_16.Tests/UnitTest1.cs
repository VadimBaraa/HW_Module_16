using Practices;
using Xunit;

namespace Practices
{
    public class Calculator
    {
        public int Additional(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }
    }
}


    
    public class CalculatorTest
    {
        

        [Fact]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Additional(5, 2);
            Assert.Equal(7, result);
        }

        [Fact]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Multiplication(3, 2);
            Assert.Equal(6, result);
        }

        [Fact]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Division(6, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Subtraction(6, 2);
            Assert.Equal(4, result);
        }
    }
