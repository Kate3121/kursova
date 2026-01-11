using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсова
{
    public partial class DecryptForm : Form
    {
        private RSAService rsa;
        internal DecryptForm(RSAService rsaService)
        {
            InitializeComponent();
            rsa = rsaService;
            rsa.LoadPrivateKey();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEncrypted.Text))
            {
                MessageBox.Show("Будь ласка, заповніть поле для введення тексту.");
                return;
            }

            try
            {
                byte[] encryptedBytes = Convert.FromBase64String(txtEncrypted.Text);
                int blockSize = rsa.KeySize / 8; 
                List<byte> decryptedData = new List<byte>();

                for (int i = 0; i < encryptedBytes.Length; i += blockSize)
                {
                    byte[] block = new byte[blockSize];
                    Array.Copy(encryptedBytes, i, block, 0, blockSize);

                    byte[] decryptedBlock = rsa.DecryptBytes(block);
                    decryptedData.AddRange(decryptedBlock);
                }
                tbOut.Text = Encoding.UTF8.GetString(decryptedData.ToArray()); ;
                Logger.Log("rsa", "Розшифровано повідомлення");
                Program.IncrementAction();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введений текст не є коректною Base64-строкою.");
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show("Помилка дешифрування: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
