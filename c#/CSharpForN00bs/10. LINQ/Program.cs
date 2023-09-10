// random people
var people = new List<Person>
{
    new() { FirstName = "Jose", LastName = "Gomez", DateOfBirth = new DateOnly(1982, 4, 2) },
    new() { FirstName = "Carolyn", LastName = "Nando", DateOfBirth = new DateOnly(1968, 2, 21) },
    new() { FirstName = "Rosemarie", LastName = "Yusman", DateOfBirth = new DateOnly(1990, 4, 25) },
    new() { FirstName = "Hester", LastName = "Pallo", DateOfBirth = new DateOnly(1992, 5, 15) },
    new() { FirstName = "Diana", LastName = "Dickens", DateOfBirth = new DateOnly(1999, 9, 10) }
};

// find everyone who was born after 1975
var persons = people.Where(p => p.DateOfBirth.Year > 1975).ToArray();
Console.WriteLine($"Found {persons.Length} people. They are:");

// print them
foreach (var person in persons)
    Console.WriteLine($"{person.FullName}, born on {person.DateOfBirth}, age {person.Age}");

internal class Person
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

    public string FullName => $"{FirstName} {LastName}";
    
    public DateOnly DateOfBirth { get; init; }

    public int Age => DateTime.Today.Year - DateOfBirth.Year;
}