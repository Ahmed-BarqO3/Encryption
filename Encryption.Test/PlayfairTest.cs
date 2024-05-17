using Encryption_Winform.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption.Test
{
    public class PlayfairTest
    {
        [Fact]
        void Encryption_WhenEncryptPlainText_ReplaceEachPairsOfLetters()
        {
            //Arrang
            string PlainText = "INSTRUMENTS";
            string key = "MONARCHY";

            //Act
            var actual = Playfair.Encryption(PlainText, key);
            var expected = "GATLMZCLRQTX";

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        void Decryption_WhenDecryptCipherText_ReplaceEachPairsOfLetters()
        {
            //Arrang
            string CipherText = "GATLMZCLRQTX";
            string key = "MONARCHY";

            //Act
            var actual = Playfair.Decryption(CipherText, key);
            var expected = "INSTRUMENTSZ";

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
