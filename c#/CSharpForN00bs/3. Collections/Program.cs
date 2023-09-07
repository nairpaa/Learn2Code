//
// Lists
//

// 1. We can create an empty list, or create one with values.
using System;
using System.Collections;
using System.Collections.Generic;

var list1 = new List<int>();
var list2 = new List<int> { 1, 2, 3, 4, 5 };

// 2. Add new value

var integers = new List<int>();

integers.Add(1);
integers.Add(2);
integers.Add(3);
integers.Add(4);
integers.Add(5);

Console.WriteLine($"The value at index 2 is {integers[2]}.");

// 3. Remove data

integers.Remove(1); // Remove a known value

integers.RemoveAt(3); // Remove from a given index

foreach(var i in integers) 
    Console.WriteLine(i);

// 4. The `Contains` method returns a bool if the given value is in the list.

if (integers.Contains(2))
    Console.WriteLine("1 is present");

// 5. `Find` method can be used to search the list for a value. 

var item = integers.Find(v => v == 3);

Console.WriteLine(item);

//
// Dictionary
//

var dict = new Dictionary<int, string>();

dict.Add(0, "Charles Dickens");
dict.Add(1, "George Orwell");
dict.Add(2, "Mark Twain");
// dict.Add(2, "Jane Austen"); -> Error, key must be unique

foreach (var kvp in dict) 
    Console.WriteLine($"Key {kvp.Key} contains: {kvp.Value}.");

// 1. Values are usually found by a known key.
// The safest way is by using the TryGetValue method, which will return a bool and the associated value.

if (dict.TryGetValue(2, out var value))
    Console.WriteLine(value);
    
    
// 2. The value associated with a key can be changed

if (dict.ContainsKey(2))
    dict[2] = "Jane Austen";
    
if (dict.TryGetValue(2, out var value2))
    Console.WriteLine(value2);


//
// Hashtable
//

var table = new Hashtable
{
    { 0, "Charles Dickens" },
    { 1, "George Orwell" },
    { 2, "Mark Twain" },
    { 3, "Jane Austen" }
};

foreach(DictionaryEntry entry in table)
    Console.WriteLine($"{entry.Key} : {entry.Value}");

// 
// Queue
// 

var queue = new Queue<int>();

// 1. Add items Queue
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);

// 2. Dequeue them all
while (queue.TryDequeue(out var value3))
    Console.WriteLine(value3);
    
// 3. The stack functions in the same way using the Push and Pop methods.
var stack = new Stack<int>();

// Add items
stack.Push(1);
stack.Push(2);
stack.Push(3);

// Remove them all
while (stack.TryPop(out var value4))
    Console.WriteLine(value4);