using System;
using System.Collections.Generic;
using System.Threading.Tasks;

Parallel.For(fromInclusive:1, toExclusive:10, Print);

void Print(int i)
{
    Console.WriteLine($"This is loop #{i}");
}
