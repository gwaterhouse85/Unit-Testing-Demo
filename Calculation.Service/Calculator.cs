using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation.Service
{
    public class Calculator
    {
        public int ExecuteCalculation(CalculationRequest calculationRequest)
        {
            if (calculationRequest.Operation == CalculationOperation.Add)
            {
                var result = Add(calculationRequest.X, calculationRequest.Y);
                return result;
            }
            else if (calculationRequest.Operation == CalculationOperation.Subtract)
            {
                var result = Subtract(calculationRequest.X, calculationRequest.Y);
                return result;
            }
            else if (calculationRequest.Operation == CalculationOperation.Multiply)
            {
                var result = Multiply(calculationRequest.X, calculationRequest.Y);
                return result;
            }
            else if (calculationRequest.Operation == CalculationOperation.Divide)
            {
                var result = Divide(calculationRequest.X, calculationRequest.Y);
                return result;
            }

            throw new InvalidOperationException("Specified calculation operation is invalid");
        }

        private int Add(int x, int y)
        {
            var result = x + y;
            return result;
        }

        private int Subtract(int x, int y)
        {
            var result = x - y;
            return result;
        }
        
        private int Multiply(int x, int y)
        {
            var result = x*y;
            return result;
        }

        private int Divide (int x, int y)
        {
            var result = x/y;
            return result;
        }
    }
}
