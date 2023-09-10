using System;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Channels;

//
// A. Threads
// 

var thread1 = new Thread(RunLoop)
{
    // A thread is run in the foreground by default,
    // but can be made to run in the background by setting the IsBackground property to true.
    IsBackground = true
};
var thread2 = new Thread(RunLoop);

thread1.Start(10);
thread2.Start(5);

var task1 = Task.Run(PrintLoop);
var task2 = Task.Run(PrintLoop);
await Task.WhenAll(task1, task2);

Parallel.For(1, 10, Print);

//
// D. Channels
// 

var channel = Channel.CreateUnbounded<string>();
var task = Task.Run(async () =>
{
    for (var i = 0; i < 10; i++)
        await channel.Writer.WriteAsync($"This is loop {i} (channel)");
    
    channel.Writer.Complete();
});

while (!task.IsCompleted)
{
    try
    {
        var message = await channel.Reader.ReadAsync();
        Console.WriteLine(message);
    }
    catch (ChannelClosedException)
    {
        Console.WriteLine("Channel has been closed");
        break;
    }
}

void RunLoop(object obj)
{
    if (obj is not int counter)
        return;
    
    for (var i = 1; i <= counter; i++)
        Console.WriteLine($"Thread: {i}");
}

//
// B. Task
// 

void PrintLoop()
{
    for (var i = 1; i <= 10; i++)
        Console.WriteLine($"Task: {i}");
}

//
// C. Parallel
// 

void Print(int i)
{
    Console.WriteLine($"This is loop #{i}");
}

