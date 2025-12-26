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
      
            rsa = new RSACryptoServiceProvider(2048);
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

         
            int maxBlockSize = (rsa.KeySize / 8) - 11;
            List<byte> encryptedData = new List<byte>();

            for (int i = 0; i < bytes.Length; i += maxBlockSize)
            {
                int blockSize = Math.Min(maxBlockSize, bytes.Length - i);
                byte[] block = new byte[blockSize];
                Array.Copy(bytes, i, block, 0, blockSize);

                byte[] encryptedBlock = rsa.Encrypt(block, false);
                encryptedData.AddRange(encryptedBlock);
            }

            File.WriteAllBytes(outputPath, encryptedData.ToArray());
        }

        public void Decrypt(string inputPath, string outputPath)
        {
            var encrypted = File.ReadAllBytes(inputPath);

            int blockSize = rsa.KeySize / 8; 
            List<byte> decryptedData = new List<byte>();

            for (int i = 0; i < encrypted.Length; i += blockSize)
            {
                byte[] block = new byte[blockSize];
                Array.Copy(encrypted, i, block, 0, blockSize);

                byte[] decryptedBlock = rsa.Decrypt(block, false);
                decryptedData.AddRange(decryptedBlock);
            }

            File.WriteAllText(outputPath, Encoding.UTF8.GetString(decryptedData.ToArray()));
        }
        public byte[] EncryptBytes(byte[] data) { return rsa.Encrypt(data, false); }
        public byte[] DecryptBytes(byte[] data) { return rsa.Decrypt(data, false); }
    }

}
