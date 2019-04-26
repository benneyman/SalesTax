namespace SalesTax
{
    public interface IProduct
    {
        string Name { get; }
        decimal Price { get; }
        bool IsImport { get; }
        ItemTypes ItemType { get; }
    }
}
