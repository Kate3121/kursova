using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Курсова
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string password = txtPassword.Text.Trim();

            var users = UserManager.LoadUsers();
            var user = users.FirstOrDefault(u => u.Name == name && u.Password == password);

            if (user != null)
            {
                Program.CurrentUser = user;
                Logger.Log(name, "Успішний вхід");
                MessageBox.Show($"Вхід дозволено. Ласкаво просимо, {name}");
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();

                // ?
                //AccessControl.ShowAccessibleDisks(user.Access);
            }
            else
            {
                Logger.Log(name, "Невдалий вхід");
                MessageBox.Show("Невірне ім’я або пароль");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

