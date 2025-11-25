using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Курсова
{
    public partial class Cryptography : Form
    {
        private RSAService rsa;
        public Cryptography()
        {
            InitializeComponent();
            rsa = new RSAService();
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            rsa.SaveKeys();
            MessageBox.Show("Ключі згенеровано");
            Program.IncrementAction();
        }

        private void btnByEncrypt_Click(object sender, EventArgs e)
        {
            EncrytForm encryptForm = new EncrytForm(rsa);
            encryptForm.Show();
            this.Close();
            Program.IncrementAction();

        }

        private void btnbyDecrypt_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser != null && (Program.CurrentUser.Access == "RW" || Program.CurrentUser.Access == "RWEA"))
            {
                DecryptForm decryptForm = new DecryptForm(rsa);
                decryptForm.ShowDialog();
                this.Close();
                Program.IncrementAction();
            }
            else
            {
                MessageBox.Show("У вас немає доступу цієї сторінки. Потрібен рівень RW чи RWEA.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
            this.Close();

        }
    }
}
