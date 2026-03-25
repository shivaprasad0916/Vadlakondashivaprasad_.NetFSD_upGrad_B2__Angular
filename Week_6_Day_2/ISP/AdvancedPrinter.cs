using System;
using System.Collections.Generic;
using System.Text;

// AdvancedPrinter implements all interfaces
public class AdvancedPrinter : IPrinter, IScanner, IFax
{
    public void Print(string document)
    {
        Console.WriteLine($"[AdvancedPrinter] Printing: {document}");
    }

    public void Scan(string document)
    {
        Console.WriteLine($"[AdvancedPrinter] Scanning: {document}");
    }

    public void Fax(string document)
    {
        Console.WriteLine($"[AdvancedPrinter] Faxing: {document}");
    }
}
