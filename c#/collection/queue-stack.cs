// Queue -> FIFO

var queue = new Queue<int>();

// add items
queue.Enqueue(item:1);
queue.Enqueue(item:2);
queue.Enqueue(item:3);

// dequeue them all
while (queue.TryDequeue(out var value))
    Console.WriteLine(value);


// Stack -> LIFO

var stack = new Stack<int>();

// add items
stack.Push(item:1);
stack.Push(item:2);
stack.Push(item:3);

// remove them all
while (stack.TryPop(out var value))
    Console.WriteLine(value);