using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

public class Student
{
    [XmlAttribute]
    public string Name { get; set; }
    [XmlAttribute]
    public int Age { get; set; }

    [XmlIgnore]
    public string AdditionalProperty { get; set; }
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
            AdditionalProperty = "This won't be serialized or deserialized"
        };

        // Serialize the Student object to XML
        XmlSerializer serializer = new XmlSerializer(typeof(Student));
   
        using (StreamWriter writer = new StreamWriter(@"D:\Test\studentXML.txt"))
        {
          
          
            serializer.Serialize(writer,student);

          

        }
        Console.WriteLine("XML saved to file.");

        // Deserialize the XML back to a Student object
        using (StreamReader reader = new StreamReader(@"D:\Test\studentXML.txt"))
        {
            Student deserializedStudent = (Student)serializer.Deserialize(reader);

            // Display deserialized object's properties
            Console.WriteLine("\nDeserialized Student:");
            Console.WriteLine($"Name: {deserializedStudent.Name}");
            Console.WriteLine($"Age: {deserializedStudent.Age}");
            Console.WriteLine($"AdditionalProperty: {deserializedStudent.AdditionalProperty}");
        }
    }
}
