using System;

namespace Week_4_Day_4
{
    internal class E_CommerceCalculatorUsingOptionalParameters
    {
        class E_CommerceCalculator
        {
            public void CalculateTotalPrice(double price, double quantity, double discount = 0, double shipingPrice = 50)
            {
                double subTotal= price * quantity;
                discount = subTotal * (discount / 100);
                double finalAmount = subTotal - discount + shipingPrice;
                Console.WriteLine("---------Order Details---------");
                Console.WriteLine($"Sub Total: {subTotal} \nDiscount: {discount} \nFinal Amount: {finalAmount}");
            }
        }
        static void Main()
        {

            Console.Write("Enter product Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Quantity: ");  
            double quantity = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Discount Percentage (if any, else enter 0): ");
            double discount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Shipping Amount (if any, else enter 0): ");
            double shipingInput = Convert.ToDouble(Console.ReadLine());

            E_CommerceCalculator calculator = new E_CommerceCalculator();

            if (discount ==0 && shipingInput == 0)
            {
                calculator.CalculateTotalPrice(price, quantity);
            }
            else if(shipingInput == 0)
            {
                calculator.CalculateTotalPrice(price, quantity, discount);
            }
            else
            {
                calculator.CalculateTotalPrice(price, quantity, discount, shipingInput);
            }

        }
    }
}
