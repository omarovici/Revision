namespace Revision;


public class SortingFunctions<T>
{
    public delegate TOut SortTypeFuncDelegate<in T1,in T2, out TOut>(T1 a, T2 b);
    public static void BubbleSort<T>(T[] array,SortTypeFuncDelegate<T , T , bool> typeSort)
    {
        if (array?.Length > 0)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if(typeSort(array[j], array[j + 1])) SWAP(ref array[j], ref array[j + 1]);
                }
            }
        }
    }

    private static void SWAP<T>(ref T i, ref T i1)
    {
        T temp = i;
        i = i1;
        i1 = temp;
    }
}