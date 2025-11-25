namespace Курсова
{
    partial class Cryptography
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.btnByEncrypt = new System.Windows.Forms.Button();
            this.btnbyDecrypt = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerateKeys.Location = new System.Drawing.Point(30, 57);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(226, 34);
            this.btnGenerateKeys.TabIndex = 0;
            this.btnGenerateKeys.Text = "Генерація ключа";
            this.btnGenerateKeys.UseVisualStyleBackColor = true;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // btnByEncrypt
            // 
            this.btnByEncrypt.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnByEncrypt.Location = new System.Drawing.Point(30, 102);
            this.btnByEncrypt.Name = "btnByEncrypt";
            this.btnByEncrypt.Size = new System.Drawing.Size(226, 34);
            this.btnByEncrypt.TabIndex = 1;
            this.btnByEncrypt.Text = "Шифрування";
            this.btnByEncrypt.UseVisualStyleBackColor = true;
            this.btnByEncrypt.Click += new System.EventHandler(this.btnByEncrypt_Click);
            // 
            // btnbyDecrypt
            // 
            this.btnbyDecrypt.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnbyDecrypt.Location = new System.Drawing.Point(30, 146);
            this.btnbyDecrypt.Name = "btnbyDecrypt";
            this.btnbyDecrypt.Size = new System.Drawing.Size(226, 34);
            this.btnbyDecrypt.TabIndex = 2;
            this.btnbyDecrypt.Text = "Дешифрування";
            this.btnbyDecrypt.UseVisualStyleBackColor = true;
            this.btnbyDecrypt.Click += new System.EventHandler(this.btnbyDecrypt_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(30, 211);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(226, 34);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Криптографія";
            // 
            // Cryptography
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnbyDecrypt);
            this.Controls.Add(this.btnByEncrypt);
            this.Controls.Add(this.btnGenerateKeys);
            this.Name = "Cryptography";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.Button btnByEncrypt;
        private System.Windows.Forms.Button btnbyDecrypt;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}