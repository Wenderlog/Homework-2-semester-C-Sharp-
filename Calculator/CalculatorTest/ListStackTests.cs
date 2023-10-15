namespace CalculatorTest
{
    [TestFixture]
    public class ListStackTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ListStack_PushAndPop()
        {
            ListStack<int> stack = new ListStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Assert.AreEqual(3, stack.Pop());
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(1, stack.Pop());
        }

        [Test]
        public void ListStack_IsEmpty()
        {
            ListStack<string> stack = new ListStack<string>();
            Assert.IsTrue(stack.IsEmpty);

            stack.Push("a");
            Assert.IsFalse(stack.IsEmpty);

            stack.Pop();
            Assert.IsTrue(stack.IsEmpty);
        }

        [Test]
        public void ListStack_ThrowsOnPopFromEmptyStack()
        {
            ListStack<double> stack = new ListStack<double>();
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Test]
        public void ListStack_CanHandleLargeNumberOfItems()
        {
            ListStack<int> stack = new ListStack<int>();

           for (int i = 0; i < 10000;  i++)
            {
                stack.Push(i);
            }

           for (int i = 9999; i >= 0; i--)
            {
                Assert.AreEqual(i, stack.Pop());
            }
        }
    }
}