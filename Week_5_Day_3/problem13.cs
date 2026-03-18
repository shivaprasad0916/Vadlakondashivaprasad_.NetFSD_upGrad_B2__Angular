using LinqCodeTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class product13
{
    static void Main()
    {
        Product product = new Product();
        var products = product.GetProducts();
        bool isAnyProductsAreBelow30 = products.Any(a => a.ProMrp < 30);
        Console.WriteLine(isAnyProductsAreBelow30 ? "Some Products are Below 30" : "No Products are Below 30");
    }
}
 