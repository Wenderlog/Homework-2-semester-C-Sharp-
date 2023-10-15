namespace zipper;

public interface IWriter
{
    public void WriteBits(int amount, byte[] data);

    public void WriteBytes(byte[] bytes);
}

public interface IReader
{
    public bool ReachedEOF { get; }

    public byte[] ReadBits(int amount);

    public byte ReadByte();
}

public class BitWriter : IWriter
{
    private FileStream file;

    public BitWriter(FileStream file)
        => this.file = file;

    public void WriteBits(int amount, byte[] data)
    {
        for (int i = 0; i * 8 < amount; i += 1)
        {
            this.file.Write(new byte[] { data[i] });
        }
    }

    public void WriteBytes(byte[] bytes)
        => this.file.Write(bytes);

    public void Close()
        => this.file.Close();
}

public class BitReader : IReader
{
    private FileStream file;

    public BitReader(FileStream file)
        => this.file = file;

    public bool ReachedEOF { get; private set; } = false;

    public byte[] ReadBits(int amount)
    {
        var buffer = new byte[amount % 8 > 0 ? (amount / 8) + 1 : amount / 8];
        this.file.Read(buffer);
        this.ReachedEOF = this.file.Position >= this.file.Length;
        return buffer;
    }

    public byte ReadByte()
        => this.ReadBits(8)[0];

    public void Close()
        => this.file.Close();
}