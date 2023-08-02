namespace Personal_Finance
{
    partial class Personal_Finance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personal_Finance));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.login = new System.Windows.Forms.ToolStripMenuItem();
            this.clients = new System.Windows.Forms.ToolStripMenuItem();
            this.новКлиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списъкСКлиентитеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dossiers = new System.Windows.Forms.ToolStripMenuItem();
            this.търсенеИДобавянеНаДосиетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавянеНаПриходиВДосиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.login,
            this.clients,
            this.dossiers,
            this.logout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // login
            // 
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(44, 20);
            this.login.Text = "Вход";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // clients
            // 
            this.clients.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новКлиентToolStripMenuItem,
            this.списъкСКлиентитеToolStripMenuItem});
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(65, 20);
            this.clients.Text = "Клиенти";
            // 
            // новКлиентToolStripMenuItem
            // 
            this.новКлиентToolStripMenuItem.Name = "новКлиентToolStripMenuItem";
            this.новКлиентToolStripMenuItem.Size = new System.Drawing.Size(365, 22);
            this.новКлиентToolStripMenuItem.Text = "Добавяне на клиенти и редактиране на досиетата им";
            this.новКлиентToolStripMenuItem.Click += new System.EventHandler(this.новКлиентToolStripMenuItem_Click);
            // 
            // списъкСКлиентитеToolStripMenuItem
            // 
            this.списъкСКлиентитеToolStripMenuItem.Name = "списъкСКлиентитеToolStripMenuItem";
            this.списъкСКлиентитеToolStripMenuItem.Size = new System.Drawing.Size(365, 22);
            this.списъкСКлиентитеToolStripMenuItem.Text = "Търсене на клиенти и добавяне на техни адреси";
            this.списъкСКлиентитеToolStripMenuItem.Click += new System.EventHandler(this.списъкСКлиентитеToolStripMenuItem_Click);
            // 
            // dossiers
            // 
            this.dossiers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.търсенеИДобавянеНаДосиетаToolStripMenuItem,
            this.добавянеНаПриходиВДосиеToolStripMenuItem});
            this.dossiers.Name = "dossiers";
            this.dossiers.Size = new System.Drawing.Size(64, 20);
            this.dossiers.Text = "Досиета";
            // 
            // търсенеИДобавянеНаДосиетаToolStripMenuItem
            // 
            this.търсенеИДобавянеНаДосиетаToolStripMenuItem.Name = "търсенеИДобавянеНаДосиетаToolStripMenuItem";
            this.търсенеИДобавянеНаДосиетаToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.търсенеИДобавянеНаДосиетаToolStripMenuItem.Text = "Търсене и добавяне на досиета";
            this.търсенеИДобавянеНаДосиетаToolStripMenuItem.Click += new System.EventHandler(this.търсенеИДобавянеНаДосиетаToolStripMenuItem_Click);
            // 
            // добавянеНаПриходиВДосиеToolStripMenuItem
            // 
            this.добавянеНаПриходиВДосиеToolStripMenuItem.Name = "добавянеНаПриходиВДосиеToolStripMenuItem";
            this.добавянеНаПриходиВДосиеToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.добавянеНаПриходиВДосиеToolStripMenuItem.Text = "Добавяне на приходи/разходи по досие";
            this.добавянеНаПриходиВДосиеToolStripMenuItem.Click += new System.EventHandler(this.добавянеНаПриходиВДосиеToolStripMenuItem_Click);
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(51, 20);
            this.logout.Text = "Изход";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Personal_Finance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(419, 280);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Personal_Finance";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лични финанси";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clients;
        private System.Windows.Forms.ToolStripMenuItem новКлиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dossiers;
        private System.Windows.Forms.ToolStripMenuItem списъкСКлиентитеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem търсенеИДобавянеНаДосиетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem login;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.ToolStripMenuItem добавянеНаПриходиВДосиеToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

