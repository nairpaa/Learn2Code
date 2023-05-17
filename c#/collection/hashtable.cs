// The Hashtable is like a stripped-down dictionary that is designed for pure performance.
// It does not maintain any order in the collection and allows values to be looked up very quickly.
// It's a good candidate when computing against large data sets but for general use, the dictionary is friendlier.

using System;
using System.Collections;

var table = new Hashtable
{
    { 0, "Charles Dickens" },
    { 1, "George Orwell" },
    { 2, "Mark Twain" },
    { 3, "Jane Austen" }
};

foreach (DictionaryEntry entry in table) 
    Console.WriteLine($"{entry.Key} : {entry.Value}");