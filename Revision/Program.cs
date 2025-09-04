namespace Revision;

class Program
{
    static void Main(string[] args)
    {
        #region Example-01

        // String s = "OmarKhaliDSAber";
        // StringFuncDelegate X = new StringFuncDelegate(StringFunctions.GetCountOfUpperCaseLetters);
        // int Result = X.Invoke(s);
        // Console.WriteLine($"GetCountOfUpperCaseLetters: {Result}"); // 5
        // X = StringFunctions.GetCountOfLowerCaseLetters;
        // Result = X.Invoke(s);
        // Console.WriteLine($"GetCountOfLowerCaseLetters: {Result}"); // 10

        #endregion
        #region Example-02

        // int[] numbersRandom = {6,10,3,70,33,1,19,0};
        // SortingFunctions.SortTypeFuncDelegate<int> Big = SortingType.Greater;
        // SortingFunctions.SortTypeFuncDelegate<int> Small = SortingType.Less;
        //
        // SortingFunctions.BubbleSort(numbersRandom,Big);
        // foreach (int i in numbersRandom)
        //     Console.Write(i + " ");
        //
        // Console.WriteLine();
        //
        // SortingFunctions.BubbleSort(numbersRandom,Small);
        // foreach (int i in numbersRandom)
        //     Console.Write(i + " ");

        // string[] names = ["Omar", "Ali", "MK", "Antitakompo"];
        // SortingFunctions<string>.SortTypeFuncDelegate<string,string,bool> ASC = SortingType.SortAsc;
        // SortingFunctions<string>.SortTypeFuncDelegate<string,string,bool> DESC = SortingType.SortDesc;
        //
        // SortingFunctions<string>.BubbleSort(names,ASC);
        // foreach (string i in names)
        //     Console.Write(i + " ");
        //
        // Console.WriteLine();
        //
        // SortingFunctions<string>.BubbleSort(names,DESC);
        // foreach (string i in names)
        //     Console.Write(i + " ");

        #endregion
        #region Example-03


        // List<int> numbers = Enumerable.Range(1, 100).ToList();
        // FilterList.FilterFuncDelegate<int> even = FiltersOfList.CheckEven;
        // FilterList.FilterFuncDelegate<int> odd = FiltersOfList.CheckOdd;
        //
        //
        //
        // List<int> oddNumbers = FilterList.FindElements(numbers , even);
        // List<int> evenNumbers = FilterList.FindElements(numbers , odd);
        //
        //
        // Console.Write("Odd Numbers: ");
        // foreach(int number in oddNumbers)
        //     Console.Write($"{number} ");
        //
        // Console.WriteLine();
        // Console.Write("Even Numbers: ");
        //
        // foreach(int number in evenNumbers)
        //     Console.Write($"{number} ");
        
        // List<string> Names = ["Ahmed","Ali","Omar","Assem","Zeyad","Mona","Sara","Rana","Salma","Yara","Youssef","Yassin","Yehia","Rawan"];
        // List<string> Names1 = FilterList.FindElements<string>(Names,FiltersOfList.CheckLengthMoreThanFour);
        // foreach (string name in Names1)
        //     Console.Write($"{name} ");

        #endregion
        
    }
}