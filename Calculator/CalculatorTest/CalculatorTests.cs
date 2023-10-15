[TestFixture]
public class CalculatorTests
{
    [Test]
    public void Calculator_CanPerformAddition()
    {
        IStack<double> stack = new ListStack<double>();
        Calculator calculator = new Calculator(stack);

        double result = calculator.Calculate("2 3 +");
        Assert.AreEqual(5, result);
    }

    [Test]
    public void Calculator_CanPerformSubtraction()
    {
        IStack<double> stack = new ListStack<double>();
        Calculator calculator = new Calculator(stack);

        double result = calculator.Calculate("5 3 -");
        Assert.AreEqual(2, result);
    }

    [Test]
    public void Calculator_CanPerformMultiplication()
    {
        IStack<double> stack = new ListStack<double>();
        Calculator calculator = new Calculator(stack);

        double result = calculator.Calculate("2 3 *");
        Assert.AreEqual(6, result);
    }

    [Test]
    public void Calculator_CanPerformDivision()
    {
        IStack<double> stack = new ListStack<double>();
        Calculator calculator = new Calculator(stack);

        double result = calculator.Calculate("6 3 /");
        Assert.AreEqual(2, result);
    }


    [Test]
    public void Calculator_ThrowsExceptionOnDivisionByZero()
    {
        IStack<double> stack = new ListStack<double>();
        Calculator calculator = new Calculator(stack);

        Assert.Throws<InvalidOperationException>(() => calculator.Calculate("2 0 /"));
    }
}