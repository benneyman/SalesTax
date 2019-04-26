namespace SalesTax
{
    public class ImportDuty : IProductTax
    {
        public decimal Compute(IProduct product)
        {
            if (IsApplicableTo(product))
                return product.Price * 0.05m;
            return 0m;
        }

        public bool IsApplicableTo(IProduct product)
        {
            return product.IsImport;
        }
    }
}
