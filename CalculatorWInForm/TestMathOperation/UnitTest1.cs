using CalculatorWInForm;

namespace TestMathOperation
{
    [TestFixture]
    public class MathOperationTests
    {
        [Test]
        public void TestAdd()
        {
            string result = MathOperation.Add("5", "3");
            Assert.AreEqual("8", result);
        }

        [Test]
        public void TestSub()
        {
            string result = MathOperation.Sub("5", "3");
            Assert.AreEqual("2", result);
        }

        [Test]
        public void TestMul()
        {
            string result = MathOperation.Mul("5", "3");
            Assert.AreEqual("15", result);
        }

        [Test]
        public void TestDev()
        {
            string result = MathOperation.Dev("6", "2");
            Assert.AreEqual("3", result);
        }

        [Test]
        public void TestProc()
        {
            string result = MathOperation.Proc("10", "20");
            Assert.AreEqual("200", result);
        }

        [Test]
        public void TestSqrt()
        {
            string result = MathOperation.Sqrt("16");
            Assert.AreEqual("4", result);
        }

        [Test]
        public void TestPow()
        {
            string result = MathOperation.Pow("4");
            Assert.AreEqual("16", result);
        }

        [Test]
        public void TestOneDev()
        {
            string result = MathOperation.OneDev("4");
            Assert.AreEqual("0.25", result);
        }

        [Test]
        public void TestInvalidInput()
        {
            string result = MathOperation.Add("5", "abc");
            Assert.IsNull(result);
        }

        [Test]
        public void TestDivisionByZero()
        {
            Assert.Throws<DivideByZeroException>(() => MathOperation.Dev("5", "0"));
        }
    }
}
