using System;
using System.Collections.Generic;
using System.Text;


class Program4
{
    static void Main()
    {
        Console.WriteLine("=== Basic Printer ===");
        IPrinter basic = new BasicPrinter();
        basic.Print("Report.pdf");

        Console.WriteLine("\n=== Advanced Printer ===");
        AdvancedPrinter advanced = new AdvancedPrinter();
        advanced.Print("Invoice.pdf");
        advanced.Scan("Contract.pdf");
        advanced.Fax("Agreement.pdf");
    }
}