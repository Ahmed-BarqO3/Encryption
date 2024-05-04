using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Winform.Algorithms
{
    public static class Caesar
    {

        public static string Encryption(string P,int K)
        {
           var sympole = new char[]  { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
                'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            StringBuilder C = new StringBuilder();

            for (int i = 0; i < P.Length; i++)
            {
                for (int j = 0;j < 26;j++)
                if (P[i] == sympole[j])
                    if ( j + K > 25)
                    {
                        C.Append(sympole[Math.Abs(25 - (j + K) - 1)]);
                    }
                    else
                        C.Append(sympole[j + K]);
                
            }
            return C.ToString();
        }

        public static string Decryption(string C, int K)
        {
            var sympole = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
                'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            StringBuilder P = new StringBuilder();

            for (int i = 0; i < C.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                    if (C[i] == sympole[j])
                    {
                        if (j - K < 0)
                        {
                            P.Append(sympole[(j - K) + 26]);
                        }
                        else
                            P.Append(sympole[j - K]);
                    }
            }
            return P.ToString();
        }

    }
}
