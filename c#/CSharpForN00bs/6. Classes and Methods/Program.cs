//
// Classes, Properties, Constructors, Methods, Polymorphism, Overrides & Interfaces
// 

var person = new Person
{
    FirstName = "Charles",
    LastName = "Dickens",
    DateOfBirth = new DateOnly(1982, 2, 7)
};

// person.DateOfBirth = new DateOnly(2000, 04, 1); --> Error because 'init'

Console.WriteLine(person.FullName);
Console.WriteLine(person.DateOfBirth);

var person1a = new Person();
var person1b = new Person("Charles", "Dickens", new DateOnly(1982, 2, 7));

// create person with "wrong" dob
var person2 = new Person2("Charles", "Dickens", DateOnly.MinValue);

// this should fail
var success = person2.SetDateOfBirth(new DateOnly(2030, 1, 1));
Console.WriteLine(success ? "Successfully set DOB" : "Setting DOB failed");

// this should succeed
success = person2.SetDateOfBirth(new DateOnly(2000, 1, 1));
Console.WriteLine(success ? "Successfully set DOB" : "Setting DOB failed");

// confirm
Console.WriteLine(person.DateOfBirth);

// var animal = new Animal() -> Error because "abstract" class
var dog = new Dog { Name = "Lassie" };
dog.SayYourName();
dog.MakeNoise();
var cat = new Cat { Name = "Salem" };
cat.SayYourName();
cat.MakeNoise();

internal class Person
{
    public string FirstName { get; set; } // FistName, LastName, DateOfBirth are properties on this class
    public string LastName { get; set; } // The get and set methods define how the data can be read or modified.
    public string FullName => $"{FirstName} {LastName}";
    public DateOnly DateOfBirth { get; init; } // the init prevents us from changing the data after the initial value has been set.

    
    // Constructors = One potential issue with our code is that it's possible to create a person without setting any of the property values.
    // We have a "person" but without a name or date of birth.

    // Empty constructor
    public Person()
    {
        
    }
    
    // Mandatory parameters can be added to the parentheses
    public Person(string firstName, string lastName, DateOnly dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }
}

internal class Person2
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName}";
    public DateOnly DateOfBirth { get; private set; }

    
    public Person2()
    {
        
    }
    
    public Person2(string firstName, string lastName, DateOnly dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }
    
    // Method or function
    public bool SetDateOfBirth(DateOnly dob)
    {
        if (dob > DateOnly.FromDateTime(DateTime.UtcNow))
            return false;

        DateOfBirth = dob;
        return true;
    }
}

//
// Polymorphism is a trait of object oriented programming which makes them very versatile by allowing classes to become related by inheritance.
// In this example, I have an Animal class which has a single property, Name; and two further classes, Dog and Cat which inherit from Animal (declared using :).
//
internal abstract class Animal
{
    public string Name { get; set; }

    public void SayYourName()
    {
        Console.WriteLine($"My name is {Name}");
    }

    public abstract void MakeNoise();
}

internal class Dog : Animal
{
    public override void MakeNoise() // override -> create own function
    {
        Console.WriteLine("Woof");
    }
}

internal class Cat : Animal
{
    public override void MakeNoise() // override -> create own function
    {
        Console.WriteLine("Meow");
    }
}

//
// An interface is another form of abstraction - it's like an abstract class, but can only contain methods and properties.
// You cannot define methods that also have implementations.
// 
// The naming convention for an interface is to have it begin with an "I".
// 

internal interface IAnimal
{
    string Name { get; }
    void MakeNoise();
}

public class Dog2 : IAnimal
{
    public string Name { get; }

    public Dog2(string name)
    {
        Name = name;
    }

    public void MakeNoise()
    {
        Console.WriteLine($"Woof, my name is {Name}");
    }
}