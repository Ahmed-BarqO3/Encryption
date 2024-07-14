using System.Text;
using Encryption_Winform.Common;
namespace Encryption_Winform.Algorithms;
public  class Playfair : ISecurity
{
    

    public  string Encrypt(string plaintext, string Key)
    {

        var keyMatrix = GenerateKeyMatrix(Key);

        plaintext = plaintext.ToUpper().Replace("J", "I");
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < plaintext.Length; i += 2)
        {
            if (i != plaintext.Length - 1)
            {
                if (plaintext[i] == plaintext[i + 1])
                {
                    sb.Append(plaintext[i] + "Z");
                    sb.Append(plaintext[i+1] + "Z");
                }
                else
                    sb.Append(plaintext[i].ToString() + plaintext[i + 1]);
            }
        }

        StringBuilder ciphertext = new StringBuilder();
        for (int i = 0; i < sb.Length; i += 2)
        {
            char a = sb[i];
            char b = sb[i + 1];
            int rowA, colA, rowB, colB;
            GetPosition(ref a, out rowA, out colA, keyMatrix);
            GetPosition(ref b, out rowB, out colB, keyMatrix);

            if (rowA == rowB)
            {
                colA = (colA + 1) % 5;
                colB = (colB + 1) % 5;
            }
            else if (colA == colB)
            {
                rowA = (rowA + 1) % 5;
                rowB = (rowB + 1) % 5;
            }
            else
            {
                int temp = colA;
                colA = colB;
                colB = temp;
            }

            ciphertext.Append(keyMatrix[rowA, colA]);
            ciphertext.Append(keyMatrix[rowB, colB]);
        }

        return ciphertext.ToString();
    }

    public  string Decrypt(string ciphertext, string key)
    {
        var matrix = GenerateKeyMatrix(key);

        key = key.ToUpper();

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < ciphertext.Length; i += 2)
        {
            if (i == ciphertext.Length - 1 || ciphertext[i] == ciphertext[i + 1])
                sb.Append(ciphertext[i] + "X");
            else
                sb.Append(ciphertext[i].ToString() + ciphertext[i + 1]);
        }



        StringBuilder plaintext = new StringBuilder();
        for (int i = 0; i < ciphertext.Length; i += 2)
        {
            char ch1 = sb[i];
            char ch2 = sb[i + 1];

            int row1, col1, row2, col2;

            GetPosition(ref ch1, out row1, out col1, matrix);
            GetPosition(ref ch2, out row2, out col2, matrix);


            if (row1 == row2)
            {
                // Same row
                plaintext.Append(matrix[row1, (col1 - 1 + 5) % 5]);
                plaintext.Append(matrix[row2, (col2 - 1 + 5) % 5]);
            }
            else if (col1 == col2)
            {
                // Same column
                plaintext.Append(matrix[(row1 - 1 + 5) % 5, col1]);
                plaintext.Append(matrix[(row2 - 1 + 5) % 5, col2]);
            }
            else
            {
                plaintext.Append(matrix[row1, col2]);
                plaintext.Append(matrix[row2, col1]);
            }
        }

        return plaintext.ToString().ToUpper();
    }


    static char[,] GenerateKeyMatrix(string Key)
    {
        var matrix = new char[5, 5];
        StringBuilder sb = new StringBuilder();

        foreach (var c in Key.ToUpper())
            if (!sb.ToString().Contains(c) && c != 'J')
                sb.Append(c);


        string sympoles = sb.ToString() + "ABCDEFGHIKLMNOPQRSTUVWXYZ";
        sb.Clear();


        foreach (var c in sympoles)
            if (!sb.ToString().Contains(c))
                sb.Append(c);


        int index = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
                matrix[i, j] = sb[index++];
        }

        return matrix;
    }

    static void GetPosition(ref char c, out int row, out int col, char[,] keyMatrix)
    {
        row = 0; col = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (keyMatrix[i, j] == c)
                {
                    row = i;
                    col = j;
                    return;
                }
            }
        }
    }
}
