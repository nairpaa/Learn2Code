using System;

// generatet some random numbers beteen 0 and 100
var rand = new Random();
var i1 = rand.Next(0, 100);
var i2 = rand.Next(0, 100);

if (i1 == i2) Console.WriteLine("Values are equal");
if (i1 != i2) Console.WriteLine("Values are not equal");
if (i1 > i2) Console.WriteLine("i1 is greater than i2");
if (i1 < i2) Console.WriteLine("i1 is less than i2");
if (i1 >= i2) Console.WriteLine("i1 is greater or equal to i2");
if (i1 <= i2) Console.WriteLine("i1 is less or equal to i2");