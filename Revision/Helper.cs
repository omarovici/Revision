namespace Revision;

public static class Helper<T>
{
    public static void Swap(ref T X, ref T Y)
    {
        T Temp = X;
        X = Y;
        Y = Temp;
    }

    public static int SearchArray(T[] array, T target)
    {
        if (array is not null)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(target))
                {
                    return i;
                }
            }
        }
        return -1;
    }
}