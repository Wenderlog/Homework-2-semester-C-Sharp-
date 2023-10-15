
[TestFixture]
public class ExpressionTreeTests
{
    [Test]
    public void ExpressionTreeCanEvaluateExpressionFromFile() { 
        string testFilePath = "C:\\Users\\Админ\\source\\repos\\Test4.1\\Test4.1\\input.txt";

        ExpressionTree tree = new ExpressionTree(testFilePath);

        double result = tree.Evaluate();
        Assert.AreEqual(1, result);
    }
    [Test]
    public void ExpressionTree_DivisionByZero_ThrowsException()
    {
        string testFilePath = "C:\\Users\\Админ\\source\\repos\\Test4.1\\Test4.1\\input2.txt";

        ExpressionTree tree = new ExpressionTree(testFilePath);

        Assert.Throws<DivideByZeroException>(() => tree.Evaluate());
    }
}