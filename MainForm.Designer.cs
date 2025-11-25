using System.Drawing;
using System.Windows.Forms;

namespace Курсова
{
    partial class MainForm
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

        private Label lblTitle;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnByUsers = new System.Windows.Forms.Button();
            this.btnByCrypt = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(171, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Головне меню";
            // 
            // btnByUsers
            // 
            this.btnByUsers.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnByUsers.Location = new System.Drawing.Point(49, 98);
            this.btnByUsers.Name = "btnByUsers";
            this.btnByUsers.Size = new System.Drawing.Size(180, 43);
            this.btnByUsers.TabIndex = 1;
            this.btnByUsers.Text = "Користувачі";
            this.btnByUsers.UseVisualStyleBackColor = true;
            this.btnByUsers.Click += new System.EventHandler(this.btnByUsers_Click);
            // 
            // btnByCrypt
            // 
            this.btnByCrypt.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnByCrypt.Location = new System.Drawing.Point(259, 98);
            this.btnByCrypt.Name = "btnByCrypt";
            this.btnByCrypt.Size = new System.Drawing.Size(180, 43);
            this.btnByCrypt.TabIndex = 2;
            this.btnByCrypt.Text = "Криптографія";
            this.btnByCrypt.UseVisualStyleBackColor = true;
            this.btnByCrypt.Click += new System.EventHandler(this.btnByCrypt_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(165, 185);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(169, 36);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Вихід";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(498, 240);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnByCrypt);
            this.Controls.Add(this.btnByUsers);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainForm";
            this.Text = "Система інформаційної безпеки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button btnByUsers;
        private Button btnByCrypt;
        private Button btnBack;
    }
}