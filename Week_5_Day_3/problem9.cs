using LinqCodeTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class problem9
    {
    static void Main()
    {
        Product product = new Product();

        var products = product.GetProducts();
        var result = products.Where(w => w.ProCategory == "FMCG").OrderByDescending(or => or.ProMrp).FirstOrDefault();
        if(result != null)
        {
            Console.WriteLine($"{result.ProName}\t{result.ProCategory}\t{result.ProMrp}");
        }
    }
}

