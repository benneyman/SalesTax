namespace SalesTax
{
    public class SalesTax : IProductTax
    {
        public decimal Compute(IProduct product)
        {
            if (IsApplicableTo(product))
                return product.Price * 0.1m;
            return 0m;
        }

        public bool IsApplicableTo(IProduct product)
        {
            return !product.ItemType.HasFlag(ItemTypes.SalesTaxEmptedItemTypes);
        }
    }
}

