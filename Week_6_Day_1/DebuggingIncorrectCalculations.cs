using System;
using System.Threading.Tasks;

class DiscountCalculator
{
    static void Main()
    {
        Console.WriteLine($"Discount Calculator");

        Console.Write("Enter the product Name: ");
        string Productname = Console.ReadLine();

        Console.Write("Enter the Price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Discount Percentage: ");
        double discount = Convert.ToDouble(Console.ReadLine());
        
        //Validation
        if(price < 0)
        {
            Console.WriteLine($"\n[ERROR] Price Cannot be Negative");
            Console.ReadKey();
            return;
        }
        if(discount < 0 || discount > 100)
        {
            Console.WriteLine($"\n[ERROR] Discount must be in 0 to 100");
            Console.ReadKey();
            return;
        }

        //discount
        double FinalDiscount = price * discount / 100;

        //Final Price
        double FinalPrice = price - FinalDiscount;

        Console.WriteLine($"Product Name: {Productname} \nOriginal Price: Rs.{price} \nDiscount Percentage: {discount}% \nDiscount Amount: Rs.{FinalDiscount} \nFinal Price: Rs.{FinalPrice}");
        Console.WriteLine("Press any Key to Exit....");
        Console.ReadKey();
    }
}
