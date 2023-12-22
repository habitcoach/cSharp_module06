




//// Stream write

//string message = "This is a very important message!";

//FileStream output = new FileStream(@"D:\Test\Text01.txt", FileMode.OpenOrCreate);

//StreamWriter writer = new StreamWriter(output);

//writer.Write(message);

//writer.Close();

//output.Close();

//Console.WriteLine("Message written to the file");



////Stream read

//string filePath = @"D:\Test\Text01.txt";

//FileStream input = new FileStream(filePath, FileMode.Open);

//StreamReader reader = new StreamReader(input);

//string text = "";

//while (reader.Peek() != -1)
//{

//    text += (char)reader.Read();
//}

//reader.Close();

//input.Close();

//Console.WriteLine(text);

//Use stream to read the image

//image read
byte[] imageData;
    using (FileStream input02 = new FileStream("D:\\image.jpg", FileMode.Open))
{
    // Create a buffer to hold the image data
    imageData = new byte[input02.Length];

    // Read the image data into the buffer
    input02.Read(imageData, 0, imageData.Length);

    // Process the image data as needed
    // ...

    Console.WriteLine("Image read successfully");
    foreach (byte b in imageData) { 
    
        Console.Write(b);

    }

   
}
//image write
using (FileStream imageStream = new FileStream("D:\\imageNew.jpg", FileMode.Create))
{
    // Get or generate image data
    byte[] imageData02 = imageData;

    // Write the image data to the file
    imageStream.Write(imageData02, 0, imageData02.Length);

    Console.WriteLine("Image written successfully");
}