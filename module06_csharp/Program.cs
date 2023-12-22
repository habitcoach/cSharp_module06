using System.IO;
using System.Security.AccessControl;
using System.Text;


/*
 * File
 ReadAllText - read all text
ReadALlLine - array of text
WriteAllText- write text by deleting previous
AppendAllText - Just append the text
 File copy
File Delete
 
 */


namespace DiaryApp
{
    class Program
    {

        static string diaryFilePath = @"D:\Test\Diary.txt";
        static string diaryFilePathCopied = @"D:\Test\Diary02.txt";


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to My Diary!");

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Write a new diary entry");
                Console.WriteLine("2. View previous diary entries");
                Console.WriteLine("3. Copy diary");
                Console.WriteLine("4. Delete diary");
                Console.WriteLine("5. Exit");

                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        WriteDiaryEntry();
                        break;
                    case "2":
                        ViewDiaryEntries();
                        break;
                    case "3":
                        CopyDiaryEntry();
                        
                        break;
                    case "4":
                        DeleteDiaryEntry();
                        
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }
            }
        }


        static void CopyDiaryEntry() {

            try
            {

                Console.WriteLine("Copying the file to new location");

                File.Copy(diaryFilePath, diaryFilePathCopied);
            }
            catch(Exception ex) {

                Console.WriteLine("An error occurred: " + ex.Message);
            }
              
        }

        static void DeleteDiaryEntry()
        {
            try
            {
                if (File.Exists(diaryFilePathCopied))
                {
                    Console.WriteLine("File deleted successfully!!!");
                    File.Delete(diaryFilePathCopied);
                }
                else { 
                throw new FileNotFoundException("file is not there");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

        }

        static void WriteDiaryEntry()
        {
            Console.WriteLine("\nEnter your diary entry:");
            string entry = Console.ReadLine();

            try
            {
                //make it to writealltext
                File.AppendAllText(diaryFilePath, $"{DateTime.Now}: {entry}\n");
                Console.WriteLine("Diary entry saved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static void ViewDiaryEntries()
        {
            try
            {
                if (File.Exists(diaryFilePath))
                {
                    string[] entries = File.ReadAllLines(diaryFilePath);
                    //Read it as single strnig using ReadAllText
                    //string entries02 = File.ReadAllText(diaryFilePath);
                    //Console.WriteLine("***************" + entries02);
                    if (entries.Length > 0)
                    {
                        Console.WriteLine("\nPrevious diary entries:");
                        foreach (string entry in entries)
                        {
                            Console.WriteLine(entry);
                        }
                    }
                   
                    else
                    {
                        Console.WriteLine("\nNo diary entries found.");
                    }
                }
                else
                {
                    Console.WriteLine("\nNo diary entries found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}

    