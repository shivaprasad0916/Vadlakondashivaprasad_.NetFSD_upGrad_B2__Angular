using System;
using System.Collections.Generic;
using System.Text;

// Small, focused interfaces
public interface IPrinter
{
    void Print(string document);
}

public interface IScanner
{
    void Scan(string document);
}

public interface IFax
{
    void Fax(string document);
}
