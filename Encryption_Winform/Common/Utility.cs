namespace Encryption_Winform.Common;

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

    public static List<char> GetAllUpperLettersAsList() =>

        new List<char>
        {
            'A',
            'B',
            'C',
            'D',
            'E',
            'F',
            'G',
            'H',
            'I',
            'J',
            'K',
            'L',
            'M',
            'N',
            'O',
            'P',
            'Q',
            'R',
            'S',
            'T',
            'U',
            'V',
            'W',
            'X',
            'Y',
            'Z'
        };

    public static int[,] InverseMatrix(int[,] matrix, int mod)
    {
        int n = matrix.GetLength(0);
        int[,] adj = new int[n, n];
        int det = Determinant(matrix, n);

        int invDet = ModularInverse(det, mod);


        Adjugate(matrix, adj, n);


        int[,] inverseMatrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                inverseMatrix[i, j] = (adj[i, j] * invDet) % mod;
                if (inverseMatrix[i, j] < 0)
                {
                    inverseMatrix[i, j] += mod;
                }
            }
        }

        return inverseMatrix;
    }

    private static int Determinant(int[,] matrix, int n)
    {
        if (n == 1)
        {
            return matrix[0, 0];
        }

        int det = 0;
        int[,] temp = new int[n, n];
        int sign = 1;

        for (int f = 0; f < n; f++)
        {
            GetCofactor(matrix, temp, 0, f, n);
            det += sign * matrix[0, f] * Determinant(temp, n - 1);
            sign = -sign;
        }

        return det;
    }

    private static void GetCofactor(int[,] matrix, int[,] temp, int p, int q, int n)
    {
        int i = 0, j = 0;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (row != p && col != q)
                {
                    temp[i, j++] = matrix[row, col];

                    if (j == n - 1)
                    {
                        j = 0;
                        i++;
                    }
                }
            }
        }
    }

    private static void Adjugate(int[,] matrix, int[,] adj, int n)
    {
        if (n == 1)
        {
            adj[0, 0] = 1;
            return;
        }

        int sign = 1;
        int[,] temp = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                GetCofactor(matrix, temp, i, j, n);
                sign = ((i + j) % 2 == 0) ? 1 : -1;
                adj[j, i] = (sign * Determinant(temp, n - 1)) % 26;
                if (adj[j, i] < 0)
                {
                    adj[j, i] += 26;
                }
            }
        }
    }

    private static int ModularInverse(int a, int mod)
    {
        int m0 = mod, t, q;
        int x0 = 0, x1 = 1;

        if (mod == 1) return 0;

        while (a > 1)
        {
            q = a / mod;
            t = mod;
            mod = a % mod;
            a = t;
            t = x0;
            x0 = x1 - q * x0;
            x1 = t;
        }

        if (x1 < 0) x1 += m0;

        return x1;
    }
}
