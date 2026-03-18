using LinqCodeTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Day_3
{
    internal class problem2
    {
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();
            var result = products.Where(pr => pr.ProCategory == "Grain").ToList();

            foreach (var p in products)
            {
                Console.WriteLine($"{p.ProCode}\t{p.ProName}\t{p.ProMrp}");
            }
            Console.ReadLine();
        }
    }
}
