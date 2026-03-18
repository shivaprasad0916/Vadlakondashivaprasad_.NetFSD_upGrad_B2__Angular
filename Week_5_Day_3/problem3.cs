using LinqCodeTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Day_3
{
    internal class problem3
    {
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();
            var result = products.OrderBy(orA => orA.ProCode);

            foreach(var item in result)
            {
                Console.WriteLine($"{item.ProCode}\t{item.ProName}\t{item.ProCategory}\t{item.ProMrp}");
            }
            Console.ReadLine();
        }
    }
}
