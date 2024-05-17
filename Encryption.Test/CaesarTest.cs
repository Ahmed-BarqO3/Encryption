using Encryption_Winform.Algorithms;

namespace Encryption.Test
{
    public class CaesarTest
    {
        [Fact]
        public void Encryption_WhenEncryptPlainText_ShiftEachValueToRight()
        {
            //Arrang
            string PlainText = "HELLO";
            int key = 3;

            //Act
            var actual = Caesar.Encryption(PlainText, key);
            var expected = "KHOOR";

            //Assert
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void Decryption_WhenDecryptCipherText_ShiftEachValueToLeft()
        {
            //Arrang
            string CipherText = "KHOOR";
            int key = 3;

            //Act
            var actual = Caesar.Decryption(CipherText, key);
            var expected = "HELLO";

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}