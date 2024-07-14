using System.Text;
using Encryption_Winform.Common;

namespace Encryption_Winform.Algorithms;
public class Vigenere : ISecurity
{
    static char[] GenerateArrayKey(int Length, string Key)
    {
        char[] K = new char[Length];

        byte counter = 0;
        while (counter < Length)
            foreach (char c in Key)
            {
                if (counter == Length)
                    break;
                K[counter++] = c;
            }
        return K;
    }

    public string Encrypt(string PlainText,string Key)
    {
        var letters = Utility.GetAllUpperLettersAsList();

        var K = GenerateArrayKey(PlainText.Length, Key);

        StringBuilder sb = new StringBuilder();

        int count = 0;
        foreach (char ch in PlainText)
        {
            int index = letters.IndexOf(ch);
            int i = letters.IndexOf(K[count++]);

            sb.Append(letters[(index + i) % letters.Count]);
        }
        return sb.ToString();
    }

    public  string Decrypt(string CipherText, string Key)
    {
        var letters = Utility.GetAllUpperLettersAsList();

        var K = GenerateArrayKey(CipherText.Length, Key);

        StringBuilder sb = new StringBuilder();

        int count = 0;
        foreach (char ch in CipherText)
        {
            int index = letters.IndexOf(ch);
            int i = letters.IndexOf(K[count++]);

            if ((index - i) < 0)
                sb.Append(letters[(index - i) % letters.Count + 26]);
            else
                sb.Append(letters[(index - i) % letters.Count]);
        }
        return sb.ToString();
    }
}
