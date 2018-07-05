using System;
using System.Security.Cryptography;
using System.Text;

namespace Framework.Cryptography
{
    /// <summary>
    /// Computes the System.Security.Cryptography.MD5 hash value for the input data
    /// using the implementation provided by the cryptographic service provider (CSP).
    /// This class cannot be inherited.
    /// </summary>
    public sealed class Cryptography
    {
        #region| Methods |

        /// <summary>
        /// Encrypt the given string using the specified key.
        /// </summary>
        /// <param name="textToEncrypt">The string to be encrypted</param>
        /// <param name="SecurePhrase">The Secure Phrase used to encryption</param>
        /// <returns>The Encrypted string.</returns>
        public static string Encrypt(string textToEncrypt, string SecurePhrase)
        {
            try
            {
                var oTripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
                var oMD5CryptoServiceProvider       = new MD5CryptoServiceProvider();

                byte[] byteHash, byteBuff;

                byteHash = oMD5CryptoServiceProvider.ComputeHash(ASCIIEncoding.ASCII.GetBytes(SecurePhrase));

                oTripleDESCryptoServiceProvider.Key  = byteHash;
                oTripleDESCryptoServiceProvider.Mode = CipherMode.ECB; //CBC, CFB

                byteBuff = ASCIIEncoding.ASCII.GetBytes(textToEncrypt);

                string Aux = Convert.ToBase64String(oTripleDESCryptoServiceProvider.CreateEncryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));

                oTripleDESCryptoServiceProvider.Dispose();
                oMD5CryptoServiceProvider.Dispose();

                return Aux;

            }
            catch (Exception ex)
            {
                return "Framework.Cryptography: " + ex.Message;
            }
        }

        /// <summary>
        /// Decrypt the given string using the specified key.
        /// </summary>
        /// <param name="textToDecrypt">The string to be encrypted</param>
        /// <param name="SecurePhrase">The Secure Phrase used to decryption</param>
        /// <returns>The Decrypted string.</returns>
        public static string Decrypt(string textToDecrypt, string SecurePhrase)
        {
            try
            {
                var oTripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
                var oMD5CryptoServiceProvider = new MD5CryptoServiceProvider();

                byte[] byteHash, byteBuff;

                byteHash = oMD5CryptoServiceProvider.ComputeHash(ASCIIEncoding.ASCII.GetBytes(SecurePhrase));

              
                oTripleDESCryptoServiceProvider.Key = byteHash;
                oTripleDESCryptoServiceProvider.Mode = CipherMode.ECB; //CBC, CFB

                byteBuff = Convert.FromBase64String(textToDecrypt);
                
                string Aux = ASCIIEncoding.ASCII.GetString(oTripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));

                oTripleDESCryptoServiceProvider.Dispose();
                oMD5CryptoServiceProvider.Dispose();

                return Aux;
            }
            catch (Exception ex)
            {
                return "Framework.Cryptography: " + ex.Message;
            }
        }

        /// <summary>
        /// Encrypts a given string using the ProtectedConfigurationProvider
        /// </summary>
        public static string EncryptUsingTripleDES(string encryptValue)
        {
            var output = string.Empty;

            var tripleDES = new TripleDESProtectedConfigurationProvider();

            output = tripleDES.EncryptString(encryptValue);

            tripleDES = null;

            return output;
        }

        /// <summary>
        /// Decrypts a given string using the ProtectedConfigurationProvider
        /// </summary>
        public static string DecryptUsingTripleDES(string textToDecrypt)
        {
            var output = string.Empty;

            var tripleDES = new TripleDESProtectedConfigurationProvider();

            output = tripleDES.DecryptString(textToDecrypt);

            tripleDES = null;

            return output;
        }

        /// <summary>
        /// Generates a unique key to be used as a token
        /// </summary>
        /// <param name="maxSize"></param>
        /// <returns></returns>
        public static string GenerateTokenUniqueKey(int maxSize = 15)
        {
            char[] chars = new char[62];
            chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[1];

            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[maxSize];
                crypto.GetNonZeroBytes(data);
            }

            var result = new StringBuilder(maxSize);

            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }

            return result.ToString();
        }


        #endregion
    }
}
