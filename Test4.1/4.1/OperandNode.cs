using System.Collections.Generic;
public class OperandNode : ExpressionNode
{
    public double value;

    public OperandNode(double value)
    {
        this.value = value;
    }
    public override double Evaluate()
    {
        return value;
    }

    public override string Print()
    {
        return value.ToString();
    }
}