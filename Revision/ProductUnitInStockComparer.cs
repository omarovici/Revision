using Revision.Data;

namespace Revision;

public class ProductUnitInStockComparer : IComparer<Product>
{
    public int Compare(Product? x, Product? y)
    {
        if (x is null)
        {
            if(y is null) return 0;
            return -1;
        }
        if (y is null) return 1;
        return x.UnitPrice.CompareTo(y.UnitPrice);
    }
}