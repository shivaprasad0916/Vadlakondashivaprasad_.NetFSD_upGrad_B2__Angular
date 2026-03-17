using System;

namespace Encapsulation
{
    internal class VehicleRentalSystem
    {
        class Vehicle
        {
            public string Brand { get; set; } = "";

            private double RentalRatePerDay { get; set; }

            public double RentalRate
            {
                get { return RentalRatePerDay; }
                set
                {
                    if (value > 0)
                    {
                        RentalRatePerDay = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Rental Rate");
                    }
                }
            }

            public Vehicle(string brand, double rate)
            {
                Brand = brand;
                RentalRate = rate;
            }

            public virtual double CalculateRental(double days)
            {
                if (days <= 0)
                {
                    Console.WriteLine("Invalid Days!");
                    return 0;
                }

                return RentalRate * days;
            }
        }

        // Car derived class
        class Car : Vehicle
        {
            public Car(string brand, double rate) : base(brand, rate) { }

            public override double CalculateRental(double days)
            {
                double total = base.CalculateRental(days);
                return total + 500; // Insurance charges
            }
        }

        // Bike derived class
        class Bike : Vehicle
        {
            public Bike(string brand, double rate) : base(brand, rate) { }

            public override double CalculateRental(double days)
            {
                double total = base.CalculateRental(days);
                double discount = total * 0.05;
                return total - discount;
            }
        }

        static void Main()
        {
            Console.Write("Enter the Car Brand Name: ");
            string car = Console.ReadLine();

            Console.Write("Enter the Rent Per Day: ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter How Many Days Needed: ");
            double d = Convert.ToDouble(Console.ReadLine());

            Vehicle v = new Car(car, p);

            double result = v.CalculateRental(d);

            Console.WriteLine($"Total Rent = {result}");
        }
    }
}