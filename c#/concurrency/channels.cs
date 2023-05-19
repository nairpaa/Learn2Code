using System;
using System.Threading.Channels;
using System.Threading.Tasks;

var channel = Channel.CreateUnbounded<string>();

var task = Task.Run(async () =>
{
    for (var i = 0; i < 10; i++)
        await channel.Writer.WriteAsync(item: $"This is loop {i}");
    
    channel.Writer.Complete();
});