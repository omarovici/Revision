namespace Revision;

public class FilterList
{
    public delegate bool FilterFuncDelegate<T>(T a);
    // public delegate bool FilterFuncDelegate2(int a, int b);


    public static List<T> FindElements<T>(List<T> elements , FilterFuncDelegate<T>  filter)
    {
        List<T> Result = new List<T>();
        for (int i = 0; i < elements.Count; i++)
        {
            if(filter(elements[i])) Result.Add(elements[i]);
        }
        return Result;
    }
    // public static List<int> FindElements(List<int> numbers , FilterFuncDelegate2  filter , int dividedBy)
    // {
    //     List<int> Result = new List<int>();
    //     for (int i = 0; i < numbers.Count; i++)
    //     {
    //         if(filter(numbers[i],dividedBy)) Result.Add(numbers[i]);
    //     }
    //     return Result;
    // }
}