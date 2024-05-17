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
           var sympoles = new List<char>  { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
                'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            StringBuilder C = new StringBuilder();

            int index;
            foreach (char c in P)
            {
                index = sympoles.IndexOf(c);
                C.Append(sympoles[(index + K) % 26]);
            }
            return C.ToString();
        }

        public static string Decryption(string C, int K)
        {
            var sympoles = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
                'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            StringBuilder P = new StringBuilder();

            int index;
            foreach (char c in C)
            {
                index = sympoles.IndexOf(c);
                if((index - K) % 26 < 0)
                    P.Append(sympoles[(index - K) % 26] + 26);
                else
                    P.Append(sympoles[(index - K) % 26]);
            }
            
            return P.ToString();
        }

    }
}
