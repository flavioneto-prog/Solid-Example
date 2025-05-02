namespace Solid._2___Open_Closed_Principle__OCP_;

public class PercentageDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal total) => total * 0.9M;
}