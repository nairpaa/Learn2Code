using System;
using System.IO;
// 1. Try-Catch

var array = new[] { 1, 2, 3, 4, 5 };

try
{
    Console.WriteLine(array[5]);
}
catch (TaskCanceledException)
{
    // handle task cancelled
}
catch (ThreadAbortException)
{
    // handle thread aborted
}
catch (OperationCanceledException)
{
    // handle operation cancelled
}
catch (Exception e)
{
    Console.WriteLine($"Something went wrong: {e.Message}");
}
finally
{
    Console.WriteLine("Code inside the finally block is always executed");
}

Console.WriteLine("I'm still alive...");

// 2. Error Propagation

var content = ReadFile("/tmp/tests.txt");
Console.WriteLine(content);

string ReadFile(string path)
{
    using var fs = OpenFileStream(path);
    using var sr = new StreamReader(fs);

    return sr.ReadToEnd();
}
    
FileStream OpenFileStream(string path)
{
    try
    {
        return File.OpenRead(path);
    }
    catch (FileNotFoundException)
    {
        return File.Create(path);
    }
}
