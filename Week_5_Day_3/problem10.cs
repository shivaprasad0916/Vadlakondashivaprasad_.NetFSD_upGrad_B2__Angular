using LinqCodeTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class problem10
    {
    static void Main()
    {
        Product product = new Product();
        var products = product.GetProducts();
        var count = products.Count();
        Console.WriteLine($"Total Number of Products are: {count}");
    }
}

