namespace Personal_Finance
{
    partial class AddClient_EditDossiers
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
            this.components = new System.ComponentModel.Container();
            this.clients_datagrid = new System.Windows.Forms.DataGridView();
            this.ident_number = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.Label();
            this.sur_name = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.add_client = new System.Windows.Forms.Button();
            this.ident_number_textbox = new System.Windows.Forms.TextBox();
            this.first_name_textbox = new System.Windows.Forms.TextBox();
            this.sur_name_textbox = new System.Windows.Forms.TextBox();
            this.last_name_textbox = new System.Windows.Forms.TextBox();
            this.email_texbox = new System.Windows.Forms.TextBox();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.dossier_datagrid = new System.Windows.Forms.DataGridView();
            this.dossier_year = new System.Windows.Forms.Label();
            this.dossier_year_textbox = new System.Windows.Forms.TextBox();
            this.dossier_status = new System.Windows.Forms.Label();
            this.dossier_min_balance = new System.Windows.Forms.Label();
            this.dossier_min_balance_textbox = new System.Windows.Forms.TextBox();
            this.dossier_change = new System.Windows.Forms.Button();
            this.client_change = new System.Windows.Forms.Button();
            this.chosen_id_clients_label = new System.Windows.Forms.Label();
            this.chosen_id_clients = new System.Windows.Forms.Label();
            this.no_client_chosen = new System.Windows.Forms.Label();
            this.dossier_chosen_id_label = new System.Windows.Forms.Label();
            this.dossier_chosen_id = new System.Windows.Forms.Label();
            this.no_chosen_dossier = new System.Windows.Forms.Label();
            this.closed_dossier = new System.Windows.Forms.Label();
            this.clients_groupbox = new System.Windows.Forms.GroupBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.search_client = new System.Windows.Forms.Button();
            this.dossiers_groupbox = new System.Windows.Forms.GroupBox();
            this.dossiers_status_combobox = new System.Windows.Forms.ComboBox();
            this.escape_button = new System.Windows.Forms.Button();
            this.Tip_for_search_client = new System.Windows.Forms.ToolTip(this.components);
            this.Tip_for_clear_button = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clients_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossier_datagrid)).BeginInit();
            this.clients_groupbox.SuspendLayout();
            this.dossiers_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clients_datagrid
            // 
            this.clients_datagrid.AllowUserToAddRows = false;
            this.clients_datagrid.AllowUserToDeleteRows = false;
            this.clients_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clients_datagrid.Location = new System.Drawing.Point(6, 216);
            this.clients_datagrid.Name = "clients_datagrid";
            this.clients_datagrid.ReadOnly = true;
            this.clients_datagrid.Size = new System.Drawing.Size(472, 184);
            this.clients_datagrid.TabIndex = 0;
            this.clients_datagrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.clients_datagrid_DataBindingComplete);
            this.clients_datagrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.clients_datagrid_RowHeaderMouseClick);
            // 
            // ident_number
            // 
            this.ident_number.AutoSize = true;
            this.ident_number.Location = new System.Drawing.Point(8, 30);
            this.ident_number.Name = "ident_number";
            this.ident_number.Size = new System.Drawing.Size(115, 16);
            this.ident_number.TabIndex = 1;
            this.ident_number.Text = "ЕГН на клиента:";
            // 
            // first_name
            // 
            this.first_name.AutoSize = true;
            this.first_name.Location = new System.Drawing.Point(8, 57);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(114, 16);
            this.first_name.TabIndex = 2;
            this.first_name.Text = "Име на клиента:";
            // 
            // sur_name
            // 
            this.sur_name.AutoSize = true;
            this.sur_name.Location = new System.Drawing.Point(8, 86);
            this.sur_name.Name = "sur_name";
            this.sur_name.Size = new System.Drawing.Size(146, 16);
            this.sur_name.TabIndex = 3;
            this.sur_name.Text = "Презиме на клиента:";
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Location = new System.Drawing.Point(8, 114);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(146, 16);
            this.last_name.TabIndex = 4;
            this.last_name.Text = "Фамилия на клиента:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(7, 142);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(130, 16);
            this.email.TabIndex = 5;
            this.email.Text = "Имейл на клиента:";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(7, 170);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(147, 16);
            this.phone.TabIndex = 6;
            this.phone.Text = "Телефон на клиента:";
            // 
            // add_client
            // 
            this.add_client.Location = new System.Drawing.Point(347, 21);
            this.add_client.Name = "add_client";
            this.add_client.Size = new System.Drawing.Size(122, 41);
            this.add_client.TabIndex = 7;
            this.add_client.Text = "Добавете клиента";
            this.add_client.UseVisualStyleBackColor = true;
            this.add_client.Click += new System.EventHandler(this.add_client_Click);
            // 
            // ident_number_textbox
            // 
            this.ident_number_textbox.Location = new System.Drawing.Point(160, 27);
            this.ident_number_textbox.Name = "ident_number_textbox";
            this.ident_number_textbox.Size = new System.Drawing.Size(166, 22);
            this.ident_number_textbox.TabIndex = 8;
            this.ident_number_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // first_name_textbox
            // 
            this.first_name_textbox.Location = new System.Drawing.Point(160, 55);
            this.first_name_textbox.Name = "first_name_textbox";
            this.first_name_textbox.Size = new System.Drawing.Size(166, 22);
            this.first_name_textbox.TabIndex = 9;
            // 
            // sur_name_textbox
            // 
            this.sur_name_textbox.Location = new System.Drawing.Point(160, 83);
            this.sur_name_textbox.Name = "sur_name_textbox";
            this.sur_name_textbox.Size = new System.Drawing.Size(166, 22);
            this.sur_name_textbox.TabIndex = 10;
            // 
            // last_name_textbox
            // 
            this.last_name_textbox.Location = new System.Drawing.Point(160, 111);
            this.last_name_textbox.Name = "last_name_textbox";
            this.last_name_textbox.Size = new System.Drawing.Size(166, 22);
            this.last_name_textbox.TabIndex = 11;
            // 
            // email_texbox
            // 
            this.email_texbox.Location = new System.Drawing.Point(160, 139);
            this.email_texbox.Name = "email_texbox";
            this.email_texbox.Size = new System.Drawing.Size(166, 22);
            this.email_texbox.TabIndex = 12;
            // 
            // phone_textbox
            // 
            this.phone_textbox.Location = new System.Drawing.Point(160, 167);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(166, 22);
            this.phone_textbox.TabIndex = 13;
            this.phone_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dossier_datagrid
            // 
            this.dossier_datagrid.AllowUserToAddRows = false;
            this.dossier_datagrid.AllowUserToDeleteRows = false;
            this.dossier_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dossier_datagrid.Location = new System.Drawing.Point(6, 216);
            this.dossier_datagrid.Name = "dossier_datagrid";
            this.dossier_datagrid.ReadOnly = true;
            this.dossier_datagrid.Size = new System.Drawing.Size(412, 184);
            this.dossier_datagrid.TabIndex = 14;
            this.dossier_datagrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dossier_datagrid_DataBindingComplete);
            this.dossier_datagrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dossier_datagrid_RowHeaderMouseClick);
            // 
            // dossier_year
            // 
            this.dossier_year.AutoSize = true;
            this.dossier_year.Location = new System.Drawing.Point(7, 33);
            this.dossier_year.Name = "dossier_year";
            this.dossier_year.Size = new System.Drawing.Size(119, 16);
            this.dossier_year.TabIndex = 15;
            this.dossier_year.Text = "Година на досие:";
            // 
            // dossier_year_textbox
            // 
            this.dossier_year_textbox.Location = new System.Drawing.Point(210, 30);
            this.dossier_year_textbox.Name = "dossier_year_textbox";
            this.dossier_year_textbox.Size = new System.Drawing.Size(150, 22);
            this.dossier_year_textbox.TabIndex = 16;
            this.dossier_year_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dossier_status
            // 
            this.dossier_status.AutoSize = true;
            this.dossier_status.Location = new System.Drawing.Point(7, 68);
            this.dossier_status.Name = "dossier_status";
            this.dossier_status.Size = new System.Drawing.Size(118, 16);
            this.dossier_status.TabIndex = 17;
            this.dossier_status.Text = "Статус на досие:";
            // 
            // dossier_min_balance
            // 
            this.dossier_min_balance.AutoSize = true;
            this.dossier_min_balance.Location = new System.Drawing.Point(6, 102);
            this.dossier_min_balance.Name = "dossier_min_balance";
            this.dossier_min_balance.Size = new System.Drawing.Size(198, 16);
            this.dossier_min_balance.TabIndex = 19;
            this.dossier_min_balance.Text = "Минимален баланс на досие:";
            // 
            // dossier_min_balance_textbox
            // 
            this.dossier_min_balance_textbox.Location = new System.Drawing.Point(210, 102);
            this.dossier_min_balance_textbox.Name = "dossier_min_balance_textbox";
            this.dossier_min_balance_textbox.Size = new System.Drawing.Size(150, 22);
            this.dossier_min_balance_textbox.TabIndex = 20;
            this.dossier_min_balance_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dossier_change
            // 
            this.dossier_change.Location = new System.Drawing.Point(6, 148);
            this.dossier_change.Name = "dossier_change";
            this.dossier_change.Size = new System.Drawing.Size(150, 42);
            this.dossier_change.TabIndex = 21;
            this.dossier_change.Text = "Редактирайте досието";
            this.dossier_change.UseVisualStyleBackColor = true;
            this.dossier_change.Click += new System.EventHandler(this.dossier_change_Click);
            // 
            // client_change
            // 
            this.client_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.client_change.Location = new System.Drawing.Point(347, 68);
            this.client_change.Name = "client_change";
            this.client_change.Size = new System.Drawing.Size(122, 40);
            this.client_change.TabIndex = 23;
            this.client_change.Text = "Редактирайте клиента";
            this.client_change.UseVisualStyleBackColor = true;
            this.client_change.Click += new System.EventHandler(this.client_change_Click);
            // 
            // chosen_id_clients_label
            // 
            this.chosen_id_clients_label.AutoSize = true;
            this.chosen_id_clients_label.Location = new System.Drawing.Point(3, 197);
            this.chosen_id_clients_label.Name = "chosen_id_clients_label";
            this.chosen_id_clients_label.Size = new System.Drawing.Size(218, 16);
            this.chosen_id_clients_label.TabIndex = 24;
            this.chosen_id_clients_label.Text = "Избран идент. номер на клиент:";
            // 
            // chosen_id_clients
            // 
            this.chosen_id_clients.AutoSize = true;
            this.chosen_id_clients.ForeColor = System.Drawing.Color.Red;
            this.chosen_id_clients.Location = new System.Drawing.Point(227, 197);
            this.chosen_id_clients.Name = "chosen_id_clients";
            this.chosen_id_clients.Size = new System.Drawing.Size(45, 16);
            this.chosen_id_clients.TabIndex = 25;
            this.chosen_id_clients.Text = "label1";
            // 
            // no_client_chosen
            // 
            this.no_client_chosen.AutoSize = true;
            this.no_client_chosen.ForeColor = System.Drawing.Color.Red;
            this.no_client_chosen.Location = new System.Drawing.Point(227, 197);
            this.no_client_chosen.Name = "no_client_chosen";
            this.no_client_chosen.Size = new System.Drawing.Size(203, 16);
            this.no_client_chosen.TabIndex = 27;
            this.no_client_chosen.Text = "Моля изберете ред на клиент";
            // 
            // dossier_chosen_id_label
            // 
            this.dossier_chosen_id_label.AutoSize = true;
            this.dossier_chosen_id_label.Location = new System.Drawing.Point(6, 197);
            this.dossier_chosen_id_label.Name = "dossier_chosen_id_label";
            this.dossier_chosen_id_label.Size = new System.Drawing.Size(211, 16);
            this.dossier_chosen_id_label.TabIndex = 28;
            this.dossier_chosen_id_label.Text = "Избран идент. номер на досие:";
            // 
            // dossier_chosen_id
            // 
            this.dossier_chosen_id.AutoSize = true;
            this.dossier_chosen_id.ForeColor = System.Drawing.Color.Red;
            this.dossier_chosen_id.Location = new System.Drawing.Point(223, 197);
            this.dossier_chosen_id.Name = "dossier_chosen_id";
            this.dossier_chosen_id.Size = new System.Drawing.Size(45, 16);
            this.dossier_chosen_id.TabIndex = 29;
            this.dossier_chosen_id.Text = "label1";
            // 
            // no_chosen_dossier
            // 
            this.no_chosen_dossier.AutoSize = true;
            this.no_chosen_dossier.ForeColor = System.Drawing.Color.Red;
            this.no_chosen_dossier.Location = new System.Drawing.Point(223, 197);
            this.no_chosen_dossier.Name = "no_chosen_dossier";
            this.no_chosen_dossier.Size = new System.Drawing.Size(196, 16);
            this.no_chosen_dossier.TabIndex = 30;
            this.no_chosen_dossier.Text = "Моля изберете ред на досие";
            // 
            // closed_dossier
            // 
            this.closed_dossier.AutoSize = true;
            this.closed_dossier.ForeColor = System.Drawing.Color.Red;
            this.closed_dossier.Location = new System.Drawing.Point(162, 161);
            this.closed_dossier.Name = "closed_dossier";
            this.closed_dossier.Size = new System.Drawing.Size(158, 16);
            this.closed_dossier.TabIndex = 32;
            this.closed_dossier.Text = "Досието е приключено";
            // 
            // clients_groupbox
            // 
            this.clients_groupbox.Controls.Add(this.clear_button);
            this.clients_groupbox.Controls.Add(this.search_client);
            this.clients_groupbox.Controls.Add(this.clients_datagrid);
            this.clients_groupbox.Controls.Add(this.no_client_chosen);
            this.clients_groupbox.Controls.Add(this.client_change);
            this.clients_groupbox.Controls.Add(this.chosen_id_clients);
            this.clients_groupbox.Controls.Add(this.ident_number);
            this.clients_groupbox.Controls.Add(this.first_name);
            this.clients_groupbox.Controls.Add(this.sur_name);
            this.clients_groupbox.Controls.Add(this.last_name);
            this.clients_groupbox.Controls.Add(this.email);
            this.clients_groupbox.Controls.Add(this.phone);
            this.clients_groupbox.Controls.Add(this.add_client);
            this.clients_groupbox.Controls.Add(this.phone_textbox);
            this.clients_groupbox.Controls.Add(this.first_name_textbox);
            this.clients_groupbox.Controls.Add(this.ident_number_textbox);
            this.clients_groupbox.Controls.Add(this.last_name_textbox);
            this.clients_groupbox.Controls.Add(this.email_texbox);
            this.clients_groupbox.Controls.Add(this.sur_name_textbox);
            this.clients_groupbox.Controls.Add(this.chosen_id_clients_label);
            this.clients_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clients_groupbox.Location = new System.Drawing.Point(12, 12);
            this.clients_groupbox.Name = "clients_groupbox";
            this.clients_groupbox.Size = new System.Drawing.Size(484, 406);
            this.clients_groupbox.TabIndex = 33;
            this.clients_groupbox.TabStop = false;
            this.clients_groupbox.Text = "Клиенти";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(347, 161);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(122, 33);
            this.clear_button.TabIndex = 29;
            this.clear_button.Text = "Изчистване";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // search_client
            // 
            this.search_client.Location = new System.Drawing.Point(347, 114);
            this.search_client.Name = "search_client";
            this.search_client.Size = new System.Drawing.Size(122, 41);
            this.search_client.TabIndex = 28;
            this.search_client.Text = "Търсене на клиент";
            this.search_client.UseVisualStyleBackColor = true;
            this.search_client.Click += new System.EventHandler(this.search_client_Click);
            this.search_client.MouseLeave += new System.EventHandler(this.search_client_MouseLeave);
            this.search_client.MouseHover += new System.EventHandler(this.search_client_MouseHover);
            // 
            // dossiers_groupbox
            // 
            this.dossiers_groupbox.Controls.Add(this.dossier_datagrid);
            this.dossiers_groupbox.Controls.Add(this.dossier_chosen_id);
            this.dossiers_groupbox.Controls.Add(this.no_chosen_dossier);
            this.dossiers_groupbox.Controls.Add(this.dossiers_status_combobox);
            this.dossiers_groupbox.Controls.Add(this.dossier_year);
            this.dossiers_groupbox.Controls.Add(this.dossier_chosen_id_label);
            this.dossiers_groupbox.Controls.Add(this.dossier_year_textbox);
            this.dossiers_groupbox.Controls.Add(this.closed_dossier);
            this.dossiers_groupbox.Controls.Add(this.dossier_change);
            this.dossiers_groupbox.Controls.Add(this.dossier_status);
            this.dossiers_groupbox.Controls.Add(this.dossier_min_balance_textbox);
            this.dossiers_groupbox.Controls.Add(this.dossier_min_balance);
            this.dossiers_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dossiers_groupbox.Location = new System.Drawing.Point(502, 12);
            this.dossiers_groupbox.Name = "dossiers_groupbox";
            this.dossiers_groupbox.Size = new System.Drawing.Size(424, 406);
            this.dossiers_groupbox.TabIndex = 35;
            this.dossiers_groupbox.TabStop = false;
            this.dossiers_groupbox.Text = "Досиета";
            // 
            // dossiers_status_combobox
            // 
            this.dossiers_status_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dossiers_status_combobox.FormattingEnabled = true;
            this.dossiers_status_combobox.Items.AddRange(new object[] {
            "Отворено досие",
            "Приключено досие"});
            this.dossiers_status_combobox.Location = new System.Drawing.Point(210, 68);
            this.dossiers_status_combobox.Name = "dossiers_status_combobox";
            this.dossiers_status_combobox.Size = new System.Drawing.Size(150, 24);
            this.dossiers_status_combobox.TabIndex = 33;
            // 
            // escape_button
            // 
            this.escape_button.Location = new System.Drawing.Point(834, 424);
            this.escape_button.Name = "escape_button";
            this.escape_button.Size = new System.Drawing.Size(92, 25);
            this.escape_button.TabIndex = 36;
            this.escape_button.Text = "Изход";
            this.escape_button.UseVisualStyleBackColor = true;
            this.escape_button.Click += new System.EventHandler(this.escape_button_Click);
            // 
            // Tip_for_search_client
            // 
            this.Tip_for_search_client.IsBalloon = true;
            this.Tip_for_search_client.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.Tip_for_search_client.ToolTipTitle = "Внимание";
            // 
            // AddClient_EditDossiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 455);
            this.ControlBox = false;
            this.Controls.Add(this.escape_button);
            this.Controls.Add(this.clients_groupbox);
            this.Controls.Add(this.dossiers_groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddClient_EditDossiers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавяне на клиенти и редактиране на досиетата им";
            ((System.ComponentModel.ISupportInitialize)(this.clients_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossier_datagrid)).EndInit();
            this.clients_groupbox.ResumeLayout(false);
            this.clients_groupbox.PerformLayout();
            this.dossiers_groupbox.ResumeLayout(false);
            this.dossiers_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView clients_datagrid;
        private System.Windows.Forms.Label ident_number;
        private System.Windows.Forms.Label first_name;
        private System.Windows.Forms.Label sur_name;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Button add_client;
        private System.Windows.Forms.TextBox ident_number_textbox;
        private System.Windows.Forms.TextBox first_name_textbox;
        private System.Windows.Forms.TextBox sur_name_textbox;
        private System.Windows.Forms.TextBox last_name_textbox;
        private System.Windows.Forms.TextBox email_texbox;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.DataGridView dossier_datagrid;
        private System.Windows.Forms.Label dossier_year;
        private System.Windows.Forms.TextBox dossier_year_textbox;
        private System.Windows.Forms.Label dossier_status;
        private System.Windows.Forms.Label dossier_min_balance;
        private System.Windows.Forms.TextBox dossier_min_balance_textbox;
        private System.Windows.Forms.Button dossier_change;
        private System.Windows.Forms.Button client_change;
        private System.Windows.Forms.Label chosen_id_clients_label;
        private System.Windows.Forms.Label chosen_id_clients;
        private System.Windows.Forms.Label no_client_chosen;
        private System.Windows.Forms.Label dossier_chosen_id_label;
        private System.Windows.Forms.Label dossier_chosen_id;
        private System.Windows.Forms.Label no_chosen_dossier;
        private System.Windows.Forms.Label closed_dossier;
        private System.Windows.Forms.GroupBox clients_groupbox;
        private System.Windows.Forms.GroupBox dossiers_groupbox;
        private System.Windows.Forms.ComboBox dossiers_status_combobox;
        private System.Windows.Forms.Button escape_button;
        private System.Windows.Forms.Button search_client;
        private System.Windows.Forms.ToolTip Tip_for_search_client;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.ToolTip Tip_for_clear_button;
    }
}