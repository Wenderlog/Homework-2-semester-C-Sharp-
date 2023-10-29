using NUnit.Framework;
using OperatorNode;

[TestFixture]
public class OperatordNodeTests
{
    [Test]
    public void OperatordNode_CanEvaluateAddition()
    {
        ExpressionNode left = new OperandNode(2.0);
        ExpressionNode right = new OperandNode(3.0);
        OperatordNode node = new OperatordNode('+', left, right);

        double result = node.Evaluate();
        Assert.AreEqual(5.0, result);
    }

    [Test]
    public void OperatordNode_CanEvaluateSubtraction()
    {
        ExpressionNode left = new OperandNode(5.0);
        ExpressionNode right = new OperandNode(3.0);
        OperatordNode node = new OperatordNode('-', left, right);

        double result = node.Evaluate();
        Assert.AreEqual(2.0, result);
    }

}