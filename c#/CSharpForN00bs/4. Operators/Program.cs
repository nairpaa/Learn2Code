using System;
// 
// A. Mathematical Operators
// 

// + for add.
// - for subtract.
// * for multiply.
// / for divide.
// % for modulus.

Console.WriteLine(23 + 54); // addition
Console.WriteLine(32 - 12); // substraction
Console.WriteLine(4 * 5); // multiplication
Console.WriteLine(321 / 44); // division
Console.WriteLine(798 % 8); // modulus

// 
// B. Logical Operators
// 

// == for equals.
// > for greater than.
// < for less than.
// >= for greater than or equal to.
// <= for less than or equal to.
// != for not equal.

// generate some random numbers between 0 and 100
var rand = new Random();
var i1 = rand.Next(0, 100);
var i2 = rand.Next(0, 100);

if (i1 == i2) Console.WriteLine("Values are equal");
if (i1 != i2) Console.WriteLine("Values are not equal");
if (i1 > i2) Console.WriteLine("i1 is greater than i2");
if (i1 < i2) Console.WriteLine("i1 is less than i2");
if (i1 >= i2) Console.WriteLine("i1 is greater or equal to i2");
if (i1 <= i2) Console.WriteLine("i1 is less or equal to i2"); 

// 
// C. Bitwise Operators
// 

// & for AND.
// | for OR.
// ^ for XOR.
// << for left shift.
// >> for right shift.

var rand2 = new Random();
var j1 = rand.Next(0, 100);
var j2 = rand.Next(0, 100);

Console.WriteLine(j1 & j2); // AND
Console.WriteLine(j1 | j2); // OR
Console.WriteLine(j1 ^ j2); // XOR
Console.WriteLine(j1 << j2); // Left Shift
Console.WriteLine(j1 >> j2); // Left Shift