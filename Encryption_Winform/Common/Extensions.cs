namespace Encryption_Winform.Common;

public static class Extensions
{
    public static byte MapToIndex(this char item) => Utility.GetAllLettersAsDictionary().GetValueOrDefault(item);

    public static bool IsPrime(this uint num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;

        for (int i = 2; i  <= Math.Round((double)(num / 2)); i++)
            if (num % i == 0) return false;

        return true;
    }

    public static uint ModPower(this uint baseValue, uint exponent, uint modulus)
    {

        if (baseValue == 0)
            return 0;


        uint result = 1;
        baseValue = baseValue % modulus;

        while (exponent > 0)
        {
            if ((exponent & 1) == 1)  // If exponent is odd
                result = result * baseValue % modulus;
            exponent >>= 1;  // Divide exponent by 2

            baseValue = baseValue * baseValue % modulus;
        }
        return result;
    }


}




