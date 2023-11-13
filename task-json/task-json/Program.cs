using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Reflection.Metadata.BlobBuilder;

var jsonFilePath = @"C:\\Users\\KateO\\OneDrive\\Рабочий стол\\task-json\\task-json\\Books.json";

var jsonContent = File.ReadAllText(jsonFilePath);

Console.WriteLine(jsonContent);

List<Book> books = JsonSerializer.Deserialize<List<Book>>(jsonContent);

foreach (var book in books)
{
    Console.WriteLine("Title: " + book.Title);
    Console.WriteLine("Publishing House ID: " + book.PublishingHouse.Id);
    Console.WriteLine("Publishing House: " + book.PublishingHouse.Name);
    Console.WriteLine("Address: " + book.PublishingHouse.Adress);
    Console.WriteLine();
}

public class Book
{
    [JsonIgnore]
    public int PublishingHouseId { get; set; }

    [JsonPropertyName("Name")]
    public string Title { get; set; }
    public PublishingHouse PublishingHouse { get; set; }
}

public class PublishingHouse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Adress { get; set; }
}