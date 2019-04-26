using System;
using System.Collections.Generic;

namespace SalesTax
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Product("Book name", 5, false, ItemTypes.Book);
            var other = new Product("Other Things", 15, false, ItemTypes.Others);
            var medicine = new Product("Medicine", 50, true, ItemTypes.Medical);

            var shoppingItems = new List<ShoppingItem>()
            {
                new ShoppingItem(book, 2),
                new ShoppingItem(other, 1),
                new ShoppingItem(medicine, 1)
            };
            var taxProcesssor = new TaxProcessor();
            var process = new BillProcessor(taxProcesssor);
            var receipt = process.ProcessCart(shoppingItems);
            receipt.PrintBill();

            Console.ReadLine();

        }
    }
}
