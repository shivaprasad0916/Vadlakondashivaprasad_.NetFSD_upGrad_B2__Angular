using System;
using System.Collections.Generic;
using System.Text;


public interface IDiscountStrategy
{
    double ApplyDiscount(double price);
}

// Concrete strategies
public class RegularDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double price)
    {
        return price * 0.95; 
    }
}

public class PremiumDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double price)
    {
        return price * 0.85; 
    }
}

public class VIPDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double price)
    {
        return price * 0.70; 
    }
}