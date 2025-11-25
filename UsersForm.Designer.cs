namespace Курсова
{
    partial class UsersForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnByAdd = new System.Windows.Forms.Button();
            this.btnByDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(59, 222);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 36);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnByAdd
            // 
            this.btnByAdd.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByAdd.Location = new System.Drawing.Point(41, 75);
            this.btnByAdd.Name = "btnByAdd";
            this.btnByAdd.Size = new System.Drawing.Size(246, 46);
            this.btnByAdd.TabIndex = 1;
            this.btnByAdd.Text = "Реєстрація користувачів";
            this.btnByAdd.UseVisualStyleBackColor = true;
            this.btnByAdd.Click += new System.EventHandler(this.btnByAdd_Click);
            // 
            // btnByDelete
            // 
            this.btnByDelete.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByDelete.Location = new System.Drawing.Point(41, 141);
            this.btnByDelete.Name = "btnByDelete";
            this.btnByDelete.Size = new System.Drawing.Size(246, 44);
            this.btnByDelete.TabIndex = 2;
            this.btnByDelete.Text = "Видалення користувачів";
            this.btnByDelete.UseVisualStyleBackColor = true;
            this.btnByDelete.Click += new System.EventHandler(this.btnByDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(92, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Головне меню";
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 283);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnByDelete);
            this.Controls.Add(this.btnByAdd);
            this.Controls.Add(this.btnBack);
            this.Name = "UsersForm";
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnByAdd;
        private System.Windows.Forms.Button btnByDelete;
        private System.Windows.Forms.Label label1;
    }
}