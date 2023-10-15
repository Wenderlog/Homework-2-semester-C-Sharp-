namespace zipper;

public class Trie<TValue>
{
    private static Value.None none = new Value.None();

    private Dictionary<char, Trie<TValue>> next;

    private Value value;

    public Trie()
    {
        this.next = new Dictionary<char, Trie<TValue>>();
        this.value = none;
        this.Size = 0;
    }

    public Trie(IEnumerable<KeyValuePair<string, TValue>> data)
    : this()
    {
        foreach (var (key, value) in data)
        {
            this[key] = value;
        }
    }

    public int Size { get; private set; }

    public TValue this[string key]
    {
        get => this.Get(key);
        set => this.Add(key, value);
    }

    public bool Add(string key, TValue value)
        => this.Set(key, value, 0);

    public bool Contains(string key)
        => this.Contains(key, 0);

    public TValue Get(string key)
        => this.Get(key, 0);

    public bool Remove(string key)
        => this.Remove(key, 0);

    public int HowManyStartsWithPrefix(string prefix)
    {
        return this.HowManyStartsWithPrefix(prefix, 0);
    }

    private bool Set(string key, TValue value, int curIndex)
    {
        if (curIndex == key.Length)
        {
            bool wasTerminal = this.value != none;
            this.value = new Value.Some(value);
            if (!wasTerminal)
            {
                this.Size += 1;
            }

            return !wasTerminal;
        }

        char curChar = key[curIndex];

        if (!this.next.ContainsKey(curChar))
        {
            this.next[curChar] = new Trie<TValue>();
        }

        bool wasAdded = this.next[curChar].Set(key, value, curIndex + 1);
        if (wasAdded)
        {
            this.Size += 1;
        }

        return wasAdded;
    }

    private bool Contains(string key, int curIndex)
    {
        if (curIndex == key.Length)
        {
            return this.value != none;
        }

        char curChar = key[curIndex];
        return this.next.ContainsKey(curChar)
            ? this.next[curChar].Contains(key, curIndex + 1)
            : false;
    }

    private TValue Get(string key, int curIndex)
    {
        if (curIndex == key.Length)
        {
            return this.value switch
            {
                Value.Some x => x.value,
                _ => throw new KeyNotFoundException()
            };
        }

        char curChar = key[curIndex];
        return this.next.ContainsKey(curChar)
            ? this.next[curChar].Get(key, curIndex + 1)
            : throw new KeyNotFoundException();
    }

    private bool Remove(string key, int curIndex)
    {
        if (curIndex == key.Length)
        {
            bool wasTerminal = this.value != none;
            this.value = none;
            return wasTerminal;
        }

        char curChar = key[curIndex];

        if (!this.next.ContainsKey(curChar))
        {
            return false;
        }

        Trie<TValue> nextTrie = this.next[curChar];

        if (!nextTrie.Remove(key, curIndex + 1))
        {
            return false;
        }

        if (nextTrie.Size == 0)
        {
            this.next.Remove(curChar);
        }

        this.Size -= 1;

        return true;
    }

    private int HowManyStartsWithPrefix(string prefix, int curIndex)
    {
        if (curIndex == prefix.Length)
        {
            return this.Size;
        }

        char curChar = prefix[curIndex];
        return this.next.ContainsKey(curChar)
            ? this.next[curChar].HowManyStartsWithPrefix(prefix, curIndex + 1)
            : 0;
    }

    private record Value
    {
        public record None()
        : Value();

        public record Some(TValue value)
        : Value();

        private Value()
        {
        }
    }
}
