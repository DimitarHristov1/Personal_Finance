namespace Personal_Finance
{
    partial class Login
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
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(15, 32);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(111, 13);
            this.username.TabIndex = 0;
            this.username.Text = "Потребителско име:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(15, 62);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(48, 13);
            this.password.TabIndex = 1;
            this.password.Text = "Парола:";
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(132, 29);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(100, 20);
            this.username_textbox.TabIndex = 2;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(132, 59);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(100, 20);
            this.password_textbox.TabIndex = 3;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(252, 41);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(100, 25);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Вход";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 101);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Влизане в системата";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button login_button;
    }
}