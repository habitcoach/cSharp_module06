using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Student object
        Student student = new Student
        {
            Name = "John Doe",
            Age = 20
        };

        // Serialize the Student object to binary
        BinaryFormatter formatter = new BinaryFormatter();

        //using (FileStream fileStream = new FileStream(@"D:\Test\studentBinary.txt", FileMode.Create))
        //{
        //    formatter.Serialize(fileStream, student);
        //    Console.WriteLine("Object serialized to binary.");
        //}

        // Deserialize the binary back to a Student object
        using (FileStream fileStream = new FileStream(@"D:\Test\studentBinary.txt", FileMode.Open))
        {
            Student deserializedStudent = (Student)formatter.Deserialize(fileStream);

            // Display deserialized object's properties
            Console.WriteLine("\nDeserialized Student:");
            Console.WriteLine($"Name: {deserializedStudent.Name}");
            Console.WriteLine($"Age: {deserializedStudent.Age}");
        }
    }
}
