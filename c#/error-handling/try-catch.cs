var array = new[] { 1,2,3,4,5 };

try
{
    Console.WriteLine(array[5]);
}
catch (Exception e)
{
    Console.WriteLine($"Something went wrong: {e.Message}");
}

Console.WriteLine("I'm still alive...");


// xyz
try
{
    // do something
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
catch (Exception)
{
    // catch all
}



