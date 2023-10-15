public class Calculator
{
    private readonly IStack<double> _stack;

    public Calculator(IStack<double> stack)
    {
        _stack = stack;
    }

    public double Calculate(string expression)
    {
        string[] tokens = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string token in tokens)
        {
            if (double.TryParse(token, out double operand))
            {
                _stack.Push(operand);
            }
            else
            {
                if (_stack.IsEmpty)
                {
                    throw new InvalidOperationException("Invalid expression");
                }
                double operand2 = _stack.Pop();

                if (_stack.IsEmpty)
                {
                    throw new InvalidOperationException("Invalid expression");
                }

                double operand1 = _stack.Pop();
                PerformOperation(token, operand1, operand2);
            }
        }
        if (_stack.IsEmpty)
        {
            throw new InvalidOperationException("Invalid expression");
        }
        return _stack.Pop();
    }

    private void PerformOperation(string token, double operand1, double operand2)
    {
        switch (token)
        {
            case "+":
                _stack.Push(operand1 + operand2);
                break;

            case "-":
                _stack.Push(operand1 - operand2);
                break;

            case "*":
                _stack.Push(operand1 * operand2);
                break;

            case "/":
                if (Math.Abs(operand2) < double.Epsilon)
                {
                    throw new InvalidOperationException(" Division by zero");
                }
                _stack.Push(operand1 / operand2);
                break;
            default:
                throw new InvalidOperationException("Invalid operator:" + token);
        }
    }
}