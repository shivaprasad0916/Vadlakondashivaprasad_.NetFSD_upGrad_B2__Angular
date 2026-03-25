using System;
using System.Collections.Generic;
using System.Text;


class Program2
{
    static void Main()
    {
        double originalPrice = 1000.00;

        PriceCalculator regular = new PriceCalculator(new RegularDiscount());
        PriceCalculator premium = new PriceCalculator(new PremiumDiscount());
        PriceCalculator vip = new PriceCalculator(new VIPDiscount());

        Console.WriteLine($"Original Price : ₹{originalPrice}");
        Console.WriteLine($"Regular Discount Price : ₹{regular.CalculateFinalPrice(originalPrice)}");
        Console.WriteLine($"Premium Discount Price : ₹{premium.CalculateFinalPrice(originalPrice)}");
        Console.WriteLine($"VIP Discount Price     : ₹{vip.CalculateFinalPrice(originalPrice)}");
    }
}
