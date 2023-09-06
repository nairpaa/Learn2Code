//
// Declaring
// 

int i1 = 10; // explicit
var i2 = 10; // implicit

// explicit
(string, string, int) t1 = ("Charles", "Dickness", 1812);

// implicit
var t2 = ("Charles", "Dickness", 1812);

// implicit with deconstruction
var (firstName, lastName, dob) = ("Charles", "Dickness", 1812);

// OK
// int i2;
// NOT OK
// var i2;

const int i3 = 20;
// NOT OK
// i3 = 123;

// 
// Naming Conventions
// 

// Object	            Casing
// ----------------------------------
// Classes	            PascalCase
// Public Members	    PascalCase
// Private Members	    _camelCase
// Methods	            PascalCase
// Variables	        camelCase
// Enums	            PascalCase

// 
// Casting
// 

// implicit cast
var i = 20;
double d = i;

// invalid cast
// double d1 = 3.14D;
// int i1 = d1;

// explicit
double d4 = 3.14D;
int i4 = (int)d4;

var c = 'A';
int x = c;
Console.WriteLine($"{c} == {x}");

c = (char)x;
Console.WriteLine($"{x} == {c}");
