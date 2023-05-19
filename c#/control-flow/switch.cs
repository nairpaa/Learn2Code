var animal = "Dog";

// If
if (animal == "Dog")
{
    Console.WriteLine("Woof");
}
else if (animal == "Cat")
{
    Console.WriteLine("Meow");
}
else
{
    Console.WriteLine("Unknown");
}

// Switch
var sound = animal switch
{
    "Dog" => "Woof",
    "Cat" => "Meow",
    _ => "Unknown"
};

Console.WriteLine(sound);