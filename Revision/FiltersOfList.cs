namespace Revision;

public class FiltersOfList
{
    public static bool CheckOdd(int number)
    {
        return number % 2 != 0;
    }

    public static bool CheckEven(int number)
    {
        return number % 2 == 0;
    }

    public static bool CheckLengthMoreThanFour(string str)
    {
        return str?.Length > 4;
    }
}