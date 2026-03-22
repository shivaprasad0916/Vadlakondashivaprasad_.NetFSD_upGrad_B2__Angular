using System;
using System.IO;

class DriveInFo
{
    static void Main()
    {
        try
        {
            // Retrieve all system drives
            DriveInfo[] drives = DriveInfo.GetDrives();

            Console.WriteLine("--- System Drive Information ---\n");

            foreach (DriveInfo drive in drives)
            {
                // Ensure the drive is ready before accessing properties
                if (drive.IsReady)
                {
                    string name = drive.Name;
                    string type = drive.DriveType.ToString();
                    long totalSize = drive.TotalSize;
                    long freeSpace = drive.TotalFreeSpace;

                    double freePercent = ((double)freeSpace / totalSize) * 100;

                    Console.WriteLine($"Drive: {name}");
                    Console.WriteLine($"Type: {type}");
                    Console.WriteLine($"Total Size: {FormatBytes(totalSize)}");
                    Console.WriteLine($"Free Space: {FormatBytes(freeSpace)} ({freePercent:F2}%)");

                    // Check if free space is below 15%
                    if (freePercent < 15)
                    {
                        Console.WriteLine("⚠ WARNING: Low disk space!");
                    }

                    Console.WriteLine(new string('-', 40));
                }
                else
                {
                    Console.WriteLine($"Drive: {drive.Name} is not ready.");
                    Console.WriteLine(new string('-', 40));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    // Helper method to format bytes to readable units
    static string FormatBytes(long bytes)
    {
        string[] sizes = { "B", "KB", "MB", "GB", "TB" };
        double len = bytes;
        int order = 0;
        while (len >= 1024 && order < sizes.Length - 1)
        {
            order++;
            len /= 1024;
        }
        return $"{len:F2} {sizes[order]}";
    }
}