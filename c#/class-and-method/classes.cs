var person = new Person()
{
    FirstName = "Charles",
    LastName = "Dickens",
    DateofBirth = new DateOnly(year: 1812, month: 2, 7)
};

Console.WriteLine(person.FullName);

internal class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName}";
    public DateOnly DateofBirth { get; init; } // "Init" prevents us from changing the data after the initial value has been set.
}