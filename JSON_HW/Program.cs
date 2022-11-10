using System.Text.Json;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;


Deserialization();
Serialization();


static void Deserialization()
{
    Console.OutputEncoding = Encoding.UTF8; // Output Ukrainian words
    string path = @"E:\University\RiderProjects\JSON_HW\JSON_HW\books.json";
    string jsonString = File.ReadAllText(path);
    var books = JsonSerializer.Deserialize<List<Books>>(jsonString);
    Console.WriteLine("\n");
    foreach (var book in books)
    {
        Console.WriteLine($"PublishingId: {book?.PublishingHouseId}");
        Console.WriteLine($"Title: {book.Title}");
        Console.WriteLine(
            $"PublishingHouse:" +
            $"\n\tID: {book?.PublishingHouse.Id}," +
            $"\n\tName: {book?.PublishingHouse.Name}," +
            $"\n\tAdress: {book?.PublishingHouse.Adress} " +
            '\n');

    }
}

static void Serialization()
{
    var book_info = new PublishingHouseInfo(1, "Oracle", "Adress 200");
    var book_1 = new Books(10, "NodeJs_In_Action", book_info);
    var options = new JsonSerializerOptions
    {
        WriteIndented = true,
        IncludeFields = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
    };
    Console.WriteLine(JsonSerializer.Serialize(book_1,options));
    string path = @"E:\University\RiderProjects\JSON_HW\JSON_HW\JSON_HW.json";
    File.WriteAllText(path,JsonSerializer.Serialize(book_1));
}
public class Books
{
    //[JsonIgnore]                   // Task_2)Remove "//" To Ignore PublishingHouseId
    public int PublishingHouseId { get; set; }
    //[JsonPropertyName("Name")]     // Task_3)Remove "//" to replace "Title" with "Name"
    public string Title { get; set; }
    public PublishingHouseInfo PublishingHouse { get; set; }

    public Books()
    {
        
    }
    public Books(int PHID, string title, PublishingHouseInfo publishingHouseInfo)
    {
        PublishingHouseId = PHID;
        Title = title;
        PublishingHouse = publishingHouseInfo;

    }
    
}
public class PublishingHouseInfo
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Adress { get; set; }

    public PublishingHouseInfo()
    {
        
    }
    public PublishingHouseInfo(int id, string name, string adress)
    {
        Id = id;
        Name = name;
        Adress = adress;
    }
}