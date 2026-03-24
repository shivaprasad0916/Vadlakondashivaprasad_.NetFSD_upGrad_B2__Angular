using System;
using System.Threading;
using System.Threading.Tasks;

class FinalcialReportCalculator
{
    //  Report Methods

    static void GenerateSalesReport()
    {
        Console.WriteLine("[Sales Report]     * Started...");
        Thread.Sleep(3000); // Simulates 3 seconds of processing
        Console.WriteLine("[Sales Report]      Completed!");
    }

    static void GenerateInventoryReport()
    {
        Console.WriteLine("[Inventory Report]   * Started...");
        Thread.Sleep(2000); // Simulates 2 seconds of processing
        Console.WriteLine("[Inventory Report]  Completed!");
    }

    static void GenerateCustomerReport()
    {
        Console.WriteLine("[Customer Report]   * Started...");
        Thread.Sleep(4000); // Simulates 4 seconds of processing
        Console.WriteLine("[Customer Report]   Completed!");
    }

    //  Entry Point

    static void Main()
    {
        Console.WriteLine("Financial Report Generator ");
        Console.WriteLine();
        Console.WriteLine("Launching all reports concurrently...");

        // Create tasks using Task.Run() — each runs on a thread-pool thread
        Task salesTask = Task.Run(() => GenerateSalesReport());
        Task inventoryTask = Task.Run(() => GenerateInventoryReport());
        Task customerTask = Task.Run(() => GenerateCustomerReport());

        // Block the main thread until ALL tasks finish
        Task.WaitAll(salesTask, inventoryTask, customerTask);

        Console.WriteLine();
        Console.WriteLine(" All reports have been generated successfully!");
        Console.WriteLine();
    }
}
