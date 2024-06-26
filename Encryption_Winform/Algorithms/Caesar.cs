using Encryption_Winform.Common;

namespace Encryption_Winform.Algorithms;
using System.Text;
public static class Caesar
{
    public static string Encryption(string P, int K)
    {
        var sympoles = Utility.GetAllUpperLettersAsList();

        StringBuilder C = new StringBuilder();

        int index;
        foreach (char c in P)
        {
            index = sympoles.IndexOf(c);
            C.Append(sympoles[(index + K) % 26]);
        }
        return C.ToString();
    }

    public static string Decryption(string C, int K)
    {
        var sympoles = Utility.GetAllUpperLettersAsList();

        StringBuilder P = new StringBuilder();

        int index;
        foreach (char c in C)
        {
            index = sympoles.IndexOf(c);
            if ((index - K) % 26 < 0)
                P.Append(sympoles[(index - K) % 26] + 26);
            else
                P.Append(sympoles[(index - K) % 26]);
        }

        return P.ToString();
    }
}
