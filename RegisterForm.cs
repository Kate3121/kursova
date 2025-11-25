using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Курсова
{
    public partial class RegisterForm : Form
    {
        private List<User> users;

        public RegisterForm()
        {
            InitializeComponent();
            users = UserManager.LoadUsers();
            RefreshUserList();
        }
       
        private void RefreshUserList()
        {
            lstUsers.Items.Clear();
            foreach (var user in users)
                lstUsers.Items.Add($"{user.Name} | {user.Access}");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (users.Count >= 10)
            {
                MessageBox.Show("Досягнуто ліміту користувачів (10)");
                return;
            }

            var name = txtName.Text.Trim();
            var password = txtPassword.Text.Trim();
            var access = cmbAccess.SelectedItem?.ToString().Trim().ToUpper();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(access))
            {
                MessageBox.Show("Заповніть всі поля");
                return;
            }

            users.Add(new User(name, password, access));
            UserManager.SaveUsers(users);
            RefreshUserList();
            MessageBox.Show("Користувача додано");
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
