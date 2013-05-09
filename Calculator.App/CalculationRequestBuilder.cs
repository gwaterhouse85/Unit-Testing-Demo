using Calculation.Service;

namespace Calculator.App
{
    public class CalculationRequestBuilder
    {
        public CalculationRequest Build(string inputString)
        {
            var indexOf = inputString.IndexOfAny(new[] { '+', '-', '/', '*'});

            var operationString = inputString.Substring(indexOf, 1);
            var x = int.Parse(inputString.Substring(0, indexOf));
            var y = int.Parse(inputString.Substring(indexOf + 1));

            var calculationRequest = new CalculationRequest()
                {
                    Operation = BuildCalculationOperation(operationString),
                    X = x,
                    Y = y
                };

            return calculationRequest;
        }

        private CalculationOperation BuildCalculationOperation(string operationString)
        {
            var calculationOperation = CalculationOperation.Unknown;

            switch (operationString)
            {
                case "+":
                    calculationOperation = CalculationOperation.Add;
                    break;
                case "-":
                    calculationOperation = CalculationOperation.Subtract;
                    break;
                case "/":
                    calculationOperation = CalculationOperation.Divide;
                    break;
                case "*":
                    calculationOperation = CalculationOperation.Multiply;
                    break;
            }

            return calculationOperation;
        }
    }
}