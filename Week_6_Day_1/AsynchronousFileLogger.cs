using System;
using System.Threading.Tasks;


class AsynchronousFileLogger
{
    static async Task WriteLogAsync(string message)
    {
        Console.WriteLine($"String to write Log:{message}");
        await Task.Delay(2000);
        Console.WriteLine($"Log Written: {message}");
    }
    static async Task Main()
    {
        Console.WriteLine("===Asynchronous File Logger Started....===");

        Task log1 = WriteLogAsync("User Logged In");
        Task log2 = WriteLogAsync("File Uploaded Succesfully");
        Task log3 = WriteLogAsync("DataBase Query EXecuted");
        Task log4 = WriteLogAsync("Email Sent");
        Task log5 = WriteLogAsync("Payment Completed Successfully");

        await Task.WhenAll(log1, log2, log3, log4, log5);
        Console.WriteLine("All Loggers Executed Successfully logging completed......");
    }
}

