using System;
using System.Threading.Tasks;


internal class AsynchronousOrderProcessingSystem
{
    static async Task Main()
    {
        Console.WriteLine("Asyncronous Order Processing System is Started.");
        Console.WriteLine();
        await ProcessOrderAsync();
        Console.WriteLine("Order Processing is Completed Successfully");
        Console.ReadLine();
    }
    static async Task ProcessOrderAsync()
    {
        await verificationPaymentAsync();
        Console.WriteLine();
        await paymentInventoryAsync();
        Console.WriteLine();
        await confirmOrderAsync();
        Console.WriteLine();
    }
    static async Task verificationPaymentAsync()
    {
        Console.WriteLine("Payment is Processing.....");
        await Task.Delay(2000);
        Console.WriteLine("Payment Verified Successfully");
    }
    static async Task paymentInventoryAsync()
    {
        Console.WriteLine(" Checking Inventory.....");
        await Task.Delay(2000);
        Console.WriteLine("Inventory is Avaliable");
    }
    static async Task confirmOrderAsync()
    {
        Console.WriteLine("Order is Processing....");
        await Task.Delay(1000);
        Console.WriteLine("Order placed Successfully");
    }

}
