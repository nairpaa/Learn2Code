var (firstName, lastName, status) = ("Charles", "Dickens", Status.Dead);

switch (status)
{
    case Status.Dead:
        Console.WriteLine($"{firstName} {lastName} is dead.");
        break;
    case Status.Alive:
        Console.WriteLine($"{firstName} {lastName} is alive.");
        break;
    default:
        throw new ArgumentOutOfRangeException();
}

internal enum Status
{
    Dead,
    Alive
}