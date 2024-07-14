using System.Text;
using Encryption_Winform.Common;

namespace Encryption_Winform.Algorithms;

public class RSA
{
    public static string Encryption(uint p, uint q, uint e, string message)
    {
        var ch = Utility.GetAllLettersAsDictionary();

        uint n = p * q;
        uint on = (p - 1) * (q - 1);

        uint d = (uint)Utility.ModularInverse((int)e, (int)on);


        var result = new StringBuilder();

        foreach (var item in message)
        {
            uint numericValue = (uint)(item.MapToIndex()) + 1;
            ulong encryptedValue = numericValue.ModPower(e, n);


            result.Append((char)(encryptedValue));
        }

        return result.ToString();
    }


    public static string Decrypt(uint p, uint q, uint e, string ciphertext)
    {
        uint n = p * q;
        uint on = (p - 1) * (q - 1);

        uint d = (uint)Utility.ModularInverse((int)e, (int)on);

        StringBuilder result = new StringBuilder();
        foreach (var item in ciphertext)
        {
            uint encryptedValue = (uint)item;
            ulong decryptedValue = encryptedValue.ModPower(d, n);


            char character = (char)(decryptedValue + 'A' - 1);
            result.Append(character);
        }

        return result.ToString();
    }
}




