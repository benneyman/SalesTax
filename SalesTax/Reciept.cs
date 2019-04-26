using System;
using System.Collections.Generic;

namespace SalesTax
{
    public class Reciept
    {
        public Reciept(List<BilledShopppingItem> processedShoppingCart, decimal totalBillAmount, decimal totalSalesTax)
        {
            ProcessedShoppingCart = processedShoppingCart;
            TotalBillAmount = totalBillAmount;
            TotalSalesTax = totalSalesTax;
        }

        public void PrintBill()
        {
            foreach (var processedItem in ProcessedShoppingCart)
            {
                Console.WriteLine($"{processedItem.ShoppingItem.Product.Name} { processedItem.TotalPrice }");
            }
            Console.WriteLine($"Sales Taxes {TotalSalesTax}");
            Console.WriteLine($"Total {TotalBillAmount}");
        }
        public List<BilledShopppingItem> ProcessedShoppingCart { get; }
        public decimal TotalBillAmount { get; }
        public decimal TotalSalesTax { get; }
    }
}
