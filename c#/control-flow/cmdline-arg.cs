using System;

// run using command:
// dotnet run arg1 arg2 arg3 arg4
for (var i = 0; i < args.Length; i++)
    Console.WriteLine($"Argument {i} is {args[i]}");


if (args.Length < 2)
{
    Console.WriteLine("Not enough arguments");
    ShowUsage();
    return;
}

void ShowUsage()
{
    Console.WriteLine("Usage: app.exe <arg1> <arg2>");
}