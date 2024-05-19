namespace Encryption_Winform.Algorithms
{
    public static class GCD
    {
        public static int Get(int num1, int num2)
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
    }
}
