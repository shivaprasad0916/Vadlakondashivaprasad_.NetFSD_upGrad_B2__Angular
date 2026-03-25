using System;
using System.Collections.Generic;
using System.Text;

public class PriceCalculator
{
    private IDiscountStrategy _discountStrategy;

    public PriceCalculator(IDiscountStrategy strategy)
    {
        _discountStrategy = strategy;
    }

    public double CalculateFinalPrice(double originalPrice)
    {
        return _discountStrategy.ApplyDiscount(originalPrice);
    }
}
