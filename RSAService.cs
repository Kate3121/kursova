using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Курсова
{
    internal class RSAService
    {
        private RSACryptoServiceProvider rsa;

        public RSAService()
        {
            rsa = new RSACryptoServiceProvider(512);
        }

        public void SaveKeys()
        {
            File.WriteAllText("publicKey.xml", rsa.ToXmlString(false));
            File.WriteAllText("privateKey.xml", rsa.ToXmlString(true));
        }

        public void Encrypt(string inputPath, string outputPath)
        {
            var text = File.ReadAllText(inputPath);
            var bytes = Encoding.UTF8.GetBytes(text);
            var encrypted = rsa.Encrypt(bytes, false);
            File.WriteAllBytes(outputPath, encrypted);
        }

        public void Decrypt(string inputPath, string outputPath)
        {
            var encrypted = File.ReadAllBytes(inputPath);
            var decrypted = rsa.Decrypt(encrypted, false);
            File.WriteAllText(outputPath, Encoding.UTF8.GetString(decrypted));
        }
    }
}
