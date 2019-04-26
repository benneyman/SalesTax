namespace SalesTax
{
    public class BilledShopppingItem
    {
        public BilledShopppingItem(ShoppingItem shoppingItem, decimal tax, decimal totalPrice)
        {
            ShoppingItem = shoppingItem;
            Tax = tax;
            TotalPrice = totalPrice;
        }

        public ShoppingItem ShoppingItem { get; }
        public decimal Tax { get; }
        public decimal TotalPrice { get; }
    }
}
