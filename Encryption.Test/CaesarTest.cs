using Encryption_Winform.Algorithms;

namespace Encryption.Test
{
    public class CaesarTest
    {
        [Fact]
        public void Encryption_EncryptPlainText_ShiftEachValueInPlainTextToRight()
        {
            //Arrange
            string PlainText = "HELLO";
            int Key = 3;

            //Act

            var Actual = Caesar.Encryption(PlainText, Key);

            //Assert

            Assert.Equal("KHOOR", Actual);
        }

        [Fact]
        public void Decryption_DecryptCipherText_ShiftEachValueInCipherTextToLeft()
        {
            //Arrange
            string CipherText = "KHOOR";
            int Key = 3;

            //Act

            var Actual = Caesar.Decryption(CipherText, Key);

            //Assert

            Assert.Equal("HELLO", Actual);
        }
    }
}