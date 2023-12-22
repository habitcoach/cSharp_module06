

using System.Diagnostics.CodeAnalysis;

string path = @"D:\Test\NewDir";

//Directory

//Directory.CreateDirectory(path);

//File.Create(@"D:\Test\NewDir\Text01.txt");
//File.Create(@"D:\Test\NewDir\Text02.txt");
//File.Create(@"D:\Test\NewDir\Text03.txt");

//Console.WriteLine($"Directory exist: {Directory.Exists(path) }");

//var AllFiles = Directory.GetFiles(@"D:\Test\NewDir");

//foreach (var file in AllFiles) {

//    Console.WriteLine(file);
//}

//DirectoryInfo dirInfo = new DirectoryInfo(path);

//var dirCreationTime = dirInfo.CreationTime;
//var dirFullName = dirInfo.FullName;
//var dirExtension = dirInfo.Extension;
//var dirRoot = dirInfo.Root;
//var dirLastAccess = dirInfo.LastAccessTime;
//var dirLastWriteTime = dirInfo.LastWriteTime;

//Console.WriteLine($"dir root: {dirRoot}");
//Console.WriteLine($"dir full name: {dirFullName}");
//Console.WriteLine($"dir extension: {dirExtension}");
//Console.WriteLine($"dir last acess time: {dirLastAccess}");
//Console.WriteLine($"dir last write time: {dirLastWriteTime}");

//path
var path02 = @"D:\Test\NewDir\Text01.txt";
bool hasExtension = Path.HasExtension( path02 );
string getExtension = Path.GetExtension( path02 );
string tempPath = Path.GetTempFileName();


Console.WriteLine($"File extension: {hasExtension}");
Console.WriteLine($"Get extension: {getExtension}");
Console.WriteLine($"Get extension: {tempPath}");




