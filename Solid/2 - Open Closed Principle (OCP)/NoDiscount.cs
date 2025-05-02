namespace Solid._2___Open_Closed_Principle__OCP_;

public class NoDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal total) => total;
}