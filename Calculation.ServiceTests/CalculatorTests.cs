using Calculation.Service;
using NUnit.Framework;

namespace Calculation.ServiceTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase (6,4,10)]
        [TestCase (6,6,12)]
        public void When_I_Add_Two_Numbers(int x, int y, int expectedResult)
        {
            var calculationRequest = new CalculationRequest
                                         {
                                             X = x,
                                             Y = y,
                                             Operation = CalculationOperation.Add
                                         };

            var calculator = new Calculation.Service.Calculator();
            var sum = calculator.ExecuteCalculation(calculationRequest);

            Assert.That(sum.Equals(expectedResult), "The sum should add up to " +expectedResult);
        }

        [TestCase (6,3,3)]
        [TestCase (100,45,55)]
        public void When_I_Subtract_Two_Numbers(int x, int y, int expectedResult)
        {
            
                var calculationRequest = new CalculationRequest
                                             {
                    X = x,
                    Y = y,
                    Operation = CalculationOperation.Subtract
                };

                var calculator = new Calculation.Service.Calculator();
                var sum = calculator.ExecuteCalculation(calculationRequest);

                Assert.That(sum.Equals(expectedResult), "The sum should equal " +expectedResult);            
        }

        [TestCase(6,2,3)]
        [TestCase(8,4,2)]
        public void When_I_Divide_Two_Numbers(int x, int y, int expectedResult)
        {
            var calculationRequest = new CalculationRequest
            {
                X = x,
                Y = y,
                Operation = CalculationOperation.Divide
            };

            var calculator = new Calculation.Service.Calculator();
            var sum = calculator.ExecuteCalculation(calculationRequest);

            Assert.That(sum.Equals(expectedResult), "The sum should equal " +expectedResult);
        }

        [TestCase(6, 2, 12)]
        [TestCase(8, 4, 32)]
        public void When_I_Multiply_Two_Numbers(int x, int y, int expectedResult)
        {
            var calculationRequest = new CalculationRequest
            {
                X = x,
                Y = y,
                Operation = CalculationOperation.Multiply
            };

            var calculator = new Calculation.Service.Calculator();
            var sum = calculator.ExecuteCalculation(calculationRequest);

            Assert.That(sum.Equals(expectedResult), "The sum should equal " +expectedResult);
        }


    }
}
