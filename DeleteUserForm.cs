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
    public partial class DeleteUserForm : Form
    {
        public static string AdminPassword = "admin123";
        private List<User> users;
        public DeleteUserForm()
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


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtAdminPassword.Text != AdminPassword)
            {
                MessageBox.Show("Невірний пароль адміністратора");
                return;
            }

            var name = txtName.Text.Trim();
            var user = users.FirstOrDefault(u => u.Name == name);
            Program.IncrementAction();
            if (user != null)
            {
                users.Remove(user);
                UserManager.SaveUsers(users);
                RefreshUserList();
                MessageBox.Show("Користувача видалено");
            }
            else
            {
                MessageBox.Show("Користувача не знайдено");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
    
}
