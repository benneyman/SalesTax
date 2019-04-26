using System.Collections.Generic;

namespace SalesTax
{
    public class BillProcessor
    {
        public BillProcessor(ITaxProcessor salesTaxProcess)
        {
            SalesTaxProcessor = salesTaxProcess;
        }

        public Reciept ProcessCart(List<ShoppingItem> shoppingCart)
        {
            var billedShopppingItems = new List<BilledShopppingItem>();
            decimal totalTaxForCart = 0;
            decimal totalBilledAmount = 0;
            foreach (var shoppingItem in shoppingCart)
            {
                decimal individualTax = SalesTaxProcessor.ComputeTotalTax(shoppingItem.Product);
                decimal taxForAllProducts = individualTax * shoppingItem.Quantity;

                decimal totalPrice = shoppingItem.Product.Price * shoppingItem.Quantity;
                decimal totalPriceAfterTax = totalPrice + taxForAllProducts;

                billedShopppingItems.Add(new BilledShopppingItem(shoppingItem, taxForAllProducts,
                    totalPriceAfterTax));

                totalTaxForCart += taxForAllProducts;
                totalBilledAmount += totalPriceAfterTax;
            }
            return new Reciept(billedShopppingItems, totalBilledAmount, totalTaxForCart);
        }

        public ITaxProcessor SalesTaxProcessor { get; }
    }
}
