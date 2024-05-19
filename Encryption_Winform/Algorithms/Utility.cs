namespace Encryption_Winform.Algorithms;
public static class Utility
{
    public static int GetGCD(int num1, int num2)
    {
        int A = int.Max(num1, num2);
        int B = int.Min(num1, num2);

        int R = A % B;

        while (true)
        {
            if (R == 0)
                return B;

            A = B;
            B = R;
            R = A % B;
        }
    }
    public static List<char> GetAllUpperLetters() =>
        new List<char>  { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
            'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
}
