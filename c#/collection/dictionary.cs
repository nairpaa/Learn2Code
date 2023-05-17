using System;
using System.Collections.Generic;

var dict = new Dictionary<int, string>();

// Add data
// Each key in a dictionary must be unique
dict.Add(0, "Charles Dicknes");
dict.Add(1, "George Orwell");
dict.Add(2, "Mark Twain");

// Print data
foreach (var kvp in dict)
    Console.WriteLine($"Key: {kvp.Key} contains: {kvp.Value}.");

// Get data by key
if (dict.TryGetValue(0, out var value))
    Console.WriteLine(value);
    
// Change value
if (dict.ContainsKey(2))
    dict[2] = "Jane Auesten";
    
// Print data
foreach (var kvp in dict)
    Console.WriteLine($"Key: {kvp.Key} contains: {kvp.Value}.");