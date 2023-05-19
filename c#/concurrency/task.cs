using System;
using System.Threading.Tasks;

var t1 = Task.Run(PrintLoop);
var t2 = Task.Run(PrintLoop);

await Task.WhenAll(t1, t2);

var result = await Task.Run(RunLoop);
Console.WriteLine(result);

void PrintLoop()
{
    for (var i = 0; i <=10; i++)
        Console.WriteLine(i);
}

int RunLoop()
{
    var total = 0;

    for (var i = 1; i <= 10; i++)
        total += 1;

    return total;
}