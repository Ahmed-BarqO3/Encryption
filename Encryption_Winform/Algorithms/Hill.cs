using Encryption_Winform.Common;

namespace Encryption_Winform.Algorithms;

using System.Text;
using static Math;

public static class Hill
{
    public static string Encrypt(string plaintext, string key)
    {

        // Calculate the dimension of the key matrix
        int matrixSize = (int)Math.Sqrt(key.Length);

        if (matrixSize * matrixSize != key.Length)
        {
            throw new ArgumentException("Key length must be a perfect square.");
        }

        // Convert key into a matrix
        int[,] keyMatrix = new int[matrixSize, matrixSize];
        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < matrixSize; j++)
            {
                keyMatrix[i, j] = key[i * matrixSize + j] - 'A';
            }
        }

        // Pad plaintext if its length is not a multiple of the matrix size
        while (plaintext.Length % matrixSize != 0)
        {
            plaintext += "X";
        }

        // Encrypt plaintext in blocks of the matrix size
        string ciphertext = "";
        for (int i = 0; i < plaintext.Length; i += matrixSize)
        {
            int[] block = new int[matrixSize];
            for (int j = 0; j < matrixSize; j++)
            {
                block[j] = plaintext[i + j] - 'A';
            }

            int[] encryptedBlock = new int[matrixSize];
            for (int j = 0; j < matrixSize; j++)
            {
                encryptedBlock[j] = 0;
                for (int k = 0; k < matrixSize; k++)
                {
                    encryptedBlock[j] += keyMatrix[j, k] * block[k];
                }

                encryptedBlock[j] %= 26;
            }

            for (int j = 0; j < matrixSize; j++)
            {
                ciphertext += (char)(encryptedBlock[j] + 'A');
            }
        }

        return ciphertext;
    }

    public static string Dencryption(string ciphertext, string key)
    {
        int matrixSize = (int)Math.Sqrt(key.Length);


        // Convert key into a matrix
        int[,] keyMatrix = new int[matrixSize, matrixSize];
        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < matrixSize; j++)
            {
                keyMatrix[i, j] = key[i * matrixSize + j] - 'A';
            }
        }

        // Find the inverse of the key matrix
        int[,] inverseKeyMatrix = Utility.InverseMatrix(keyMatrix, 26);

        // Decrypt ciphertext in blocks of the matrix size
        string plaintext = "";
        for (int i = 0; i < ciphertext.Length; i += matrixSize)
        {
            int[] block = new int[matrixSize];
            for (int j = 0; j < matrixSize; j++)
            {
                block[j] = ciphertext[i + j] - 'A';
            }

            int[] decryptedBlock = new int[matrixSize];
            for (int j = 0; j < matrixSize; j++)
            {
                decryptedBlock[j] = 0;
                for (int k = 0; k < matrixSize; k++)
                {
                    decryptedBlock[j] += inverseKeyMatrix[j, k] * block[k];
                }

                decryptedBlock[j] = (decryptedBlock[j] % 26 + 26) % 26; // Ensure positive modulo
            }

            for (int j = 0; j < matrixSize; j++)
            {
                plaintext += (char)(decryptedBlock[j] + 'A');
            }
        }

        return plaintext;
    }
}

