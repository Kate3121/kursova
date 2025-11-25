using System.Drawing;
using System.Windows.Forms;

namespace Курсова
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private TextBox txtName;
        private TextBox txtPassword;
        private ComboBox cmbAccess;
        private Button btnAdd;
        private ListBox lstUsers;

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblAccess = new System.Windows.Forms.Label();
            this.cmbAccess = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(25, 101);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Ім’я користувача:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(213, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 26);
            this.txtName.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(25, 141);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 23);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Пароль:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(213, 134);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(240, 26);
            this.txtPassword.TabIndex = 5;
            // 
            // lblAccess
            // 
            this.lblAccess.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAccess.Location = new System.Drawing.Point(25, 184);
            this.lblAccess.Name = "lblAccess";
            this.lblAccess.Size = new System.Drawing.Size(173, 23);
            this.lblAccess.TabIndex = 6;
            this.lblAccess.Text = "Права доступу:";
            // 
            // cmbAccess
            // 
            this.cmbAccess.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbAccess.Items.AddRange(new object[] {
            "R",
            "RW",
            "RWEA"});
            this.cmbAccess.Location = new System.Drawing.Point(213, 174);
            this.cmbAccess.Name = "cmbAccess";
            this.cmbAccess.Size = new System.Drawing.Size(240, 29);
            this.cmbAccess.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(219, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(234, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Зареєструвати";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstUsers.ItemHeight = 21;
            this.lstUsers.Location = new System.Drawing.Point(480, 76);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(386, 193);
            this.lstUsers.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(389, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 53);
            this.label1.TabIndex = 11;
            this.label1.Text = "Реєстрація";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Cascadia Code", 14.25F);
            this.btnBack.Location = new System.Drawing.Point(30, 283);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 35);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // RegisterForm
            // 
            this.ClientSize = new System.Drawing.Size(891, 340);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblAccess);
            this.Controls.Add(this.cmbAccess);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstUsers);
            this.Name = "RegisterForm";
            this.Text = "Реєстрація користувачів";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Label lblName;
        private Label lblPassword;
        private Label lblAccess;
        private Label label1;
        private Button btnBack;
    }
}