using NUnit.Framework;

[TestFixture]
public class OperandNodeTests
{
    [Test]
    public void OperandNode_CanEvaluate()
    {
        OperandNode operand = new OperandNode(5.0);
        double result = operand.Evaluate();
        Assert.AreEqual(5.0, result);
    }

}