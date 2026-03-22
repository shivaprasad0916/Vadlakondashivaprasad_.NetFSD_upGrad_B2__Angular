using System;
using System.Collections.Generic;
using System.Text;


internal class FilePropertiesDetails
{
    static void DisplayFileDetails(string path)
    {
        string[] files = Directory.GetFiles(path);
        int count = 0; 

        foreach (string file in files)
        {
            FileInfo info = new FileInfo(file);

            Console.WriteLine($"File Name: {info.Name}");
            Console.WriteLine($"File Size: {info.Length}");
            Console.WriteLine($"Created Date: {info.CreationTime}");
            Console.WriteLine("---------------");
            count++;
        }
        Console.WriteLine($"Total number of Files are: {count}");
    }

    static void Main()
    {
        Console.WriteLine("Enter the Path: ");
        string path = Console.ReadLine();

        if (Directory.Exists(path))
        {
            DisplayFileDetails(path);
        }
        else
        {
            Console.WriteLine("No File Path Found!...");
        }
    }
}
