
using Encryption_Winform.Algorithms;

namespace Encryption.Test
{
    public class playfairTest
    {
        [Fact]
        public void Encryption_EncryptPlainText_ShiftEachValueInPlainTextToRight()
        {
            //Arrange
            string PlainText = "INSTRUMENTS"; 
            string Key = "MONARCHY"; 

            //Act

            var Actual = Playfair.Encryption(PlainText, Key);

            //Assert

            Assert.Equal("GATLMZCLRQTX", Actual);
        }

        [Fact]
        public void Decryption_DecryptPlainText_ShiftEachValueInPlainTextToRight2()
        {
            //Arrange
            string PlainText = "GATLMZCLRQT";
            string Key = "MONARCHY";

            //Act

            var Actual = Playfair.Decryption(PlainText, Key);

            //Assert

            Assert.Equal("INSTRUMENTSZ", Actual);
        }
    }
}
