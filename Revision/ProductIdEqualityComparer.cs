using Revision.Data;

namespace Revision;

public class ProductIdEqualityComparer : IEqualityComparer<Product>
{
    public bool Equals(Product? x, Product? y)
    {
        if(x is null || y is null) return false;
        return x.ProductID == y.ProductID;
    }

    public int GetHashCode(Product obj)
    {
        return HashCode.Combine(obj.ProductID);
    }
}