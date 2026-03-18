using LinqCodeTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class problem11
{
    static void Main()
    {
        Product product = new Product();
        var products = product.GetProducts();
        var Maximum = products.Max(m => m.ProMrp);
        Console.WriteLine($"Maximum Price of the Product is: {Maximum}");

        var Minimum = products.Min(m => m.ProMrp);
        Console.WriteLine($"Minimum Price of the Product is: {Minimum}");
    }
}
