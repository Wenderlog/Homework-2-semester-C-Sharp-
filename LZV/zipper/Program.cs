using zipper;

namespace Zipper;

internal class Program
{


    public static void Main(string[] args)
    {
        Workspace ws;
        try
        {
            ws = new Workspace(args);
        }
        catch (WorkspaceException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }

        FileStream inputFile;
        FileStream outputFile;
        if (ws.Mode == Workspace.WorkMode.Encode || ws.Mode == Workspace.WorkMode.Decode)
        {
            try
            {
                inputFile = new FileStream(ws.InFile, FileMode.Open);
            }
            catch (System.Security.SecurityException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            try
            {
                outputFile = new FileStream(ws.OutFile, FileMode.OpenOrCreate);
            }
            catch (System.Security.SecurityException ex)
            {
                inputFile.Close();
                Console.WriteLine(ex.Message);
                return;
            }
            catch (FileNotFoundException ex)
            {
                inputFile.Close();
                Console.WriteLine(ex.Message);
                return;
            }
            catch (UnauthorizedAccessException ex)
            {
                inputFile.Close();
                Console.WriteLine(ex.Message);
                return;
            }
            catch (DirectoryNotFoundException ex)
            {
                inputFile.Close();
                Console.WriteLine(ex.Message);
                return;
            }
            catch (PathTooLongException ex)
            {
                inputFile.Close();
                Console.WriteLine(ex.Message);
                return;
            }

            switch (ws.Mode)
            {
                case Workspace.WorkMode.Encode:
                    {
                        var input = new BitReader(inputFile);
                        var output = new BitWriter(outputFile);
                        LZW.Encode(input, output);
                        Console.WriteLine(ws.OutFile, (float)outputFile.Length / inputFile.Length);
                        input.Close();
                        output.Close();
                        break;
                    }

                case Workspace.WorkMode.Decode:
                    {
                        var input = new BitReader(inputFile);
                        var output = new BitWriter(outputFile);
                        LZW.Decode(input, output);
                        input.Close();
                        output.Close();
                        Console.WriteLine(ws.OutFile);
                        break;
                    }
            }
        }

        switch (ws.Mode)
        {
            case Workspace.WorkMode.Help:
                break;
        }
    }
}