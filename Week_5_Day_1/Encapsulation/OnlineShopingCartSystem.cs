using System;


namespace Encapsulation
{
    internal class OnlineShopingCartSystem
    {
        class Product
        {
            private string Name { get; set; }    
            private double Price { get; set; }

            //properties
            public string name
            {
                get
                {
                    return Name;
                }
                set
                {
                    Name = value;
                }
            }

            public double price
            {
                get
                {
                    return Price;
                }
                set
                {
                    if(value < 0)
                    {
                        Console.WriteLine("Invalid Price!"); ;
                    }
                    else
                    {
                        Price = value;
                    }
                }
            }
            //virtual
            public virtual double CalculateDiscount()
            {
                return Price;
            }
        }
        //Inheritance
        class Electronics : Product
        {
            public override double CalculateDiscount()
            {
                return price - (price * 0.05);
            }
        }
        class Clothing : Product
        {
            public override double CalculateDiscount()
            {
                return price - (price * 0.15);
            }

        }
        static void Main()
        {
            //object creatation
            Product product = new Electronics();
            Console.Write("Enter the price: ");
            double P =Convert.ToDouble(Console.ReadLine());

            product.name = "Electronics";
            product.price = P;
            double FinalPrice = product.CalculateDiscount();

            Console.WriteLine($"Final Price Of Electronics AFter 5% Discount = {FinalPrice}");

            Product product1 = new Clothing();
            product1.name = "Clothing";
            product1.price = P;
            double FinalPrice1  = product1.CalculateDiscount();

            Console.WriteLine($"Final Price Of Cloths After 15% Discount = {FinalPrice1}");
        }
    }
}
