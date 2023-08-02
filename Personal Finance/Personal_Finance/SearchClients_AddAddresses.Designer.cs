namespace Personal_Finance
{
    partial class SearchClients_AddAddresses
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
            this.search_client = new System.Windows.Forms.Button();
            this.ident_number_textbox = new System.Windows.Forms.TextBox();
            this.first_name_textbox = new System.Windows.Forms.TextBox();
            this.sur_name_textbox = new System.Windows.Forms.TextBox();
            this.last_name_textbox = new System.Windows.Forms.TextBox();
            this.email_texbox = new System.Windows.Forms.TextBox();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.no_rows_label = new System.Windows.Forms.Label();
            this.addresses_datagrid = new System.Windows.Forms.DataGridView();
            this.address_type = new System.Windows.Forms.Label();
            this.address_region = new System.Windows.Forms.Label();
            this.address_minicipality = new System.Windows.Forms.Label();
            this.address_place = new System.Windows.Forms.Label();
            this.address_postcode = new System.Windows.Forms.Label();
            this.address_text = new System.Windows.Forms.Label();
            this.address_region_textbox = new System.Windows.Forms.TextBox();
            this.address_minicipality_textbox = new System.Windows.Forms.TextBox();
            this.address_place_textbox = new System.Windows.Forms.TextBox();
            this.address_postcode_textbox = new System.Windows.Forms.TextBox();
            this.address_text_textbox = new System.Windows.Forms.TextBox();
            this.add_address = new System.Windows.Forms.Button();
            this.chosen_id_label = new System.Windows.Forms.Label();
            this.chosen_id = new System.Windows.Forms.Label();
            this.no_chosen_client_label = new System.Windows.Forms.Label();
            this.addresses_groupbox = new System.Windows.Forms.GroupBox();
            this.address_type_combobox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.escape_button = new System.Windows.Forms.Button();
            this.Tip_for_clear_button = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clients_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addresses_datagrid)).BeginInit();
            this.addresses_groupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clients_datagrid
            // 
            this.clients_datagrid.AllowUserToAddRows = false;
            this.clients_datagrid.AllowUserToDeleteRows = false;
            this.clients_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clients_datagrid.Location = new System.Drawing.Point(6, 243);
            this.clients_datagrid.Name = "clients_datagrid";
            this.clients_datagrid.ReadOnly = true;
            this.clients_datagrid.Size = new System.Drawing.Size(455, 165);
            this.clients_datagrid.TabIndex = 0;
            this.clients_datagrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.clients_datagrid_DataBindingComplete);
            this.clients_datagrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.clients_datagrid_RowHeaderMouseClick);
            // 
            // ident_number
            // 
            this.ident_number.AutoSize = true;
            this.ident_number.Location = new System.Drawing.Point(8, 28);
            this.ident_number.Name = "ident_number";
            this.ident_number.Size = new System.Drawing.Size(104, 17);
            this.ident_number.TabIndex = 1;
            this.ident_number.Text = "Търси по ЕГН:";
            // 
            // first_name
            // 
            this.first_name.AutoSize = true;
            this.first_name.Location = new System.Drawing.Point(8, 53);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(102, 17);
            this.first_name.TabIndex = 2;
            this.first_name.Text = "Търси по име:";
            // 
            // sur_name
            // 
            this.sur_name.AutoSize = true;
            this.sur_name.Location = new System.Drawing.Point(8, 79);
            this.sur_name.Name = "sur_name";
            this.sur_name.Size = new System.Drawing.Size(133, 17);
            this.sur_name.TabIndex = 3;
            this.sur_name.Text = "Търси по презиме:";
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Location = new System.Drawing.Point(8, 105);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(137, 17);
            this.last_name.TabIndex = 4;
            this.last_name.Text = "Търси по фамилия:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(8, 131);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(134, 17);
            this.email.TabIndex = 5;
            this.email.Text = "Търсене по имейл:";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(8, 157);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(151, 17);
            this.phone.TabIndex = 6;
            this.phone.Text = "Търсене по телефон:";
            // 
            // search_client
            // 
            this.search_client.Location = new System.Drawing.Point(197, 187);
            this.search_client.Name = "search_client";
            this.search_client.Size = new System.Drawing.Size(113, 27);
            this.search_client.TabIndex = 7;
            this.search_client.Text = "Търси клиент";
            this.search_client.UseVisualStyleBackColor = true;
            this.search_client.Click += new System.EventHandler(this.search_client_Click);
            // 
            // ident_number_textbox
            // 
            this.ident_number_textbox.Location = new System.Drawing.Point(165, 25);
            this.ident_number_textbox.Name = "ident_number_textbox";
            this.ident_number_textbox.Size = new System.Drawing.Size(177, 23);
            this.ident_number_textbox.TabIndex = 8;
            this.ident_number_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // first_name_textbox
            // 
            this.first_name_textbox.Location = new System.Drawing.Point(165, 50);
            this.first_name_textbox.Name = "first_name_textbox";
            this.first_name_textbox.Size = new System.Drawing.Size(177, 23);
            this.first_name_textbox.TabIndex = 9;
            // 
            // sur_name_textbox
            // 
            this.sur_name_textbox.Location = new System.Drawing.Point(165, 76);
            this.sur_name_textbox.Name = "sur_name_textbox";
            this.sur_name_textbox.Size = new System.Drawing.Size(177, 23);
            this.sur_name_textbox.TabIndex = 10;
            // 
            // last_name_textbox
            // 
            this.last_name_textbox.Location = new System.Drawing.Point(165, 102);
            this.last_name_textbox.Name = "last_name_textbox";
            this.last_name_textbox.Size = new System.Drawing.Size(177, 23);
            this.last_name_textbox.TabIndex = 11;
            // 
            // email_texbox
            // 
            this.email_texbox.Location = new System.Drawing.Point(165, 128);
            this.email_texbox.Name = "email_texbox";
            this.email_texbox.Size = new System.Drawing.Size(177, 23);
            this.email_texbox.TabIndex = 12;
            // 
            // phone_textbox
            // 
            this.phone_textbox.Location = new System.Drawing.Point(165, 154);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(177, 23);
            this.phone_textbox.TabIndex = 13;
            this.phone_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // no_rows_label
            // 
            this.no_rows_label.AutoSize = true;
            this.no_rows_label.Location = new System.Drawing.Point(6, 222);
            this.no_rows_label.Name = "no_rows_label";
            this.no_rows_label.Size = new System.Drawing.Size(307, 16);
            this.no_rows_label.TabIndex = 15;
            this.no_rows_label.Text = "Няма намерени адреси за конкретния клиент";
            // 
            // addresses_datagrid
            // 
            this.addresses_datagrid.AllowUserToAddRows = false;
            this.addresses_datagrid.AllowUserToDeleteRows = false;
            this.addresses_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addresses_datagrid.Location = new System.Drawing.Point(6, 243);
            this.addresses_datagrid.Name = "addresses_datagrid";
            this.addresses_datagrid.ReadOnly = true;
            this.addresses_datagrid.Size = new System.Drawing.Size(392, 165);
            this.addresses_datagrid.TabIndex = 16;
            this.addresses_datagrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.addresses_datagrid_DataBindingComplete);
            // 
            // address_type
            // 
            this.address_type.AutoSize = true;
            this.address_type.Location = new System.Drawing.Point(6, 28);
            this.address_type.Name = "address_type";
            this.address_type.Size = new System.Drawing.Size(105, 16);
            this.address_type.TabIndex = 17;
            this.address_type.Text = "Тип на адреса:";
            // 
            // address_region
            // 
            this.address_region.AutoSize = true;
            this.address_region.Location = new System.Drawing.Point(6, 53);
            this.address_region.Name = "address_region";
            this.address_region.Size = new System.Drawing.Size(58, 16);
            this.address_region.TabIndex = 18;
            this.address_region.Text = "Регион:";
            // 
            // address_minicipality
            // 
            this.address_minicipality.AutoSize = true;
            this.address_minicipality.Location = new System.Drawing.Point(6, 79);
            this.address_minicipality.Name = "address_minicipality";
            this.address_minicipality.Size = new System.Drawing.Size(62, 16);
            this.address_minicipality.TabIndex = 19;
            this.address_minicipality.Text = "Община:";
            // 
            // address_place
            // 
            this.address_place.AutoSize = true;
            this.address_place.Location = new System.Drawing.Point(6, 105);
            this.address_place.Name = "address_place";
            this.address_place.Size = new System.Drawing.Size(131, 16);
            this.address_place.TabIndex = 20;
            this.address_place.Text = "Местонахождение:";
            // 
            // address_postcode
            // 
            this.address_postcode.AutoSize = true;
            this.address_postcode.Location = new System.Drawing.Point(6, 131);
            this.address_postcode.Name = "address_postcode";
            this.address_postcode.Size = new System.Drawing.Size(102, 16);
            this.address_postcode.TabIndex = 21;
            this.address_postcode.Text = "Пощенски код:";
            // 
            // address_text
            // 
            this.address_text.AutoSize = true;
            this.address_text.Location = new System.Drawing.Point(6, 157);
            this.address_text.Name = "address_text";
            this.address_text.Size = new System.Drawing.Size(179, 16);
            this.address_text.TabIndex = 22;
            this.address_text.Text = "Наименование на адреса:";
            // 
            // address_region_textbox
            // 
            this.address_region_textbox.Location = new System.Drawing.Point(191, 52);
            this.address_region_textbox.Name = "address_region_textbox";
            this.address_region_textbox.Size = new System.Drawing.Size(164, 22);
            this.address_region_textbox.TabIndex = 24;
            // 
            // address_minicipality_textbox
            // 
            this.address_minicipality_textbox.Location = new System.Drawing.Point(191, 78);
            this.address_minicipality_textbox.Name = "address_minicipality_textbox";
            this.address_minicipality_textbox.Size = new System.Drawing.Size(164, 22);
            this.address_minicipality_textbox.TabIndex = 25;
            // 
            // address_place_textbox
            // 
            this.address_place_textbox.Location = new System.Drawing.Point(191, 104);
            this.address_place_textbox.Name = "address_place_textbox";
            this.address_place_textbox.Size = new System.Drawing.Size(164, 22);
            this.address_place_textbox.TabIndex = 26;
            // 
            // address_postcode_textbox
            // 
            this.address_postcode_textbox.Location = new System.Drawing.Point(191, 128);
            this.address_postcode_textbox.Name = "address_postcode_textbox";
            this.address_postcode_textbox.Size = new System.Drawing.Size(164, 22);
            this.address_postcode_textbox.TabIndex = 27;
            this.address_postcode_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // address_text_textbox
            // 
            this.address_text_textbox.Location = new System.Drawing.Point(191, 154);
            this.address_text_textbox.Name = "address_text_textbox";
            this.address_text_textbox.Size = new System.Drawing.Size(164, 22);
            this.address_text_textbox.TabIndex = 28;
            // 
            // add_address
            // 
            this.add_address.Location = new System.Drawing.Point(215, 187);
            this.add_address.Name = "add_address";
            this.add_address.Size = new System.Drawing.Size(114, 27);
            this.add_address.TabIndex = 29;
            this.add_address.Text = "Добави адрес";
            this.add_address.UseVisualStyleBackColor = true;
            this.add_address.Click += new System.EventHandler(this.add_address_Click);
            // 
            // chosen_id_label
            // 
            this.chosen_id_label.AutoSize = true;
            this.chosen_id_label.Location = new System.Drawing.Point(3, 222);
            this.chosen_id_label.Name = "chosen_id_label";
            this.chosen_id_label.Size = new System.Drawing.Size(223, 17);
            this.chosen_id_label.TabIndex = 31;
            this.chosen_id_label.Text = "Избран идент. номер на клиент:";
            // 
            // chosen_id
            // 
            this.chosen_id.AutoSize = true;
            this.chosen_id.ForeColor = System.Drawing.Color.Red;
            this.chosen_id.Location = new System.Drawing.Point(232, 222);
            this.chosen_id.Name = "chosen_id";
            this.chosen_id.Size = new System.Drawing.Size(46, 17);
            this.chosen_id.TabIndex = 32;
            this.chosen_id.Text = "label2";
            // 
            // no_chosen_client_label
            // 
            this.no_chosen_client_label.AutoSize = true;
            this.no_chosen_client_label.ForeColor = System.Drawing.Color.Red;
            this.no_chosen_client_label.Location = new System.Drawing.Point(232, 222);
            this.no_chosen_client_label.Name = "no_chosen_client_label";
            this.no_chosen_client_label.Size = new System.Drawing.Size(207, 17);
            this.no_chosen_client_label.TabIndex = 33;
            this.no_chosen_client_label.Text = "Моля изберете ред на клиент";
            // 
            // addresses_groupbox
            // 
            this.addresses_groupbox.Controls.Add(this.address_type_combobox);
            this.addresses_groupbox.Controls.Add(this.addresses_datagrid);
            this.addresses_groupbox.Controls.Add(this.add_address);
            this.addresses_groupbox.Controls.Add(this.no_rows_label);
            this.addresses_groupbox.Controls.Add(this.address_region_textbox);
            this.addresses_groupbox.Controls.Add(this.address_minicipality_textbox);
            this.addresses_groupbox.Controls.Add(this.address_place_textbox);
            this.addresses_groupbox.Controls.Add(this.address_postcode_textbox);
            this.addresses_groupbox.Controls.Add(this.address_text_textbox);
            this.addresses_groupbox.Controls.Add(this.address_type);
            this.addresses_groupbox.Controls.Add(this.address_region);
            this.addresses_groupbox.Controls.Add(this.address_minicipality);
            this.addresses_groupbox.Controls.Add(this.address_place);
            this.addresses_groupbox.Controls.Add(this.address_postcode);
            this.addresses_groupbox.Controls.Add(this.address_text);
            this.addresses_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresses_groupbox.Location = new System.Drawing.Point(489, 13);
            this.addresses_groupbox.Name = "addresses_groupbox";
            this.addresses_groupbox.Size = new System.Drawing.Size(407, 414);
            this.addresses_groupbox.TabIndex = 35;
            this.addresses_groupbox.TabStop = false;
            this.addresses_groupbox.Text = "Добавяне на адреси";
            // 
            // address_type_combobox
            // 
            this.address_type_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.address_type_combobox.Items.AddRange(new object[] {
            "Постоянен адрес",
            "Адрес за кореспонденция"});
            this.address_type_combobox.Location = new System.Drawing.Point(191, 25);
            this.address_type_combobox.Name = "address_type_combobox";
            this.address_type_combobox.Size = new System.Drawing.Size(164, 24);
            this.address_type_combobox.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear_button);
            this.groupBox1.Controls.Add(this.clients_datagrid);
            this.groupBox1.Controls.Add(this.ident_number);
            this.groupBox1.Controls.Add(this.no_chosen_client_label);
            this.groupBox1.Controls.Add(this.first_name);
            this.groupBox1.Controls.Add(this.chosen_id_label);
            this.groupBox1.Controls.Add(this.sur_name);
            this.groupBox1.Controls.Add(this.last_name);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.email_texbox);
            this.groupBox1.Controls.Add(this.phone_textbox);
            this.groupBox1.Controls.Add(this.ident_number_textbox);
            this.groupBox1.Controls.Add(this.first_name_textbox);
            this.groupBox1.Controls.Add(this.sur_name_textbox);
            this.groupBox1.Controls.Add(this.last_name_textbox);
            this.groupBox1.Controls.Add(this.search_client);
            this.groupBox1.Controls.Add(this.chosen_id);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 414);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Търсене на клиенти";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(11, 187);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(113, 27);
            this.clear_button.TabIndex = 34;
            this.clear_button.Text = "Изчисти";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // escape_button
            // 
            this.escape_button.Location = new System.Drawing.Point(804, 433);
            this.escape_button.Name = "escape_button";
            this.escape_button.Size = new System.Drawing.Size(92, 25);
            this.escape_button.TabIndex = 37;
            this.escape_button.Text = "Изход";
            this.escape_button.UseVisualStyleBackColor = true;
            this.escape_button.Click += new System.EventHandler(this.escape_button_Click);
            // 
            // SearchClients_AddAddresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 466);
            this.ControlBox = false;
            this.Controls.Add(this.escape_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addresses_groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SearchClients_AddAddresses";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Търсене на клиенти и добавяне на техни адреси";
            ((System.ComponentModel.ISupportInitialize)(this.clients_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addresses_datagrid)).EndInit();
            this.addresses_groupbox.ResumeLayout(false);
            this.addresses_groupbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button search_client;
        private System.Windows.Forms.TextBox ident_number_textbox;
        private System.Windows.Forms.TextBox first_name_textbox;
        private System.Windows.Forms.TextBox sur_name_textbox;
        private System.Windows.Forms.TextBox last_name_textbox;
        private System.Windows.Forms.TextBox email_texbox;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.Label no_rows_label;
        private System.Windows.Forms.DataGridView addresses_datagrid;
        private System.Windows.Forms.Label address_type;
        private System.Windows.Forms.Label address_region;
        private System.Windows.Forms.Label address_minicipality;
        private System.Windows.Forms.Label address_place;
        private System.Windows.Forms.Label address_postcode;
        private System.Windows.Forms.Label address_text;
        private System.Windows.Forms.TextBox address_region_textbox;
        private System.Windows.Forms.TextBox address_minicipality_textbox;
        private System.Windows.Forms.TextBox address_place_textbox;
        private System.Windows.Forms.TextBox address_postcode_textbox;
        private System.Windows.Forms.TextBox address_text_textbox;
        private System.Windows.Forms.Button add_address;
        private System.Windows.Forms.Label chosen_id_label;
        private System.Windows.Forms.Label chosen_id;
        private System.Windows.Forms.Label no_chosen_client_label;
        private System.Windows.Forms.GroupBox addresses_groupbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox address_type_combobox;
        private System.Windows.Forms.Button escape_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.ToolTip Tip_for_clear_button;
    }
}