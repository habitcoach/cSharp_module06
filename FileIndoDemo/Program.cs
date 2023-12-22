using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string sourceFilePath = @"D:\Test\source.txt";
        string destinationFilePath = @"D:\Test\destination.txt";

        // Create FileInfo objects
        FileInfo sourceFile = new FileInfo(sourceFilePath);
        FileInfo destinationFile = new FileInfo(destinationFilePath);

        #region Stream
        // Use FileInfo methods
        //FileStream sourceStream = sourceFile.OpenRead();
        //{

        //    Use sourceStream for reading...


        //    Example: Copy contents to destinationFile using OpenWrite and CopyTo
        //   FileStream destinationStream = destinationFile.OpenWrite();
        //    {
        //        sourceStream.CopyTo(destinationStream);
        //    }
        //}

        //OpenText example
        //using (StreamReader reader = sourceFile.OpenText())
        //{
        //    string line;
        //    while ((line = reader.ReadLine()) != null)
        //    {
        //        Console.WriteLine(line);
        //    }
        //}
        #endregion

        //FileInfo methods
       File.WriteAllText(sourceFilePath, "some value to show the size of the file",Encoding.UTF8);

        var fileSize = sourceFile.Length;
        var creationTime = sourceFile.CreationTime;
        var fileExtension = sourceFile.Extension;
        var lastModified = sourceFile.LastAccessTime;

        Console.WriteLine($"File size: {fileSize} byes");
        Console.WriteLine($"File creation time: {creationTime}");
        Console.WriteLine($"File extension: {fileExtension}");
        Console.WriteLine($"File last modified: {lastModified}");

        //MoveTO
        sourceFile.MoveTo(destinationFilePath,true);
        Console.WriteLine("File moved");

        
        if (destinationFile.Exists) {

            destinationFile.Delete();
        }


       
    }
}
