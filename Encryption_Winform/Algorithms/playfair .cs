using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Winform.Algorithms
{
    public static class Playfair 
    {
        public static string Encryption(string Plain,string Key)
        {
            string cipher = String.Empty;
            int Length = Plain.Length;

            if(Length % 2 != 0)
            {
                Length++;
                Plain += "x";
            }

            var SplitText = new string[Length / 2];

             for(int i = 0; i < Length / 2; i +=2)
                SplitText[i] = Plain.Substring(i,2);
             
                    

            return cipher;
        }
    }

}