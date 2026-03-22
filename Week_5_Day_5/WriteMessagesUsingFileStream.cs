using System;
using System.IO;
using System.Text;


internal class WriteMessagesUsingFileStream
{
    static void Main()
    {
        string FilePath = "FileTest.txt";

        string message = GetUserMessage();
        WriteToFile(FilePath, message);
        ShowConformation();
    }
    static string GetUserMessage()
    {
        Console.Write("Enter the message: ");
        return Console.ReadLine();
    }

    static void WriteToFile(string FilePath, string message)
    {
        using (StreamWriter sw = new StreamWriter("FileTest.txt", true))
        {
            sw.WriteLine(message);
        }
    }
    static void ShowConformation()
    {
        Console.WriteLine("Message successfully written to file.");
    }
}


