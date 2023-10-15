namespace zipper;

public class Workspace
{
    public Workspace(string[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            string arg = args[i];
            switch (arg)
            {
                case "-c":
                    this.Mode = this.Mode == WorkMode.Undefined ? WorkMode.Encode : throw new WorkspaceException("Заданы два режима работы");
                    break;
                case "-u":
                    this.Mode = this.Mode == WorkMode.Undefined ? WorkMode.Decode : throw new WorkspaceException("Заданы два режима работы");
                    break;
                case "-h":
                case "--help":
                    this.Mode = this.Mode == WorkMode.Undefined ? WorkMode.Help : throw new WorkspaceException("Заданы два режима работы");
                    break;
                case "-o":
                    this.OutFile = i + 1 < args.Length ? args[++i] : throw new WorkspaceException("\"-o\" за аргументом должно следовать имя выходного файла");
                    break;
                default:
                    this.InFile = arg;
                    break;
            }
        }

        if (this.InFile is null)
        {
            if (this.Mode != WorkMode.Help)
            {
                throw new WorkspaceException("Имя входного файла указано не было");
            }

            this.InFile = string.Empty;
        }

        if (this.OutFile is null)
        {
            this.OutFile = this.Mode switch
            {
                WorkMode.Encode => this.InFile + ".zipped",
                WorkMode.Decode => this.InFile.Substring(this.InFile.Length - 7) == ".zipped"
                    ? this.InFile.Substring(0, this.InFile.Length - 7)
                    : throw new WorkspaceException("Не найдено имя выходного файла с именем входного файла, которое не заканчивается на .zipped"),
                _ => string.Empty
            };
        }
    }

    public enum WorkMode
    {
        Encode,
        Decode,
        Help,
        Undefined,
    }

    public string InFile { get; }
    public string OutFile { get; }

    public WorkMode Mode { get; } = WorkMode.Undefined;
}

[System.Serializable]
public class WorkspaceException : System.Exception
{
    public WorkspaceException()
    {
    }

    public WorkspaceException(string message)
    : base(message)
    {
    }
    public WorkspaceException(string message, System.Exception inner)
    : base(message, inner)
    {
    }

    protected WorkspaceException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context)
    : base(info, context)
    {
    }
}