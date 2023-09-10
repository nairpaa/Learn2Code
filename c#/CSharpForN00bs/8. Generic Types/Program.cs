using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

var person = new Person
{
    FirstName = "Rasta",
    LastName = "Mouse"
};

var json = SerializePerson(person);
Console.WriteLine(Encoding.Default.GetString(json));

byte[] SerializePerson<T>(T obj)
{
    using var ms = new MemoryStream();
    JsonSerializer.Serialize(ms, obj);

    return ms.ToArray();
}

T DeserializationPerson<T>(byte[] json)
{
    using var ms = new MemoryStream(json);
    return JsonSerializer.Deserialize<T>(ms);
}

[Serializable]
internal class Person
{
    [JsonPropertyName("first_name")] public string FirstName { get; set; }
    [JsonPropertyName("last_name")] public string LastName { get; set; }
}