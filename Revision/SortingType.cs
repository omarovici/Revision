namespace Revision;

public class SortingType
{
    public static bool SortAsc(int a, int b)
    {
        return a > b;
    }

    public static bool SortDesc(int a, int b)
    {
        return a < b;
    }
    public static bool SortAsc(string a, string b)
    {
        return a?.Length > b?.Length;
    }

    public static bool SortDesc(string a, string b)
    {
        return a?.Length < b?.Length;
    } 
}