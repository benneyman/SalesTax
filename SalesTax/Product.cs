namespace SalesTax
{
    public class Product : IProduct
    {
        public Product(string name, decimal price, bool isImport, ItemTypes  itemType)
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
}
