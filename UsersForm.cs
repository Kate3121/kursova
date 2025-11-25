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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void btnByDelete_Click(object sender, EventArgs e)
        {
            DeleteUserForm DeleteUserForm = new DeleteUserForm();
            DeleteUserForm.Show();
            this.Close();
            Program.IncrementAction();
        }

        private void btnByAdd_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Close();
            Program.IncrementAction();
        }
    }
}
