using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Курсова
{
    internal class RSAService
    {
        private RSACryptoServiceProvider rsa;

        public int KeySize => rsa.KeySize;

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
            byte[] data = Encoding.UTF8.GetBytes(File.ReadAllText(inputPath));

            int maxBlockSize = (rsa.KeySize / 8) - 11;
            List<byte> encryptedData = new List<byte>();

            for (int i = 0; i < data.Length; i += maxBlockSize)
            {
                int blockSize = Math.Min(maxBlockSize, data.Length - i);
                byte[] block = new byte[blockSize];
                Array.Copy(data, i, block, 0, blockSize);

                byte[] encryptedBlock = rsa.Encrypt(block, false);
                encryptedData.AddRange(encryptedBlock);
            }

            File.WriteAllBytes(outputPath, encryptedData.ToArray());
        }

        public void Decrypt(string inputPath, string outputPath)
        {
            byte[] encrypted = File.ReadAllBytes(inputPath);

            int blockSize = rsa.KeySize / 8; // 256 bytes
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

        public byte[] EncryptBytes(byte[] data)
        {
            return rsa.Encrypt(data, false);
        }

        public byte[] DecryptBytes(byte[] data)
        {
            return rsa.Decrypt(data, false);
        }
        public void LoadPublicKey()
        {
            if (!File.Exists("publicKey.xml"))
                throw new FileNotFoundException("Файл publicKey.xml не знайдено");

            rsa.FromXmlString(File.ReadAllText("publicKey.xml"));
        }

        public void LoadPrivateKey()
        {
            if (!File.Exists("privateKey.xml"))
                throw new FileNotFoundException("Файл privateKey.xml не знайдено");

            rsa.FromXmlString(File.ReadAllText("privateKey.xml"));
        }

    }
}
