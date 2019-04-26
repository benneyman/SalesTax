using System.Collections.Generic;

namespace SalesTax
{
    public class TaxProcessor : ITaxProcessor
    {
        List<IProductTax> SalesTaxes;
        public TaxProcessor()
        {
            SalesTaxes = new List<IProductTax>()
            {
                new SalesTax(),
                new ImportDuty()
            };
        }
        public decimal ComputeTotalTax(IProduct product)
        {
            decimal computedSalesTax = 0;
            foreach (var tax in SalesTaxes)
            {
                computedSalesTax += tax.Compute(product);
            }

            return computedSalesTax;
        }
    }
}
