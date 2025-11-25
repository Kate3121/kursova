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
            System.IO.File.WriteAllText("close.txt", txtEncrypted.Text);
            rsa.Decrypt("close.txt", "out.txt");
            var decrypted = System.IO.File.ReadAllText("out.txt");
            tbOut.Text = decrypted;
            Logger.Log("rsa", "Розшифровано повідомлення");
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
