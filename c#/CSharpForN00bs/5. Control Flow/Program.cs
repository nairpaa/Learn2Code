using System;

// 
// A. If / Else
// 

var condition1 = true;
var condition2 = false;
var condition3 = false;

// 1. One condition
if (condition1)
{
    // do something
}

// 2. Add code block if condition is false 
if (condition1)
{
    // do something
}
else
{
    // do something else
}

// 2. Add additional branches
if (condition1)
{
    // do something
}
else if (condition2)
{
    // do something else
}
else
{
    // catch all
}

// 3. Multiple logic operators
if (condition1 || condition2 && condition3) // the AND statement is evaluated first, followed by the OR.
    Console.WriteLine("Good to go (1)");

if ((condition1 || condition2) && condition3)
    Console.WriteLine("Good to go (2)");


// 
// B. Switch
// 

var animal = "Dog";
var sound = animal switch
{
    "Dog" => "Woof",
    "Cat" => "Meow",
    _ => "Unknown"
};

Console.WriteLine(sound);

//
// C. Enums
// 

// 1. An enum (or enumeration) is a set of pre-defined constants (i.e. values that cannot be changed).
var (firstName, lastName, status) = ("Charles", "Dickens", Status.Dead);

// 2. We can also use enums with switch.
switch (status)
{
    case Status.Dead:
        Console.WriteLine($"{firstName} {lastName} is dead");
        break;
    case Status.Alive:
        Console.WriteLine($"{firstName} {lastName} is alive");
        break;
    default:
        throw new ArgumentOutOfRangeException();
}

//
// D. Loops
//

// 1. For
for (var z = 0; z < 10; z++)
    Console.WriteLine($"z is {z}");

var array = new[] { 1, 2, 3, 4, 5 };
for (var z = 0; z < array.Length; z++)
    Console.WriteLine(array[z]);

// 2. While
var i = 0;
while (i < 10)
{
    Console.WriteLine(i);
    i++;
}

var j = 0;
while (true)
{
    if (j > 10)
        break;
    
    Console.WriteLine(j);
    j++;
}

// var k = 0;
// while (k < 10)
// {
//     if (k == 5)
//         continue;
//     
//     Console.WriteLine($"k: {k}");
//     k++;
// }

// 3. ForEach
var list = new List<int> { 1, 2, 3, 4, 5 };
foreach(var l in list)
    Console.WriteLine(l);

//
// E. Scopes
//

// {
//     // "outer" scope
//     {
//         // "inner" scope
//     }
//     // "outer" scope
// }

// 
// F. Command Line Arguments
// 

// PS> dotnet run arg1 arg2 arg3
if (args.Length < 2)
{
    Console.WriteLine("Not enough arguments");
    ShowUsage();
    return;
}

for (var z = 0; z < args.Length; z++)
    Console.WriteLine($"Argument {z} is {args[z]}");

void ShowUsage()
{
    Console.WriteLine("Usage: app.exe <arg1> <arg2>");
}

// 
// G. Prompting for Input
// 

while (true)
{
    // print a pseudo prompt
    Console.Write("> ");
    
    // read from stdin
    var input = Console.ReadLine();
    
    // loop again if the string was empty
    if (string.IsNullOrWhiteSpace(input))
        continue;
    
    // break if "exit"
    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
        break;
    
    // print to stdout
    Console.WriteLine($"You said: {input}");
}

//
// Enums
//
internal enum Status
{
    Dead,
    Alive
}

