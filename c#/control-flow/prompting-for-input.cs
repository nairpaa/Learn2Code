using System;

while (true)
{
    // print a pseudo prompt
    Console.Write("> ");
    
    // read from stdin
    var input = Console.ReadLine();
    
    // loop again if tthe strring was empty
    if (string.IsNullOrWhiteSpace(input))
        continue;

    // break if "exit"
    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
        break;
    
    // print to stdout
    Console.WriteLine($"You said: {input}");
}