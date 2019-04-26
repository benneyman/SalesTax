namespace SalesTax
{
    public class ShoppingItem
    {
        public ShoppingItem(IProduct product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public IProduct Product { get; }
        public int Quantity { get; }
    }
}
