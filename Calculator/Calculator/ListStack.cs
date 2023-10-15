public class ListStack<T> : IStack<T>
{

    private List<T> _data;

    public ListStack()
    {
        _data = new List<T>();
    }

    public bool IsEmpty => _data.Count == 0;

    public T Pop()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        T item = _data[_data.Count - 1];
        _data.RemoveAt(_data.Count - 1);
        return item;
    }

    public void Push(T item)
    {
        _data.Add(item);
    }
}