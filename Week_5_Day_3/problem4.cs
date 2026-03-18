using LinqCodeTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class problem4
{
    static void Main()
    {
        Product product = new Product();
        var products = product.GetProducts();
        var result = products.OrderBy(orA => orA.ProCategory);

        foreach (var item in result)
        {
            Console.WriteLine($"\t{item.ProName}\t{item.ProMrp}\t{item.ProCategory}");
        }
        Console.ReadLine();
    }
}
