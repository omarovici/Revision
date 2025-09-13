namespace Revision;

public static class IntExtention
{
    public static int Reverse(this int Number)
    {
        int reverseNumber = 0;
        while (Number > 0)
        {
            int remainder = Number % 10;
            reverseNumber = (reverseNumber * 10) + remainder;
            Number = Number / 10;
        }
        return reverseNumber;
    }
}