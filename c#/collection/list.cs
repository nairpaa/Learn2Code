using System;
using System.Collections.Generic;

// Initial declaration
var list1 = new List<int>();
var list2 = new List<int>{1, 2, 3, 4, 5};

var integers = new List<int>();

integers.Add(item:1);
integers.Add(item:2);
integers.Add(item:3);
integers.Add(item:4);
integers.Add(item:5);

Console.WriteLine($"The value at index 2 is {integers[1]}");

// remove a known value
integers.Remove(item: 1);

// remove from a given index
integers.RemoveAt(index:3);

int x = 0;
foreach (var i in integers)
{
    Console.WriteLine($"{i} - {x}");
    x++;
}
    
// Contains -> The 'Contains' method returns a bool if the given value is in the list.
var integers2 = new List<int> { 1, 1, 2, 3, 4, 5 };

if (integers2.Contains(item:1))
    Console.WriteLine("1 is present");

// Find -> And 'Find' can be used to search the list for a value.
// The method takes a "predicate" which is written as a lambda expression.
var integers3 = new List<int> { 1, 2, 3, 4, 5 };
var item = integers3.Find(v => v == 3);

Console.WriteLine(item);