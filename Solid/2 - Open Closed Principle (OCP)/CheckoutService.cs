namespace Solid._2___Open_Closed_Principle__OCP_;

public class CheckoutService
{
    private readonly IDiscountStrategy _discountStrategy;

    public CheckoutService(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public decimal CalculateTotal(decimal total)
    {
        return _discountStrategy.ApplyDiscount(total);
    }
}