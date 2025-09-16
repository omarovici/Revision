using Revision.Data;

namespace Revision;

public class StringEqualityComparer : IEqualityComparer<string>
{
    public bool Equals(string? x, string? y)
    {
        if (x is null || y is null) return false;
        return x.ToLower() == y.ToLower();
    }

    public int GetHashCode(string obj)
    {
        return HashCode.Combine(obj.ToLower().GetHashCode());
    }
}