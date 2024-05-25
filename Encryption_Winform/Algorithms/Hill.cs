namespace Encryption_Winform.Algorithms;

using MathNet.Numerics.LinearAlgebra;
using MatrixDotNet;
using static Math;
public static class Hill
{
    static int[,] GenrateKeyMatrics(string key)
    {
        var l = Utility.GetAllLettersAsDictionary();

        int n = 2;
        int[,] keyMatrics = new int[n, n];

        if (key.Length > 4)
        {
            n = (int)Floor(Sqrt(key.Length));
            keyMatrics = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int j = 0;
                foreach (char c in key)
                    keyMatrics[i, j++] = c;
            }
        }
        else
        {
            int index = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    keyMatrics[i, j] = l[key[index++]];
        }

        return keyMatrics;  
    }

    public static string Encryption(string text,string key)
    {
        var letters = Utility.GetAllLettersAsDictionary();
        var keyMatrics = GenrateKeyMatrics(key);


        int paddingLength = (key.Length - text.Length % key.Length) % key.Length;
        text.PadRight(text.Length + paddingLength, 'X');

        var size = text.Length / keyMatrics.Length;
        int[,] palintext = new int[size, keyMatrics.Length];

        for (int i = 0; i < size; i++)
        {
            byte index = 0;
            for (int j = 0; j < keyMatrics.Length; j++)
            {
                palintext[i, j] = letters[text[index++]];
            }
        }

        return "";
    }

    public static string Dencryption(string text, string key) => "Not implemented";
}
