using LinqCodeTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class problem5
{
    static void Main()
    {
        Product product = new Product();
        var products = product.GetProducts();
        var result = products.OrderBy(orA => orA.ProMrp);

        foreach (var item in result)
        {
            Console.WriteLine($"\t{item.ProName}\t{item.ProMrp}\t{item.ProCategory}");
        }
        Console.ReadLine();
    }
}