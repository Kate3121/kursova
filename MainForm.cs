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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
       
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
            this.Close();
        }

        private void btnByCrypt_Click(object sender, EventArgs e)
        {
            Cryptography cryptography = new Cryptography();
            cryptography.Show();
            this.Close();
            Program.IncrementAction();
        }

        private void btnByUsers_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser != null && Program.CurrentUser.Access.Trim().ToUpper() == "RWEA")
            {
                UsersForm usersForm = new UsersForm();
                usersForm.Show();
                this.Hide();
                Program.IncrementAction();
            }
            else
            {
                MessageBox.Show("У вас немає доступу до цієї форми. ");
            }
        }
    }
    
}
