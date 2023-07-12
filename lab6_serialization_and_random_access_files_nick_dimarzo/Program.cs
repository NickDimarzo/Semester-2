using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Event
{
    public int EventNumber { get; set; }
    public string Location { get; set; }

    public Event(int eventNumber, string location)
    {
        this.EventNumber = eventNumber;
        this.Location = location;
    }
}

class Program
{
    static void Main()
    {
        // Step 2: Create an object and assign values
        Event myEvent = new Event(1, "Calgary")

        // Step 3: Serialize the object to a file
        SerializeObject(myEvent, "event.txt");

        // Step 4: Deserialize the object from the file and display values
        Event deserializedEvent = DeserializeObject("event.txt");
        Console.WriteLine(deserializedEvent.EventNumber);
        Console.WriteLine(deserializedEvent.Location);

        // Step 5: Write and read from file using StreamWriter and Seek Method
        ReadFromFile("event.txt");

        Console.ReadLine();
    }

    // serialize an object to a file
    static void SerializeObject(Event obj, string fileName)
    {
        FileStream fileStream = new FileStream(fileName, FileMode.Create);
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(fileStream, obj);
        fileStream.Close();
    }

    // deserialize an object from a file
    static Event DeserializeObject(string fileName)
    {
        FileStream fileStream = new FileStream(fileName, FileMode.Open);
        BinaryFormatter formatter = new BinaryFormatter();
        Event obj = (Event)formatter.Deserialize(fileStream);
        fileStream.Close();
        return obj;
    }

    // write and read from file using StreamWriter and Seek Method
    static void ReadFromFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.Write("Hackathon");
        }

        using (StreamReader reader = new StreamReader(fileName))
        {
            string content = reader.ReadToEnd();
            Console.WriteLine("In Word: " + content);
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine("The First Character is: \"" + (char)reader.Read() + "\"");
            reader.BaseStream.Seek(-1, SeekOrigin.End);
            Console.WriteLine("The Middle Character is: \"" + (char)reader.Read() + "\"");
            reader.BaseStream.Seek(-2, SeekOrigin.End);
            Console.WriteLine("The Last Character is: \"" + (char)reader.Read() + "\"");
        }
    }
}
