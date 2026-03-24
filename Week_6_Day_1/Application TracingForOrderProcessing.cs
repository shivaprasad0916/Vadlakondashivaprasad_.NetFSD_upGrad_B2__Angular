using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

internal class Application_TracingForOrderProcessing
{
    static void Main()
    {
        Trace.Listeners.Clear();
        Trace.Listeners.Add(new TextWriterTraceListener("orderLog.txt"));
        Trace.AutoFlush = true;

        Console.WriteLine("Order Processing Started...");

        try
        {
            processOrder();
        }
        catch(Exception ex)
        {
            Trace.WriteLine($"[ERROR] {ex.Message}");
            Console.WriteLine("Order Log Failed, Check the Logs file for Details.");
        }
        Console.WriteLine("\nOrder Processing Completed, Press any Key to Exit..");
        Console.ReadLine();
    }
    static void processOrder()
    {
        validateOrder();
        processPayment();
        updateInventory();
        generateInvoice();
    }
    static void validateOrder()
    {
        Trace.WriteLine("STEP-1 Order Validation Started");
        Console.WriteLine("Validating Order....");
        bool isValid = true;
        if (!isValid)
        {
            throw new Exception("Order Validation Failed..");
        }
        Trace.WriteLine("STEP-1 Order Validation Completed");
    }
    static void processPayment()
    {
        Trace.WriteLine("STEP-2 Order Payment Started");
        Trace.
        Console.WriteLine("Payment in Processing....");
        bool isPayment = true;
        if (!isPayment)
        {
            throw new Exception("Payment Failed..");
        }
        Trace.WriteLine("STEP-2 Order Payment Completed");
    }
    static void updateInventory()
    {
        Trace.WriteLine("STEP-3 Inventory Uptation Started");
        Console.WriteLine("Inventory Updating....");
        bool isInventory = true;
        if (!isInventory)
        {
            throw new Exception("Inventory Updation Failed");
        }
        Trace.WriteLine("STEP-3 Inventory Updation Completed");
    }
    static void generateInvoice()
    {
        Trace.WriteLine("STEP-4 Generation of Invoice Started");
        Console.WriteLine("Generating Invoice....");
        bool isGenerated = true;
        if (!isGenerated)
        {
            throw new Exception("Invoice Generation Failed");
        }
        Trace.WriteLine("STEP-4 Generation of Invoice Completed");
    }
}
