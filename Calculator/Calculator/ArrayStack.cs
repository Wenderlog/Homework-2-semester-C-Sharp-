public class ArrayStack<T> : IStack<T>
{
    private T[] _data;
    private int _top;

    public ArrayStack(int capacity)
    {
        _data = new T[capacity];
        _top = -1;
    }

    public bool IsEmpty => _top == -1;

    public T Pop()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        return _data[_top--];
    }

    public void Push(T item)
    {
        if (_top == _data.Length - 1)
        {
            throw new StackOverflowException("Stack is full");
        }
        _data[++_top] = item;
    }
}