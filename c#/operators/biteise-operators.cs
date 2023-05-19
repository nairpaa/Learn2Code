using System;

// generatet some random numbers beteen 0 and 100
var rand = new Random();
var i1 = rand.Next(0, 100);
var i2 = rand.Next(0, 100);

Console.WriteLine(i1 & i2);
Console.WriteLine(i1 | i2);
Console.WriteLine(i1 ^ i2);
Console.WriteLine(i1 << i2);
Console.WriteLine(i1 >> i2);