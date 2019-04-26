namespace SalesTax
{
    public interface ITaxProcessor
    {
        decimal ComputeTotalTax(IProduct product);
    }
}