using System;
using System.Configuration;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace Framework.Cryptography
{
    /// <summary>
    /// Web Config security with ProtectedConfigurationProvider
    /// </summary>
    public class TripleDESProtectedConfigurationProvider : ProtectedConfigurationProvider
    {
        #region| Fields |

        private TripleDESCryptoServiceProvider tripleDesCripto = new TripleDESCryptoServiceProvider();
        private string key = "Sgo0k8dv112TCU0BiMNOo0tfR5AYmXeC";
        private string IV = "mmVbNIIj8k4=";

        #endregion

        #region| Constructor |

        /// <summary>
        /// Default constructor
        /// </summary>
        public TripleDESProtectedConfigurationProvider()
        {
            //Lê a chave e o IV
            tripleDesCripto.Key = Convert.FromBase64String(key);
            tripleDesCripto.IV = Convert.FromBase64String(IV);
            //ECB(Electronic code Book)

            tripleDesCripto.Mode = CipherMode.ECB;
            //padding mode se tiver qualquer byte adicional a ser adicionado
            tripleDesCripto.Padding = PaddingMode.PKCS7;
        }

        #endregion

        #region| Methods |

        /// <summary>
        /// Encrypt the web.config file
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public override XmlNode? Encrypt(XmlNode node)
        {

            string encryptedData = EncryptString(node.OuterXml);

            // Creates a encrypted section in thw Web Config file
            var xmlDoc = new XmlDocument();

            xmlDoc.PreserveWhitespace = true;
            xmlDoc.LoadXml("<EncryptedData>" + encryptedData + "</EncryptedData>");

            if(xmlDoc.DocumentElement != null) 
            {
                return xmlDoc.DocumentElement;
            }

            return null;
            
        }

        /// <summary>
        /// Decrypt the web.config file
        /// </summary>
        /// <param name="encryptedNode"></param>
        /// <returns></returns>
        public override XmlNode? Decrypt(XmlNode encryptedNode)
        {
            string decryptedData = DecryptString(encryptedNode.InnerText);

            // Decrypt the Web.Config section
            var xmlDoc = new XmlDocument();

            xmlDoc.PreserveWhitespace = true;
            xmlDoc.LoadXml(decryptedData);

            if(xmlDoc.DocumentElement != null)
            {
                return xmlDoc.DocumentElement;
            }

            return null;

        }

        /// <summary>
        /// Encrypts a given string using the System.Security.Cryptography.MD5 hash value for the input data
        /// using the implementation provided by the cryptographic service provider (CSP).
        /// This class cannot be inherited.
        /// </summary>
        internal string EncryptString(string encryptValue)
        {

            var valBytes = Encoding.Unicode.GetBytes(encryptValue);

            var transform = tripleDesCripto.CreateEncryptor();

            var ms = new MemoryStream();
            var cs = new CryptoStream(ms, transform, CryptoStreamMode.Write);

            cs.Write(valBytes, 0, valBytes.Length);
            cs.FlushFinalBlock();

            byte[] returnBytes = ms.ToArray();
            cs.Close();

            return Convert.ToBase64String(returnBytes);
        }

        /// <summary>
        /// Decrypts a given string
        /// </summary>
        internal string DecryptString(string encryptedValue)
        {
            var valBytes = Convert.FromBase64String(encryptedValue);

            var transform = tripleDesCripto.CreateDecryptor();

            var ms = new MemoryStream();
            var cs = new CryptoStream(ms, transform, CryptoStreamMode.Write);

            cs.Write(valBytes, 0, valBytes.Length);
            cs.FlushFinalBlock();

            byte[] returnBytes = ms.ToArray();
            cs.Close();

            return Encoding.Unicode.GetString(returnBytes);
        } 

        #endregion

    }
}
