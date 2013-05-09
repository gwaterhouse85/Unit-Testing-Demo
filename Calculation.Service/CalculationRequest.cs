namespace Calculation.Service
{
    public enum CalculationOperation
    {
        Unknown,
        Add,
        Subtract,
        Multiply,
        Divide
    }

    public class CalculationRequest
    {
        public int X { get; set; }
        public int Y { get; set; }
        public CalculationOperation Operation { get; set; }
    }
}