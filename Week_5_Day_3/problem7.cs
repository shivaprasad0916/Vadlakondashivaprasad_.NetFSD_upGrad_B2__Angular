using LinqCodeTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class problem7
{
    static void Main()
    {
        Product product = new Product();
        var products = product.GetProducts();
        var result = products.GroupBy(Gr => Gr.ProCategory);

        foreach (var group in result)
        {
            Console.WriteLine($"Category Group: {group.Key}");
            foreach (var item in group)
            {
                Console.WriteLine($"{item.ProCode}\t{item.ProName}\t{item.ProMrp}\t{item.ProCategory}");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}