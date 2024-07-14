namespace Encryption_Winform.Common;
public interface ISecurity
{
    string Encrypt(string plainText,string key);
    string Decrypt(string cipherText,string key);
}
