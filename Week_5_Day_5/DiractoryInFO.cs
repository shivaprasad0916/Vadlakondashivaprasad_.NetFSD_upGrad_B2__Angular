using System;
using System.IO;

class DiractoryInFO
{
    static void Main()
    {
        try
        {
            // Accept root directory path from user
            Console.Write("Enter the root directory path: ");
            string rootPath = Console.ReadLine();

            // Check if the directory exists
            if (!Directory.Exists(rootPath))
            {
                Console.WriteLine("The specified directory does not exist.");
                return;
            }

            // Create DirectoryInfo object
            DirectoryInfo rootDir = new DirectoryInfo(rootPath);

            // Get all subdirectories
            DirectoryInfo[] subDirs = rootDir.GetDirectories();

            Console.WriteLine($"\nSubdirectories in '{rootPath}':");

            // Loop through each subdirectory
            foreach (DirectoryInfo dir in subDirs)
            {
                try
                {
                    // Count number of files in this directory
                    FileInfo[] files = dir.GetFiles();
                    Console.WriteLine($"Folder: {dir.Name} | Number of Files: {files.Length}");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine($"Folder: {dir.Name} | Access Denied");
                }
            }

            // Optional: Also display file count in the root directory itself
            FileInfo[] rootFiles = rootDir.GetFiles();
            Console.WriteLine($"\nRoot Folder: {rootDir.Name} | Number of Files: {rootFiles.Length}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}