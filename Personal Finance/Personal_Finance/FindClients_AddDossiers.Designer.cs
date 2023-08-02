namespace Personal_Finance
{
    partial class FindClients_AddDossiers
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
            this.last_name_textbox = new System.Windows.Forms.TextBox();
            this.sur_name_textbox = new System.Windows.Forms.TextBox();
            this.first_name_textbox = new System.Windows.Forms.TextBox();
            this.ident_number_textbox = new System.Windows.Forms.TextBox();
            this.search_client = new System.Windows.Forms.Button();
            this.last_name = new System.Windows.Forms.Label();
            this.sur_name = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.Label();
            this.ident_number = new System.Windows.Forms.Label();
            this.no_chosen_client_label = new System.Windows.Forms.Label();
            this.chosen_id_clients_label = new System.Windows.Forms.Label();
            this.clients_datagrid = new System.Windows.Forms.DataGridView();
            this.dossier_search = new System.Windows.Forms.Button();
            this.dossier_search_id_textbox = new System.Windows.Forms.TextBox();
            this.dossier_search_id = new System.Windows.Forms.Label();
            this.dossier_search_status = new System.Windows.Forms.Label();
            this.dossier_search_year_textbox = new System.Windows.Forms.TextBox();
            this.dossier_search_year = new System.Windows.Forms.Label();
            this.dossier_datagrid = new System.Windows.Forms.DataGridView();
            this.add_dossier = new System.Windows.Forms.Button();
            this.chosen_id_clients = new System.Windows.Forms.Label();
            this.dossier_min_balance_textbox = new System.Windows.Forms.TextBox();
            this.dossier_min_balance = new System.Windows.Forms.Label();
            this.dossier_status = new System.Windows.Forms.Label();
            this.dossier_year_textbox = new System.Windows.Forms.TextBox();
            this.dossier_year = new System.Windows.Forms.Label();
            this.add_groupbox = new System.Windows.Forms.GroupBox();
            this.dossiers_add_status_combobox = new System.Windows.Forms.ComboBox();
            this.clients_groupbox = new System.Windows.Forms.GroupBox();
            this.clear_button_clients = new System.Windows.Forms.Button();
            this.search_dossiers = new System.Windows.Forms.GroupBox();
            this.clear_button_dossiers = new System.Windows.Forms.Button();
            this.dossiers_status_search_combobox = new System.Windows.Forms.ComboBox();
            this.dossiers_groupbox = new System.Windows.Forms.GroupBox();
            this.Tip_for_clients = new System.Windows.Forms.ToolTip(this.components);
            this.Tip_for_dossiers = new System.Windows.Forms.ToolTip(this.components);
            this.escape_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clients_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossier_datagrid)).BeginInit();
            this.add_groupbox.SuspendLayout();
            this.clients_groupbox.SuspendLayout();
            this.search_dossiers.SuspendLayout();
            this.dossiers_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // last_name_textbox
            // 
            this.last_name_textbox.Location = new System.Drawing.Point(159, 110);
            this.last_name_textbox.Name = "last_name_textbox";
            this.last_name_textbox.Size = new System.Drawing.Size(160, 22);
            this.last_name_textbox.TabIndex = 24;
            // 
            // sur_name_textbox
            // 
            this.sur_name_textbox.Location = new System.Drawing.Point(159, 82);
            this.sur_name_textbox.Name = "sur_name_textbox";
            this.sur_name_textbox.Size = new System.Drawing.Size(160, 22);
            this.sur_name_textbox.TabIndex = 23;
            // 
            // first_name_textbox
            // 
            this.first_name_textbox.Location = new System.Drawing.Point(159, 54);
            this.first_name_textbox.Name = "first_name_textbox";
            this.first_name_textbox.Size = new System.Drawing.Size(160, 22);
            this.first_name_textbox.TabIndex = 22;
            // 
            // ident_number_textbox
            // 
            this.ident_number_textbox.Location = new System.Drawing.Point(159, 26);
            this.ident_number_textbox.Name = "ident_number_textbox";
            this.ident_number_textbox.Size = new System.Drawing.Size(160, 22);
            this.ident_number_textbox.TabIndex = 21;
            this.ident_number_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // search_client
            // 
            this.search_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.search_client.Location = new System.Drawing.Point(346, 38);
            this.search_client.Name = "search_client";
            this.search_client.Size = new System.Drawing.Size(122, 33);
            this.search_client.TabIndex = 20;
            this.search_client.Text = "Търси клиент";
            this.search_client.UseVisualStyleBackColor = true;
            this.search_client.Click += new System.EventHandler(this.search_client_Click);
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Location = new System.Drawing.Point(6, 110);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(149, 16);
            this.last_name.TabIndex = 17;
            this.last_name.Text = "Търсене по фамилия:";
            // 
            // sur_name
            // 
            this.sur_name.AutoSize = true;
            this.sur_name.Location = new System.Drawing.Point(6, 85);
            this.sur_name.Name = "sur_name";
            this.sur_name.Size = new System.Drawing.Size(147, 16);
            this.sur_name.TabIndex = 16;
            this.sur_name.Text = "Търсене по презиме:";
            // 
            // first_name
            // 
            this.first_name.AutoSize = true;
            this.first_name.Location = new System.Drawing.Point(6, 57);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(115, 16);
            this.first_name.TabIndex = 15;
            this.first_name.Text = "Търсене по име:";
            // 
            // ident_number
            // 
            this.ident_number.AutoSize = true;
            this.ident_number.Location = new System.Drawing.Point(6, 30);
            this.ident_number.Name = "ident_number";
            this.ident_number.Size = new System.Drawing.Size(118, 16);
            this.ident_number.TabIndex = 14;
            this.ident_number.Text = "Търсене по ЕГН:";
            // 
            // no_chosen_client_label
            // 
            this.no_chosen_client_label.AutoSize = true;
            this.no_chosen_client_label.ForeColor = System.Drawing.Color.Red;
            this.no_chosen_client_label.Location = new System.Drawing.Point(227, 158);
            this.no_chosen_client_label.Name = "no_chosen_client_label";
            this.no_chosen_client_label.Size = new System.Drawing.Size(203, 16);
            this.no_chosen_client_label.TabIndex = 37;
            this.no_chosen_client_label.Text = "Моля изберете ред на клиент";
            // 
            // chosen_id_clients_label
            // 
            this.chosen_id_clients_label.AutoSize = true;
            this.chosen_id_clients_label.Location = new System.Drawing.Point(3, 158);
            this.chosen_id_clients_label.Name = "chosen_id_clients_label";
            this.chosen_id_clients_label.Size = new System.Drawing.Size(218, 16);
            this.chosen_id_clients_label.TabIndex = 35;
            this.chosen_id_clients_label.Text = "Избран идент. номер на клиент:";
            // 
            // clients_datagrid
            // 
            this.clients_datagrid.AllowUserToAddRows = false;
            this.clients_datagrid.AllowUserToDeleteRows = false;
            this.clients_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clients_datagrid.Location = new System.Drawing.Point(6, 180);
            this.clients_datagrid.Name = "clients_datagrid";
            this.clients_datagrid.ReadOnly = true;
            this.clients_datagrid.Size = new System.Drawing.Size(464, 175);
            this.clients_datagrid.TabIndex = 34;
            this.clients_datagrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.clients_datagrid_DataBindingComplete);
            this.clients_datagrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.clients_datagrid_RowHeaderMouseClick);
            // 
            // dossier_search
            // 
            this.dossier_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dossier_search.Location = new System.Drawing.Point(189, 112);
            this.dossier_search.Name = "dossier_search";
            this.dossier_search.Size = new System.Drawing.Size(135, 27);
            this.dossier_search.TabIndex = 45;
            this.dossier_search.Text = "Търси досие";
            this.dossier_search.UseVisualStyleBackColor = true;
            this.dossier_search.Click += new System.EventHandler(this.dossier_search_Click);
            // 
            // dossier_search_id_textbox
            // 
            this.dossier_search_id_textbox.Location = new System.Drawing.Point(204, 23);
            this.dossier_search_id_textbox.Name = "dossier_search_id_textbox";
            this.dossier_search_id_textbox.Size = new System.Drawing.Size(120, 22);
            this.dossier_search_id_textbox.TabIndex = 44;
            this.dossier_search_id_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dossier_search_id
            // 
            this.dossier_search_id.AutoSize = true;
            this.dossier_search_id.Location = new System.Drawing.Point(6, 26);
            this.dossier_search_id.Name = "dossier_search_id";
            this.dossier_search_id.Size = new System.Drawing.Size(192, 16);
            this.dossier_search_id.TabIndex = 43;
            this.dossier_search_id.Text = "Търсене по номер на досие:";
            // 
            // dossier_search_status
            // 
            this.dossier_search_status.AutoSize = true;
            this.dossier_search_status.Location = new System.Drawing.Point(6, 51);
            this.dossier_search_status.Name = "dossier_search_status";
            this.dossier_search_status.Size = new System.Drawing.Size(195, 16);
            this.dossier_search_status.TabIndex = 41;
            this.dossier_search_status.Text = "Търсене по статус на досие:";
            // 
            // dossier_search_year_textbox
            // 
            this.dossier_search_year_textbox.Location = new System.Drawing.Point(204, 75);
            this.dossier_search_year_textbox.Name = "dossier_search_year_textbox";
            this.dossier_search_year_textbox.Size = new System.Drawing.Size(120, 22);
            this.dossier_search_year_textbox.TabIndex = 40;
            this.dossier_search_year_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dossier_search_year
            // 
            this.dossier_search_year.AutoSize = true;
            this.dossier_search_year.Location = new System.Drawing.Point(6, 78);
            this.dossier_search_year.Name = "dossier_search_year";
            this.dossier_search_year.Size = new System.Drawing.Size(197, 16);
            this.dossier_search_year.TabIndex = 39;
            this.dossier_search_year.Text = "Търсене по година на досие:";
            // 
            // dossier_datagrid
            // 
            this.dossier_datagrid.AllowUserToAddRows = false;
            this.dossier_datagrid.AllowUserToDeleteRows = false;
            this.dossier_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dossier_datagrid.Location = new System.Drawing.Point(6, 180);
            this.dossier_datagrid.Name = "dossier_datagrid";
            this.dossier_datagrid.ReadOnly = true;
            this.dossier_datagrid.Size = new System.Drawing.Size(671, 175);
            this.dossier_datagrid.TabIndex = 38;
            this.dossier_datagrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dossier_datagrid_DataBindingComplete);
            // 
            // add_dossier
            // 
            this.add_dossier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.add_dossier.Location = new System.Drawing.Point(114, 112);
            this.add_dossier.Name = "add_dossier";
            this.add_dossier.Size = new System.Drawing.Size(135, 27);
            this.add_dossier.TabIndex = 50;
            this.add_dossier.Text = "Добави досие";
            this.add_dossier.UseVisualStyleBackColor = true;
            this.add_dossier.Click += new System.EventHandler(this.add_dossier_Click);
            // 
            // chosen_id_clients
            // 
            this.chosen_id_clients.AutoSize = true;
            this.chosen_id_clients.ForeColor = System.Drawing.Color.Red;
            this.chosen_id_clients.Location = new System.Drawing.Point(227, 158);
            this.chosen_id_clients.Name = "chosen_id_clients";
            this.chosen_id_clients.Size = new System.Drawing.Size(45, 16);
            this.chosen_id_clients.TabIndex = 51;
            this.chosen_id_clients.Text = "label1";
            // 
            // dossier_min_balance_textbox
            // 
            this.dossier_min_balance_textbox.Location = new System.Drawing.Point(210, 81);
            this.dossier_min_balance_textbox.Name = "dossier_min_balance_textbox";
            this.dossier_min_balance_textbox.Size = new System.Drawing.Size(119, 22);
            this.dossier_min_balance_textbox.TabIndex = 58;
            this.dossier_min_balance_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dossier_min_balance
            // 
            this.dossier_min_balance.AutoSize = true;
            this.dossier_min_balance.Location = new System.Drawing.Point(6, 84);
            this.dossier_min_balance.Name = "dossier_min_balance";
            this.dossier_min_balance.Size = new System.Drawing.Size(198, 16);
            this.dossier_min_balance.TabIndex = 57;
            this.dossier_min_balance.Text = "Минимален баланс на досие:";
            // 
            // dossier_status
            // 
            this.dossier_status.AutoSize = true;
            this.dossier_status.Location = new System.Drawing.Point(6, 56);
            this.dossier_status.Name = "dossier_status";
            this.dossier_status.Size = new System.Drawing.Size(118, 16);
            this.dossier_status.TabIndex = 55;
            this.dossier_status.Text = "Статус на досие:";
            // 
            // dossier_year_textbox
            // 
            this.dossier_year_textbox.Location = new System.Drawing.Point(210, 28);
            this.dossier_year_textbox.Name = "dossier_year_textbox";
            this.dossier_year_textbox.Size = new System.Drawing.Size(119, 22);
            this.dossier_year_textbox.TabIndex = 54;
            this.dossier_year_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dossier_year
            // 
            this.dossier_year.AutoSize = true;
            this.dossier_year.Location = new System.Drawing.Point(6, 31);
            this.dossier_year.Name = "dossier_year";
            this.dossier_year.Size = new System.Drawing.Size(119, 16);
            this.dossier_year.TabIndex = 53;
            this.dossier_year.Text = "Година на досие:";
            // 
            // add_groupbox
            // 
            this.add_groupbox.Controls.Add(this.dossiers_add_status_combobox);
            this.add_groupbox.Controls.Add(this.dossier_min_balance);
            this.add_groupbox.Controls.Add(this.dossier_year_textbox);
            this.add_groupbox.Controls.Add(this.add_dossier);
            this.add_groupbox.Controls.Add(this.dossier_year);
            this.add_groupbox.Controls.Add(this.dossier_min_balance_textbox);
            this.add_groupbox.Controls.Add(this.dossier_status);
            this.add_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_groupbox.Location = new System.Drawing.Point(342, 26);
            this.add_groupbox.Name = "add_groupbox";
            this.add_groupbox.Size = new System.Drawing.Size(335, 148);
            this.add_groupbox.TabIndex = 59;
            this.add_groupbox.TabStop = false;
            this.add_groupbox.Text = "Добавяне на досие";
            // 
            // dossiers_add_status_combobox
            // 
            this.dossiers_add_status_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dossiers_add_status_combobox.FormattingEnabled = true;
            this.dossiers_add_status_combobox.Items.AddRange(new object[] {
            "Отворено досие",
            "Затворено досие"});
            this.dossiers_add_status_combobox.Location = new System.Drawing.Point(210, 53);
            this.dossiers_add_status_combobox.Name = "dossiers_add_status_combobox";
            this.dossiers_add_status_combobox.Size = new System.Drawing.Size(119, 24);
            this.dossiers_add_status_combobox.TabIndex = 59;
            // 
            // clients_groupbox
            // 
            this.clients_groupbox.Controls.Add(this.clear_button_clients);
            this.clients_groupbox.Controls.Add(this.clients_datagrid);
            this.clients_groupbox.Controls.Add(this.chosen_id_clients_label);
            this.clients_groupbox.Controls.Add(this.last_name);
            this.clients_groupbox.Controls.Add(this.last_name_textbox);
            this.clients_groupbox.Controls.Add(this.sur_name_textbox);
            this.clients_groupbox.Controls.Add(this.sur_name);
            this.clients_groupbox.Controls.Add(this.search_client);
            this.clients_groupbox.Controls.Add(this.first_name);
            this.clients_groupbox.Controls.Add(this.first_name_textbox);
            this.clients_groupbox.Controls.Add(this.ident_number_textbox);
            this.clients_groupbox.Controls.Add(this.ident_number);
            this.clients_groupbox.Controls.Add(this.no_chosen_client_label);
            this.clients_groupbox.Controls.Add(this.chosen_id_clients);
            this.clients_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clients_groupbox.Location = new System.Drawing.Point(12, 12);
            this.clients_groupbox.Name = "clients_groupbox";
            this.clients_groupbox.Size = new System.Drawing.Size(476, 364);
            this.clients_groupbox.TabIndex = 60;
            this.clients_groupbox.TabStop = false;
            this.clients_groupbox.Text = "Търсене на досие по клиент";
            // 
            // clear_button_clients
            // 
            this.clear_button_clients.Location = new System.Drawing.Point(346, 96);
            this.clear_button_clients.Name = "clear_button_clients";
            this.clear_button_clients.Size = new System.Drawing.Size(122, 33);
            this.clear_button_clients.TabIndex = 47;
            this.clear_button_clients.Text = "Изчистване";
            this.clear_button_clients.UseVisualStyleBackColor = true;
            this.clear_button_clients.Click += new System.EventHandler(this.clear_button_clients_Click);
            // 
            // search_dossiers
            // 
            this.search_dossiers.Controls.Add(this.clear_button_dossiers);
            this.search_dossiers.Controls.Add(this.dossiers_status_search_combobox);
            this.search_dossiers.Controls.Add(this.dossier_search_id);
            this.search_dossiers.Controls.Add(this.dossier_search_id_textbox);
            this.search_dossiers.Controls.Add(this.dossier_search_year_textbox);
            this.search_dossiers.Controls.Add(this.dossier_search);
            this.search_dossiers.Controls.Add(this.dossier_search_status);
            this.search_dossiers.Controls.Add(this.dossier_search_year);
            this.search_dossiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_dossiers.Location = new System.Drawing.Point(6, 26);
            this.search_dossiers.Name = "search_dossiers";
            this.search_dossiers.Size = new System.Drawing.Size(330, 148);
            this.search_dossiers.TabIndex = 62;
            this.search_dossiers.TabStop = false;
            this.search_dossiers.Text = "Търсене на досие";
            // 
            // clear_button_dossiers
            // 
            this.clear_button_dossiers.Location = new System.Drawing.Point(9, 112);
            this.clear_button_dossiers.Name = "clear_button_dossiers";
            this.clear_button_dossiers.Size = new System.Drawing.Size(135, 27);
            this.clear_button_dossiers.TabIndex = 52;
            this.clear_button_dossiers.Text = "Изчистване";
            this.clear_button_dossiers.UseVisualStyleBackColor = true;
            this.clear_button_dossiers.Click += new System.EventHandler(this.clear_button_dossiers_Click);
            // 
            // dossiers_status_search_combobox
            // 
            this.dossiers_status_search_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dossiers_status_search_combobox.FormattingEnabled = true;
            this.dossiers_status_search_combobox.Items.AddRange(new object[] {
            "Отворено досие",
            "Затворено досие"});
            this.dossiers_status_search_combobox.Location = new System.Drawing.Point(204, 48);
            this.dossiers_status_search_combobox.Name = "dossiers_status_search_combobox";
            this.dossiers_status_search_combobox.Size = new System.Drawing.Size(120, 24);
            this.dossiers_status_search_combobox.TabIndex = 46;
            // 
            // dossiers_groupbox
            // 
            this.dossiers_groupbox.Controls.Add(this.dossier_datagrid);
            this.dossiers_groupbox.Controls.Add(this.search_dossiers);
            this.dossiers_groupbox.Controls.Add(this.add_groupbox);
            this.dossiers_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dossiers_groupbox.Location = new System.Drawing.Point(512, 12);
            this.dossiers_groupbox.Name = "dossiers_groupbox";
            this.dossiers_groupbox.Size = new System.Drawing.Size(683, 364);
            this.dossiers_groupbox.TabIndex = 63;
            this.dossiers_groupbox.TabStop = false;
            this.dossiers_groupbox.Text = "Досиета";
            // 
            // escape_button
            // 
            this.escape_button.Location = new System.Drawing.Point(1103, 382);
            this.escape_button.Name = "escape_button";
            this.escape_button.Size = new System.Drawing.Size(92, 25);
            this.escape_button.TabIndex = 70;
            this.escape_button.Text = "Изход";
            this.escape_button.UseVisualStyleBackColor = true;
            this.escape_button.Click += new System.EventHandler(this.escape_button_Click);
            // 
            // FindClients_AddDossiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 415);
            this.ControlBox = false;
            this.Controls.Add(this.escape_button);
            this.Controls.Add(this.clients_groupbox);
            this.Controls.Add(this.dossiers_groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "FindClients_AddDossiers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Търсене и добавняне на досиета";
            ((System.ComponentModel.ISupportInitialize)(this.clients_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossier_datagrid)).EndInit();
            this.add_groupbox.ResumeLayout(false);
            this.add_groupbox.PerformLayout();
            this.clients_groupbox.ResumeLayout(false);
            this.clients_groupbox.PerformLayout();
            this.search_dossiers.ResumeLayout(false);
            this.search_dossiers.PerformLayout();
            this.dossiers_groupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox last_name_textbox;
        private System.Windows.Forms.TextBox sur_name_textbox;
        private System.Windows.Forms.TextBox first_name_textbox;
        private System.Windows.Forms.TextBox ident_number_textbox;
        private System.Windows.Forms.Button search_client;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.Label sur_name;
        private System.Windows.Forms.Label first_name;
        private System.Windows.Forms.Label ident_number;
        private System.Windows.Forms.Label no_chosen_client_label;
        private System.Windows.Forms.Label chosen_id_clients_label;
        private System.Windows.Forms.DataGridView clients_datagrid;
        private System.Windows.Forms.Button dossier_search;
        private System.Windows.Forms.TextBox dossier_search_id_textbox;
        private System.Windows.Forms.Label dossier_search_id;
        private System.Windows.Forms.Label dossier_search_status;
        private System.Windows.Forms.TextBox dossier_search_year_textbox;
        private System.Windows.Forms.Label dossier_search_year;
        private System.Windows.Forms.DataGridView dossier_datagrid;
        private System.Windows.Forms.Button add_dossier;
        private System.Windows.Forms.Label chosen_id_clients;
        private System.Windows.Forms.TextBox dossier_min_balance_textbox;
        private System.Windows.Forms.Label dossier_min_balance;
        private System.Windows.Forms.Label dossier_status;
        private System.Windows.Forms.TextBox dossier_year_textbox;
        private System.Windows.Forms.Label dossier_year;
        private System.Windows.Forms.GroupBox add_groupbox;
        private System.Windows.Forms.GroupBox clients_groupbox;
        private System.Windows.Forms.GroupBox search_dossiers;
        private System.Windows.Forms.ComboBox dossiers_add_status_combobox;
        private System.Windows.Forms.ComboBox dossiers_status_search_combobox;
        private System.Windows.Forms.GroupBox dossiers_groupbox;
        private System.Windows.Forms.Button clear_button_clients;
        private System.Windows.Forms.Button clear_button_dossiers;
        private System.Windows.Forms.ToolTip Tip_for_clients;
        private System.Windows.Forms.ToolTip Tip_for_dossiers;
        private System.Windows.Forms.Button escape_button;
    }
}