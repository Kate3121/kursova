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
using System.IO;


namespace Курсова
{
    public partial class EncrytForm : Form
    {
        private RSAService rsa;
        internal EncrytForm(RSAService rsaService)
        {
            InitializeComponent();
            rsa = rsaService;

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Будь ласка, заповніть поле для введення тексту.");
                return;
            }
            // Записуємо текст із поля в input.txt
            File.WriteAllText("input.txt", txtInput.Text);
            rsa.Encrypt("input.txt", "close.txt");
            var encrypted = Convert.ToBase64String(System.IO.File.ReadAllBytes("close.txt"));
            txtEncrypted.Text = encrypted;
            Logger.Log("rsa", "Зашифровано повідомлення");
            Program.IncrementAction();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
