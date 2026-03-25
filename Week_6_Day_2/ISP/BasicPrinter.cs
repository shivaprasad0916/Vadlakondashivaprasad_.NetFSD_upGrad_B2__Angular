using System;
using System.Collections.Generic;
using System.Text;

// BasicPrinter only implements what it needs
public class BasicPrinter : IPrinter
{
    public void Print(string document)
    {
        Console.WriteLine($"[BasicPrinter] Printing: {document}");
    }
}
