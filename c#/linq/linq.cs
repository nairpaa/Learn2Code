// LINQ is short for Language-Integrated Query and allows you to write
// queries against strongly typed collections using C# keywords and operators

// random people
var people = new List<Person>
{
    new() { FirstName = "Jose", LastName = "Gomez", DateOfBirth = new DateOnly(year: 1957, month: 2, day: 3) },
    new() { FirstName = "Carolyn", LastName = "Farias", DateOfBirth = new DateOnly(year: 1972, month: 11, day: 22) },
    new() { FirstName = "Rosemarie", LastName = "Pickens", DateOfBirth = new DateOnly(year:1993, month:5, day:17)},
    new() { FirstName = "Hester", LastName = "Funk", DateOfBirth = new DateOnly(year:196, month:11, day:1) },
    new() { FirstName = "Dianne", LastName = "Soria", DateOfBirth = new DateOnly(year:1979, month:7, day:26) }
};

// find everyone who was born after 1975
var persons = people.Where(p => p.DateOfBirth.Year > 1975).ToArray();
Console.WriteLine($"Found {persons.Length} people. They are: ");

// print them
foreach (var person in persons) 
    Console.WriteLine($"{person.FullName}, born on {person.DateOfBirth}, age {person.Age}.");

internal class Person
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

    public string FullName
        => $"{FirstName} {LastName}";
    
    public DateOnly DateOfBirth { get; init; }

    public int Age
        => DateTime.Today.Year - DateOfBirth.Year;
}

