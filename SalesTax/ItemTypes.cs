using System;

namespace SalesTax
{
    [Flags]
    public enum ItemTypes
    {
        None = 0,
        Book = 1 << 0,
        Food = 1 << 1,
        Medical = 1 << 2,
        Others = 1 << 3,
        SalesTaxEmptedItemTypes = Book | Food | Medical
    }
}

[Flags]
public enum ItemTypes
{
    None = 0,
    Book = 1 << 0,
    Food = 1 << 1,
    Medical = 1 << 2,
    Others = 1 << 3,
    SalesTaxEmptedItemTypes = Book | Food | Medical
}

public class Product : IProduct
{
    public Product(string name, decimal price, bool isImport, ItemTypes itemType)
    {
        Name = name;
        Price = price;
        IsImport = isImport;
        ItemType = itemType;
    }

    public string Name { get; }
    public decimal Price { get; }
    public bool IsImport { get; }
    public ItemTypes ItemType { get; }
}

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