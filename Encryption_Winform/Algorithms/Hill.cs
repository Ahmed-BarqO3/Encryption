using Encryption_Winform.Common;

namespace Encryption_Winform.Algorithms;

public  class Hill : ISecurity
{
    public  string Encrypt(string plaintext, string key)
    {

        int matrixSize = (int)Math.Sqrt(key.Length);

     

        int[,] keyMatrix = new int[matrixSize, matrixSize];
        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < matrixSize; j++)
            {
                keyMatrix[i, j] = key[i * matrixSize + j] - 'A';
            }
        }

        while (plaintext.Length % matrixSize != 0)
        {
            plaintext += "X";
        }

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

    public string Decrypt(string ciphertext, string key)
    {
        int matrixSize = (int)Math.Sqrt(key.Length);


        int[,] keyMatrix = new int[matrixSize, matrixSize];
        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < matrixSize; j++)
            {
                keyMatrix[i, j] = key[i * matrixSize + j] - 'A';
            }
        }

        int[,] inverseKeyMatrix = Utility.InverseMatrix(keyMatrix, 26);

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

                decryptedBlock[j] = (decryptedBlock[j] % 26 + 26) % 26;
            }

            for (int j = 0; j < matrixSize; j++)
            {
                plaintext += (char)(decryptedBlock[j] + 'A');
            }
        }

        return plaintext;
    }
}

