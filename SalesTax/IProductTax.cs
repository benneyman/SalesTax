namespace SalesTax
{
    public interface IProductTax
    {
        bool IsApplicableTo(IProduct product);
        decimal Compute(IProduct product);
    }
}
