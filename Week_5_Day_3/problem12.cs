using LinqCodeTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class product12
{
    static void Main()
    {
        Product product = new Product();
        var products = product.GetProducts();
        bool AllProductsAreBelow30 = products.All(a => a.ProMrp < 30);
        Console.WriteLine(AllProductsAreBelow30 ? "All Products are Below 30" : "All Products are Not Below 30");
    }
}
