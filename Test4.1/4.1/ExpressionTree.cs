using System;
using OperatorNode;
using System.Collections.Generic;

public class ExpressionTree
{
    private ExpressionNode root;

    public ExpressionTree(string filePath)
    {
        string expression = File.ReadAllText(filePath);
        root = Parse(expression);
    }

    private ExpressionNode Parse(string expression)
    {
        Stack<ExpressionNode> nodeStack = new Stack<ExpressionNode>();
        Stack<char> operatorStack = new Stack<char>();

        for (int i = 0; i < expression.Length; i++)
        {
            char currentChar = expression[i];

            if (currentChar == ' ')
            {
                continue;
            }

            if (char.IsDigit(currentChar))
            {
                int j = i;
                while (j < expression.Length && (char.IsDigit(expression[j]) || expression[j] == '.'))
                {
                    j++;
                }

                double operand = double.Parse(expression.Substring(i, j - i));
                nodeStack.Push(new OperandNode(operand));
                i = j - 1;
            }
            else if (currentChar == '(')
            {
                operatorStack.Push(currentChar);
            }
            else if (currentChar == ')')
            {
                while (operatorStack.Count > 0 && operatorStack.Peek() != '(')
                {
                    char op = operatorStack.Pop();
                    ExpressionNode right = nodeStack.Pop();
                    ExpressionNode left = nodeStack.Pop();
                    nodeStack.Push(new OperatordNode(op, left, right));
                }
                if (operatorStack.Count > 0 && operatorStack.Peek() == '(')
                {
                    operatorStack.Pop();
                }
            }
            else if (isOperator(currentChar))
            {
                while (operatorStack.Count > 0 && OperatorPrecedence(operatorStack.Peek()) >= OperatorPrecedence(currentChar))
                {
                    char op = operatorStack.Pop();
                    ExpressionNode right = nodeStack.Pop();
                    ExpressionNode left = nodeStack.Pop();
                    nodeStack.Push(new OperatordNode(op, left, right));
                }
                operatorStack.Push(currentChar);
            }
            else
            {
                throw new InvalidOperationException($"Invalid character :  {currentChar}");
            }
        }
        while (operatorStack.Count > 0)
        {
            char op = operatorStack.Pop();
            ExpressionNode right = nodeStack.Pop();
            ExpressionNode left = nodeStack.Pop();
            nodeStack.Push(new OperatordNode(op, left, right));
        }

        if (nodeStack.Count != 1 || operatorStack.Count != 0)
        {
            throw new InvalidOperationException("Invalid expression format");
        }
        return nodeStack.Pop();
    }

    private bool isOperator(char c)
    {
        if (c == '+' ||  c == '-' || c == '*' || c == '/') {
            return true;
        }
        return false;
    }

    private int OperatorPrecedence(char op)
    {
        switch (op)
        {
            case '+':
            case '-':
                return 1;
            case '*':
            case '/':
                return 2;
            default:
                return 0;
        }
    }

    public double Evaluate()
    {
        if (root == null)
        {
            throw new InvalidOperationException("Tree is empty");
        }
        return root.Evaluate();
    }

    public void PrintTree()
    {
        if (root != null)
        {
            Console.WriteLine(root.Print());
        }
    }
}