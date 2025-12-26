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
                // Декодируем строку из Base64 обратно в байты
                var encryptedBytes = Convert.FromBase64String(txtEncrypted.Text);

                // Расшифровываем
                var decryptedBytes = rsa.DecryptBytes(encryptedBytes);
                var decryptedText = Encoding.UTF8.GetString(decryptedBytes);

                tbOut.Text = decryptedText;
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
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
