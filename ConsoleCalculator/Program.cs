namespace ConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            double result = calculator.AddNumbersDouble(5, 5);
            Console.WriteLine($"AddNumbers result: {result}");
        }
    }
}