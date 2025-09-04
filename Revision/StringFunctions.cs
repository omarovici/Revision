namespace Revision;

public class StringFunctions
{
    public static int GetCountOfUpperCaseLetters(string str)
    {
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsUpper(str[i])) count++;
        }
        return count;
    }
    public static int GetCountOfLowerCaseLetters(string str)
    {
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsLower(str[i])) count++;
        }
        return count;
    }
}