var person = new Person(
    firstName: "Charles,
    lastName: "Dickens",
    dateOfBirth: new DateOnly(year:1812, month:2, day:7)
    );

internal class Person
{
    public Person(string firstName, string lastName, DateOnly dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }
}