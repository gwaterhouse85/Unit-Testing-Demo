using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculationRequestBuilder = new CalculationRequestBuilder();
            var calculator = new Calculation.Service.Calculator();

            var moreCalculations = true;

            while (moreCalculations)
            {
                Console.WriteLine("Enter Calculation or type quit to exit");
                string inputString = Console.ReadLine();

                var calculationRequest = calculationRequestBuilder.Build(inputString);
                var result = calculator.ExecuteCalculation(calculationRequest);

                Console.WriteLine(string.Format("{0} = {1}", inputString, result));

                if (inputString == "quit")
                {
                    moreCalculations = false;
                }
            }
        }
    }
}
