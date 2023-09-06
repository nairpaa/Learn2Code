//
// Integers and Floating Points
//

// Keyword  Size
// -------------------------
// sbyte 	Signed 8-bit
// byte 	Unsigned 8-bit
// short 	Signed 16-bit
// ushort 	Unsigned 16-bit
// int 	    Signed 32-bit
// uint 	Unsigned 32-bit
// long 	Signed 64-bit
// ulong 	Unsigned 64-bit
    
int sInt = -20;
uint uInt = 20;

byte sByte = 255;

Console.WriteLine("sInt = {0}", sInt);
Console.WriteLine("uInt = {0}", uInt);
Console.WriteLine("sByte = {0}", sByte);

// When declaring a float or double, the letter F or D should be appended to the value.

float piFloat = 3.14159265358F;
double piDouble = 3.14159265358D;

Console.WriteLine("pi as float: {0}", piFloat);
Console.WriteLine("pi as double: {0}", piDouble);

// 
// Booleans and Characters
//

// A char is a single letter or number, represented by an integer.  Those "integers" are standardised in the ASCII and Unicode tables.

bool myBool = true;
char myChar = 'A';

Console.WriteLine("myBool: {0}", myBool);
Console.WriteLine("myChar: {0}", myChar);

// 
// Arrays and Tuples
// 

// An array can hold multiple values of a single data type; whereas a tuple can hold multiple values but of various data types.

int[] intArray = { 1, 2, 3, 4, 5 };
int[] intArray2 = new int[5]; // Empty array

Console.WriteLine("intArray[2]: {0}", intArray[2]);

(string, string, int) tuple = ("Charles", "Dickens", 1812);
Console.WriteLine("Tuple-1: {0} {1} was born in {2}", tuple.Item1, tuple.Item2, tuple.Item3);

(string, string, int) tuple2 = ("Charles", "Dickens", 1812);
(string firstName, string lastName, int dob) = tuple2;
Console.WriteLine("Tuple-2: {0} {1} was born in {2}", firstName, lastName, dob);

// 
// Strings
//

// In fact, string has lots of really useful methods including Split, Join, Equals, and IsNullOrEmpty/IsNullOrWhiteSpace.

string name2 = "Rasta Mouse";
string firstName2 = "Rasta";
string lastName2 = "Mouse";
string fullName2 = $"{firstName2} {lastName2}";
string fullName3 = firstName2 + " " + lastName2;
string fullName4 = string.Concat(firstName2, " ", lastName2);

Console.WriteLine("name2: {0}", name2);
Console.WriteLine("firstName2: {0}", firstName2);
Console.WriteLine("lastName2: {0}", lastName2);
Console.WriteLine("fullName2: {0}", fullName2);
Console.WriteLine("fullName3: {0}", fullName3);
Console.WriteLine("fullName4: {0}", fullName4);


