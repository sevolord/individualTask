
namespace WindowsFormsApp1
{
    partial class authorizationInterface
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.BLogin = new System.Windows.Forms.Button();
            this.BNewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пользователь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(117, 29);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(156, 20);
            this.TBUsername.TabIndex = 2;
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(117, 60);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(156, 20);
            this.TBPassword.TabIndex = 3;
            // 
            // BLogin
            // 
            this.BLogin.Location = new System.Drawing.Point(34, 100);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(75, 23);
            this.BLogin.TabIndex = 4;
            this.BLogin.Text = "Войти";
            this.BLogin.UseVisualStyleBackColor = true;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // BNewUser
            // 
            this.BNewUser.Location = new System.Drawing.Point(145, 100);
            this.BNewUser.Name = "BNewUser";
            this.BNewUser.Size = new System.Drawing.Size(128, 23);
            this.BNewUser.TabIndex = 5;
            this.BNewUser.Text = "Зарегестрироваться";
            this.BNewUser.UseVisualStyleBackColor = true;
            this.BNewUser.Click += new System.EventHandler(this.BNewUser_Click);
            // 
            // authorizationInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.BNewUser);
            this.Controls.Add(this.BLogin);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "authorizationInterface";
            this.Text = "Форма авторизации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.Button BNewUser;
    }
}