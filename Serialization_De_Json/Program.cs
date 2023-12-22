using System;
using System.IO;

using System.Xml;
using Newtonsoft.Json; // Make sure to add the Newtonsoft.Json NuGet package to your project

class Student
{

    public string Name { get; set; }
    public int Age { get; set; }

   [JsonIgnore]
    public int ImpProp { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Student object
        Student student = new Student
        {
            Name = "John Doe",
            Age = 20,
            ImpProp = 20
        };



        // Serialize the Student object to JSON
        string json = JsonConvert.SerializeObject(student, Newtonsoft.Json.Formatting.Indented);

        // Print JSON to console
        Console.WriteLine("Serialized JSON:");
        Console.WriteLine(json);

        // Save JSON to a text file on the D drive
        string filePath = @"D:\Test\student.txt";
        File.WriteAllText(filePath, json);
        Console.WriteLine("JSON saved to file.");

        // Read JSON from file and deserialize it
        string jsonFromFile = File.ReadAllText(filePath);

        Student deserializedStudent = JsonConvert.DeserializeObject<Student>(jsonFromFile);

        // Display deserialized object's properties
        Console.WriteLine("\nDeserialized Student:");
        Console.WriteLine($"Name: {deserializedStudent.Name}");
        Console.WriteLine($"Age: {deserializedStudent.Age}");
    }
}
