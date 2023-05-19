using System;
using System.Threading;

var t1 = new Thread(RunLoop)
{
    IsBackground = true
};
var t2 = new Thread(RunLoop);

t1.Start(10);
t2.Start(5);

void RunLoop(object obj)
{
    if (obj is not int counter)
        return;
    
    for (var i = 1; i <= 10; i++)
        Console.WriteLine(i);
}