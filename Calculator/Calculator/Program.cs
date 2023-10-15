public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            IStack<double> stack = new ArrayStack<double>(100);
            Calculator calculator = new Calculator(stack);

            string expression = "1 -2 2 / * ";

            double result = calculator.Calculate(expression);
            Console.WriteLine("Result: " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}