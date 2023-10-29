using System.Collections.Generic;
namespace OperatorNode
{
    public class OperatordNode : ExpressionNode
    {
        private char operation;
        private ExpressionNode left;
        private ExpressionNode right;

        public OperatordNode(char operation, ExpressionNode left, ExpressionNode right)
        {
            this.operation = operation;
            this.left = left;
            this.right = right;
        }
        public override double Evaluate()
        {
            double leftValue = left.Evaluate();
            double rightValue = right.Evaluate();

            switch (operation)
            {
                case '+':
                    return leftValue + rightValue;
                case '-':
                    return leftValue - rightValue;
                case '*':
                    return leftValue * rightValue;
                case '/':
                    if (rightValue == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    return leftValue / rightValue;
                default:
                    throw new InvalidOperationException("Invalid operation: " + operation);
            }
        }

        public override string Print()
        {
            return $"({operation} {left.Print()} {right.Print()})";
        }
    }
}