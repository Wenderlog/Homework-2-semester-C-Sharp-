namespace CalculatorTest
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ArrayStack_PushAndPop()
        {
            ArrayStack<int> stack = new ArrayStack<int> (5);
            stack.Push (1);
            stack.Push (2);
            stack.Push (3);

            Assert.AreEqual (3, stack.Pop ());
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual (1, stack.Pop ()); 
        }

        [Test]
        public void ArrayStack_IsEmpty()
        {
            ArrayStack<string> stack = new ArrayStack<string>(3);
            Assert.IsTrue(stack.IsEmpty);

            stack.Push("a");
            Assert.IsFalse(stack.IsEmpty);

            stack.Pop();
            Assert.IsTrue(stack.IsEmpty);
        }

        [Test]
        public void ArrayStack_ThrowsOnPopFromEmptyStack()
        {
            ArrayStack<double> stack = new ArrayStack<double>(5);
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Test]
        public void ArrayStack_ThrowsOnPushToFullStack()
        {
            ArrayStack<int> stack = new ArrayStack<int>(2);

            stack.Push(1);
            stack.Push(2);
            Assert.Throws<StackOverflowException>(() => stack.Push(3));
        }
    }
}