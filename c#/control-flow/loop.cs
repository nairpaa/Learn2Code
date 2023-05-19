using System;

// for loop
for (var i = 0; i < 10; i++) 
    Console.WriteLine($"i is {i}");

var array = new[] { 1, 2, 3, 4, 5 };
for (var i=0; i < array.Length; i++)
    Console.WriteLine($"i is {i}");

// foreach loop
var list = new List<int>() { 1, 2, 3, 4, 5 };
foreach(var c in list)
    Console.WriteLine(c);

// while loop
var x = 0;
while (true)
{
    if (x > 10)
        continue;
    
    Console.WriteLine(x);
    x++;
}
