using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace Encryption_Winform.Algorithms;

public class RSA
{
    private BigInteger N { get; set; }
    private BigInteger E { get; set; }
    private BigInteger D { get; set; }

    public RSA()
    {
        GenerateKeys();
    }

    private void GenerateKeys()
    {
        var rng = RandomNumberGenerator.Create();
        var p = GeneratePrimeNumber(1024, rng);
        var q = GeneratePrimeNumber(1024, rng);

        N = p * q; // n = p * q
        var phi = (p - 1) * (q - 1); // phi = (p-1) * (q-1)

        E = new BigInteger(65537); // Commonly used value for e

        D = ModInverse(E, phi); // Calculate d, the modular inverse of e mod phi
    }

    public BigInteger Encrypt(string data)
    {
        var dataBytes = Encoding.UTF8.GetBytes(data);
        var m = new BigInteger(dataBytes);

        if (m >= N)
            throw new ArgumentException("The data to encrypt must be smaller than the modulus.");

        var c = BigInteger.ModPow(m, E, N);

        return c;
    }

    public string Decrypt(BigInteger encryptedData)
    {
        var m = BigInteger.ModPow(encryptedData, D, N);
        var dataBytes = m.ToByteArray();

        return Encoding.UTF8.GetString(dataBytes);
    }

    private static BigInteger GeneratePrimeNumber(int bits, RandomNumberGenerator rng)
    {
        while (true)
        {
            var bytes = new byte[bits / 8];
            rng.GetBytes(bytes);
            var p = new BigInteger(bytes);

            if (p.IsProbablePrime(30))
            {
                return p;
            }
        }
    }

    private static BigInteger ModInverse(BigInteger a, BigInteger m)
    {
        BigInteger m0 = m, t, q;
        BigInteger x0 = 0, x1 = 1;

        if (m == 1)
            return 0;

        while (a > 1)
        {
            q = a / m;
            t = m;

            m = a % m;
            a = t;
            t = x0;

            x0 = x1 - q * x0;
            x1 = t;
        }

        if (x1 < 0)
            x1 += m0;

        return x1;
    }
}

public static class BigIntegerExtensions
    {
        public static bool IsProbablePrime(this BigInteger source, int certainty)
        {
            if (source == 2 || source == 3)
                return true;
            if (source < 2 || source % 2 == 0)
                return false;

            var d = source - 1;
            var s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s += 1;
            }

            var rng = RandomNumberGenerator.Create();
            var bytes = new byte[source.ToByteArray().LongLength];
            BigInteger a;

            for (var i = 0; i < certainty; i++)
            {
                do
                {
                    rng.GetBytes(bytes);
                    a = new BigInteger(bytes);
                } while (a < 2 || a >= source - 2);

                var x = BigInteger.ModPow(a, d, source);
                if (x == 1 || x == source - 1)
                    continue;

                for (var r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, source);
                    if (x == 1)
                        return false;
                    if (x == source - 1)
                        break;
                }

                if (x != source - 1)
                    return false;
            }

            return true;
        }
    }
