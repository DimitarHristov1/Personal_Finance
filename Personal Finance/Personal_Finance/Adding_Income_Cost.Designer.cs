namespace Personal_Finance
{
    partial class Adding_Income_Cost
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
            this.document_income_cost_label = new System.Windows.Forms.Label();
            this.value_income_cost_label = new System.Windows.Forms.Label();
            this.source_income_cost_label = new System.Windows.Forms.Label();
            this.type_income_cost_combobox = new System.Windows.Forms.ComboBox();
            this.type_income_cost_label = new System.Windows.Forms.Label();
            this.date_income_cost_label = new System.Windows.Forms.Label();
            this.search_type_dossiers_combobx = new System.Windows.Forms.ComboBox();
            this.dossier_search_id = new System.Windows.Forms.Label();
            this.dossier_search_id_textbox = new System.Windows.Forms.TextBox();
            this.dossier_search_year_textbox = new System.Windows.Forms.TextBox();
            this.dossier_search = new System.Windows.Forms.Button();
            this.dossier_search_status = new System.Windows.Forms.Label();
            this.document_income_cost_richtextbox = new System.Windows.Forms.RichTextBox();
            this.value_income_cost_textbox = new System.Windows.Forms.TextBox();
            this.income_cost_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dossier_search_year = new System.Windows.Forms.Label();
            this.add_income_cost_groupbox = new System.Windows.Forms.GroupBox();
            this.no_rows_label = new System.Windows.Forms.Label();
            this.no_chosen_dossier_detail = new System.Windows.Forms.Label();
            this.dossier_detail_chosen_id = new System.Windows.Forms.Label();
            this.dossier_detail_chosen_id_label = new System.Windows.Forms.Label();
            this.delete_income_cost_button = new System.Windows.Forms.Button();
            this.edit_income_cost_button = new System.Windows.Forms.Button();
            this.costs_button = new System.Windows.Forms.Button();
            this.incomes_button = new System.Windows.Forms.Button();
            this.source_income_cost_combobox = new System.Windows.Forms.ComboBox();
            this.add_income_cost_datagrid = new System.Windows.Forms.DataGridView();
            this.add_income_cost_button = new System.Windows.Forms.Button();
            this.closed_dossier = new System.Windows.Forms.Label();
            this.no_chosen_dossier = new System.Windows.Forms.Label();
            this.dossier_chosen_id_label = new System.Windows.Forms.Label();
            this.dossier_chosen_id = new System.Windows.Forms.Label();
            this.dossiers_groupbox = new System.Windows.Forms.GroupBox();
            this.clear_search_button = new System.Windows.Forms.Button();
            this.dossier_datagrid = new System.Windows.Forms.DataGridView();
            this.escape_button = new System.Windows.Forms.Button();
            this.Tip_for_dossiers_search = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider_source_combobox = new System.Windows.Forms.ErrorProvider(this.components);
            this.Tip_for_incomes = new System.Windows.Forms.ToolTip(this.components);
            this.Tip_for_costs = new System.Windows.Forms.ToolTip(this.components);
            this.Tip_for_edit_button = new System.Windows.Forms.ToolTip(this.components);
            this.add_income_cost_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_income_cost_datagrid)).BeginInit();
            this.dossiers_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dossier_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_source_combobox)).BeginInit();
            this.SuspendLayout();
            // 
            // document_income_cost_label
            // 
            this.document_income_cost_label.AutoSize = true;
            this.document_income_cost_label.Location = new System.Drawing.Point(341, 32);
            this.document_income_cost_label.Name = "document_income_cost_label";
            this.document_income_cost_label.Size = new System.Drawing.Size(75, 16);
            this.document_income_cost_label.TabIndex = 6;
            this.document_income_cost_label.Text = "Документ:";
            // 
            // value_income_cost_label
            // 
            this.value_income_cost_label.AutoSize = true;
            this.value_income_cost_label.Location = new System.Drawing.Point(6, 108);
            this.value_income_cost_label.Name = "value_income_cost_label";
            this.value_income_cost_label.Size = new System.Drawing.Size(73, 16);
            this.value_income_cost_label.TabIndex = 5;
            this.value_income_cost_label.Text = "Стойност:";
            // 
            // source_income_cost_label
            // 
            this.source_income_cost_label.AutoSize = true;
            this.source_income_cost_label.Location = new System.Drawing.Point(6, 82);
            this.source_income_cost_label.Name = "source_income_cost_label";
            this.source_income_cost_label.Size = new System.Drawing.Size(170, 16);
            this.source_income_cost_label.TabIndex = 4;
            this.source_income_cost_label.Text = "Източник/Бенефициент:";
            // 
            // type_income_cost_combobox
            // 
            this.type_income_cost_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_income_cost_combobox.FormattingEnabled = true;
            this.type_income_cost_combobox.Items.AddRange(new object[] {
            "Приход",
            "Разход"});
            this.type_income_cost_combobox.Location = new System.Drawing.Point(182, 52);
            this.type_income_cost_combobox.Name = "type_income_cost_combobox";
            this.type_income_cost_combobox.Size = new System.Drawing.Size(153, 24);
            this.type_income_cost_combobox.TabIndex = 1;
            this.type_income_cost_combobox.SelectedIndexChanged += new System.EventHandler(this.type_income_cost_combobox_SelectedIndexChanged);
            // 
            // type_income_cost_label
            // 
            this.type_income_cost_label.AutoSize = true;
            this.type_income_cost_label.Location = new System.Drawing.Point(6, 55);
            this.type_income_cost_label.Name = "type_income_cost_label";
            this.type_income_cost_label.Size = new System.Drawing.Size(143, 16);
            this.type_income_cost_label.TabIndex = 3;
            this.type_income_cost_label.Text = "Тип (приход/разход):";
            // 
            // date_income_cost_label
            // 
            this.date_income_cost_label.AutoSize = true;
            this.date_income_cost_label.Location = new System.Drawing.Point(6, 32);
            this.date_income_cost_label.Name = "date_income_cost_label";
            this.date_income_cost_label.Size = new System.Drawing.Size(43, 16);
            this.date_income_cost_label.TabIndex = 0;
            this.date_income_cost_label.Text = "Дата:";
            // 
            // search_type_dossiers_combobx
            // 
            this.search_type_dossiers_combobx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.search_type_dossiers_combobx.FormattingEnabled = true;
            this.search_type_dossiers_combobx.Items.AddRange(new object[] {
            "Отворено досие",
            "Затворено досие"});
            this.search_type_dossiers_combobx.Location = new System.Drawing.Point(223, 48);
            this.search_type_dossiers_combobx.Name = "search_type_dossiers_combobx";
            this.search_type_dossiers_combobx.Size = new System.Drawing.Size(144, 24);
            this.search_type_dossiers_combobx.TabIndex = 46;
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
            // dossier_search_id_textbox
            // 
            this.dossier_search_id_textbox.Location = new System.Drawing.Point(223, 23);
            this.dossier_search_id_textbox.Name = "dossier_search_id_textbox";
            this.dossier_search_id_textbox.Size = new System.Drawing.Size(144, 22);
            this.dossier_search_id_textbox.TabIndex = 44;
            // 
            // dossier_search_year_textbox
            // 
            this.dossier_search_year_textbox.Location = new System.Drawing.Point(223, 75);
            this.dossier_search_year_textbox.Name = "dossier_search_year_textbox";
            this.dossier_search_year_textbox.Size = new System.Drawing.Size(144, 22);
            this.dossier_search_year_textbox.TabIndex = 40;
            // 
            // dossier_search
            // 
            this.dossier_search.Location = new System.Drawing.Point(381, 24);
            this.dossier_search.Name = "dossier_search";
            this.dossier_search.Size = new System.Drawing.Size(122, 33);
            this.dossier_search.TabIndex = 45;
            this.dossier_search.Text = "Търси досие";
            this.dossier_search.UseVisualStyleBackColor = true;
            this.dossier_search.Click += new System.EventHandler(this.dossier_search_Click);
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
            // document_income_cost_richtextbox
            // 
            this.document_income_cost_richtextbox.Location = new System.Drawing.Point(422, 29);
            this.document_income_cost_richtextbox.Name = "document_income_cost_richtextbox";
            this.document_income_cost_richtextbox.Size = new System.Drawing.Size(136, 47);
            this.document_income_cost_richtextbox.TabIndex = 10;
            this.document_income_cost_richtextbox.Text = "";
            // 
            // value_income_cost_textbox
            // 
            this.value_income_cost_textbox.Location = new System.Drawing.Point(182, 105);
            this.value_income_cost_textbox.Name = "value_income_cost_textbox";
            this.value_income_cost_textbox.Size = new System.Drawing.Size(153, 22);
            this.value_income_cost_textbox.TabIndex = 9;
            this.value_income_cost_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // income_cost_dateTimePicker
            // 
            this.income_cost_dateTimePicker.Location = new System.Drawing.Point(182, 27);
            this.income_cost_dateTimePicker.Name = "income_cost_dateTimePicker";
            this.income_cost_dateTimePicker.Size = new System.Drawing.Size(153, 22);
            this.income_cost_dateTimePicker.TabIndex = 8;
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
            // add_income_cost_groupbox
            // 
            this.add_income_cost_groupbox.Controls.Add(this.no_rows_label);
            this.add_income_cost_groupbox.Controls.Add(this.no_chosen_dossier_detail);
            this.add_income_cost_groupbox.Controls.Add(this.dossier_detail_chosen_id);
            this.add_income_cost_groupbox.Controls.Add(this.dossier_detail_chosen_id_label);
            this.add_income_cost_groupbox.Controls.Add(this.delete_income_cost_button);
            this.add_income_cost_groupbox.Controls.Add(this.edit_income_cost_button);
            this.add_income_cost_groupbox.Controls.Add(this.costs_button);
            this.add_income_cost_groupbox.Controls.Add(this.incomes_button);
            this.add_income_cost_groupbox.Controls.Add(this.source_income_cost_combobox);
            this.add_income_cost_groupbox.Controls.Add(this.add_income_cost_datagrid);
            this.add_income_cost_groupbox.Controls.Add(this.add_income_cost_button);
            this.add_income_cost_groupbox.Controls.Add(this.document_income_cost_richtextbox);
            this.add_income_cost_groupbox.Controls.Add(this.value_income_cost_textbox);
            this.add_income_cost_groupbox.Controls.Add(this.income_cost_dateTimePicker);
            this.add_income_cost_groupbox.Controls.Add(this.document_income_cost_label);
            this.add_income_cost_groupbox.Controls.Add(this.value_income_cost_label);
            this.add_income_cost_groupbox.Controls.Add(this.source_income_cost_label);
            this.add_income_cost_groupbox.Controls.Add(this.type_income_cost_combobox);
            this.add_income_cost_groupbox.Controls.Add(this.type_income_cost_label);
            this.add_income_cost_groupbox.Controls.Add(this.date_income_cost_label);
            this.add_income_cost_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_income_cost_groupbox.Location = new System.Drawing.Point(527, 12);
            this.add_income_cost_groupbox.Name = "add_income_cost_groupbox";
            this.add_income_cost_groupbox.Size = new System.Drawing.Size(564, 354);
            this.add_income_cost_groupbox.TabIndex = 68;
            this.add_income_cost_groupbox.TabStop = false;
            this.add_income_cost_groupbox.Text = "Добавяне на приходи/разходи по досие";
            // 
            // no_rows_label
            // 
            this.no_rows_label.AutoSize = true;
            this.no_rows_label.Location = new System.Drawing.Point(3, 176);
            this.no_rows_label.Name = "no_rows_label";
            this.no_rows_label.Size = new System.Drawing.Size(316, 16);
            this.no_rows_label.TabIndex = 70;
            this.no_rows_label.Text = "Няма намерени детайли за конкретното досие";
            // 
            // no_chosen_dossier_detail
            // 
            this.no_chosen_dossier_detail.AutoSize = true;
            this.no_chosen_dossier_detail.ForeColor = System.Drawing.Color.Red;
            this.no_chosen_dossier_detail.Location = new System.Drawing.Point(289, 176);
            this.no_chosen_dossier_detail.Name = "no_chosen_dossier_detail";
            this.no_chosen_dossier_detail.Size = new System.Drawing.Size(265, 16);
            this.no_chosen_dossier_detail.TabIndex = 66;
            this.no_chosen_dossier_detail.Text = "Моля изберете ред на детайл на досие";
            // 
            // dossier_detail_chosen_id
            // 
            this.dossier_detail_chosen_id.AutoSize = true;
            this.dossier_detail_chosen_id.ForeColor = System.Drawing.Color.Red;
            this.dossier_detail_chosen_id.Location = new System.Drawing.Point(289, 176);
            this.dossier_detail_chosen_id.Name = "dossier_detail_chosen_id";
            this.dossier_detail_chosen_id.Size = new System.Drawing.Size(45, 16);
            this.dossier_detail_chosen_id.TabIndex = 66;
            this.dossier_detail_chosen_id.Text = "label1";
            // 
            // dossier_detail_chosen_id_label
            // 
            this.dossier_detail_chosen_id_label.AutoSize = true;
            this.dossier_detail_chosen_id_label.Location = new System.Drawing.Point(3, 176);
            this.dossier_detail_chosen_id_label.Name = "dossier_detail_chosen_id_label";
            this.dossier_detail_chosen_id_label.Size = new System.Drawing.Size(280, 16);
            this.dossier_detail_chosen_id_label.TabIndex = 66;
            this.dossier_detail_chosen_id_label.Text = "Избран идент. номер на детайл на досие:";
            // 
            // delete_income_cost_button
            // 
            this.delete_income_cost_button.Location = new System.Drawing.Point(436, 140);
            this.delete_income_cost_button.Name = "delete_income_cost_button";
            this.delete_income_cost_button.Size = new System.Drawing.Size(122, 33);
            this.delete_income_cost_button.TabIndex = 69;
            this.delete_income_cost_button.Text = "Изтриване";
            this.delete_income_cost_button.UseVisualStyleBackColor = true;
            this.delete_income_cost_button.Click += new System.EventHandler(this.delete_income_cost_button_Click);
            // 
            // edit_income_cost_button
            // 
            this.edit_income_cost_button.Location = new System.Drawing.Point(227, 140);
            this.edit_income_cost_button.Name = "edit_income_cost_button";
            this.edit_income_cost_button.Size = new System.Drawing.Size(122, 33);
            this.edit_income_cost_button.TabIndex = 68;
            this.edit_income_cost_button.Text = "Редактиране";
            this.edit_income_cost_button.UseVisualStyleBackColor = true;
            this.edit_income_cost_button.Click += new System.EventHandler(this.edit_income_cost_button_Click);
            this.edit_income_cost_button.MouseLeave += new System.EventHandler(this.edit_income_cost_button_MouseLeave);
            this.edit_income_cost_button.MouseHover += new System.EventHandler(this.edit_income_cost_button_MouseHover);
            // 
            // costs_button
            // 
            this.costs_button.Location = new System.Drawing.Point(458, 93);
            this.costs_button.Name = "costs_button";
            this.costs_button.Size = new System.Drawing.Size(100, 31);
            this.costs_button.TabIndex = 67;
            this.costs_button.Text = "Разходи";
            this.costs_button.UseVisualStyleBackColor = true;
            this.costs_button.Click += new System.EventHandler(this.costs_button_Click);
            // 
            // incomes_button
            // 
            this.incomes_button.Location = new System.Drawing.Point(344, 93);
            this.incomes_button.Name = "incomes_button";
            this.incomes_button.Size = new System.Drawing.Size(100, 31);
            this.incomes_button.TabIndex = 66;
            this.incomes_button.Text = "Приходи";
            this.incomes_button.UseVisualStyleBackColor = true;
            this.incomes_button.Click += new System.EventHandler(this.incomes_button_Click);
            // 
            // source_income_cost_combobox
            // 
            this.source_income_cost_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.source_income_cost_combobox.FormattingEnabled = true;
            this.source_income_cost_combobox.Location = new System.Drawing.Point(182, 79);
            this.source_income_cost_combobox.Name = "source_income_cost_combobox";
            this.source_income_cost_combobox.Size = new System.Drawing.Size(153, 24);
            this.source_income_cost_combobox.TabIndex = 55;
            // 
            // add_income_cost_datagrid
            // 
            this.add_income_cost_datagrid.AllowUserToAddRows = false;
            this.add_income_cost_datagrid.AllowUserToDeleteRows = false;
            this.add_income_cost_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.add_income_cost_datagrid.Location = new System.Drawing.Point(6, 194);
            this.add_income_cost_datagrid.Name = "add_income_cost_datagrid";
            this.add_income_cost_datagrid.ReadOnly = true;
            this.add_income_cost_datagrid.Size = new System.Drawing.Size(552, 154);
            this.add_income_cost_datagrid.TabIndex = 54;
            this.add_income_cost_datagrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.add_income_cost_datagrid_DataBindingComplete);
            this.add_income_cost_datagrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.add_income_cost_datagrid_RowHeaderMouseClick);
            // 
            // add_income_cost_button
            // 
            this.add_income_cost_button.Location = new System.Drawing.Point(6, 140);
            this.add_income_cost_button.Name = "add_income_cost_button";
            this.add_income_cost_button.Size = new System.Drawing.Size(122, 33);
            this.add_income_cost_button.TabIndex = 53;
            this.add_income_cost_button.Text = "Добавяне";
            this.add_income_cost_button.UseVisualStyleBackColor = true;
            this.add_income_cost_button.Click += new System.EventHandler(this.add_income_cost_button_Click);
            // 
            // closed_dossier
            // 
            this.closed_dossier.AutoSize = true;
            this.closed_dossier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closed_dossier.ForeColor = System.Drawing.Color.Red;
            this.closed_dossier.Location = new System.Drawing.Point(3, 108);
            this.closed_dossier.Name = "closed_dossier";
            this.closed_dossier.Size = new System.Drawing.Size(158, 16);
            this.closed_dossier.TabIndex = 65;
            this.closed_dossier.Text = "Досието е приключено";
            this.closed_dossier.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // no_chosen_dossier
            // 
            this.no_chosen_dossier.AutoSize = true;
            this.no_chosen_dossier.ForeColor = System.Drawing.Color.Red;
            this.no_chosen_dossier.Location = new System.Drawing.Point(220, 175);
            this.no_chosen_dossier.Name = "no_chosen_dossier";
            this.no_chosen_dossier.Size = new System.Drawing.Size(196, 16);
            this.no_chosen_dossier.TabIndex = 48;
            this.no_chosen_dossier.Text = "Моля изберете ред на досие";
            // 
            // dossier_chosen_id_label
            // 
            this.dossier_chosen_id_label.AutoSize = true;
            this.dossier_chosen_id_label.Location = new System.Drawing.Point(3, 175);
            this.dossier_chosen_id_label.Name = "dossier_chosen_id_label";
            this.dossier_chosen_id_label.Size = new System.Drawing.Size(211, 16);
            this.dossier_chosen_id_label.TabIndex = 47;
            this.dossier_chosen_id_label.Text = "Избран идент. номер на досие:";
            // 
            // dossier_chosen_id
            // 
            this.dossier_chosen_id.AutoSize = true;
            this.dossier_chosen_id.ForeColor = System.Drawing.Color.Red;
            this.dossier_chosen_id.Location = new System.Drawing.Point(220, 175);
            this.dossier_chosen_id.Name = "dossier_chosen_id";
            this.dossier_chosen_id.Size = new System.Drawing.Size(45, 16);
            this.dossier_chosen_id.TabIndex = 52;
            this.dossier_chosen_id.Text = "label1";
            // 
            // dossiers_groupbox
            // 
            this.dossiers_groupbox.Controls.Add(this.clear_search_button);
            this.dossiers_groupbox.Controls.Add(this.closed_dossier);
            this.dossiers_groupbox.Controls.Add(this.dossier_chosen_id);
            this.dossiers_groupbox.Controls.Add(this.no_chosen_dossier);
            this.dossiers_groupbox.Controls.Add(this.search_type_dossiers_combobx);
            this.dossiers_groupbox.Controls.Add(this.dossier_datagrid);
            this.dossiers_groupbox.Controls.Add(this.dossier_search_id);
            this.dossiers_groupbox.Controls.Add(this.dossier_chosen_id_label);
            this.dossiers_groupbox.Controls.Add(this.dossier_search_id_textbox);
            this.dossiers_groupbox.Controls.Add(this.dossier_search_year_textbox);
            this.dossiers_groupbox.Controls.Add(this.dossier_search);
            this.dossiers_groupbox.Controls.Add(this.dossier_search_status);
            this.dossiers_groupbox.Controls.Add(this.dossier_search_year);
            this.dossiers_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dossiers_groupbox.Location = new System.Drawing.Point(12, 12);
            this.dossiers_groupbox.Name = "dossiers_groupbox";
            this.dossiers_groupbox.Size = new System.Drawing.Size(509, 354);
            this.dossiers_groupbox.TabIndex = 67;
            this.dossiers_groupbox.TabStop = false;
            this.dossiers_groupbox.Text = "Търсене на досие";
            // 
            // clear_search_button
            // 
            this.clear_search_button.Location = new System.Drawing.Point(381, 82);
            this.clear_search_button.Name = "clear_search_button";
            this.clear_search_button.Size = new System.Drawing.Size(122, 33);
            this.clear_search_button.TabIndex = 53;
            this.clear_search_button.Text = "Изчистване";
            this.clear_search_button.UseVisualStyleBackColor = true;
            this.clear_search_button.Click += new System.EventHandler(this.clear_search_button_Click);
            // 
            // dossier_datagrid
            // 
            this.dossier_datagrid.AllowUserToAddRows = false;
            this.dossier_datagrid.AllowUserToDeleteRows = false;
            this.dossier_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dossier_datagrid.Location = new System.Drawing.Point(6, 194);
            this.dossier_datagrid.Name = "dossier_datagrid";
            this.dossier_datagrid.ReadOnly = true;
            this.dossier_datagrid.Size = new System.Drawing.Size(497, 154);
            this.dossier_datagrid.TabIndex = 38;
            this.dossier_datagrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dossier_datagrid_DataBindingComplete);
            this.dossier_datagrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dossier_datagrid_RowHeaderMouseClick);
            // 
            // escape_button
            // 
            this.escape_button.Location = new System.Drawing.Point(999, 372);
            this.escape_button.Name = "escape_button";
            this.escape_button.Size = new System.Drawing.Size(92, 25);
            this.escape_button.TabIndex = 69;
            this.escape_button.Text = "Изход";
            this.escape_button.UseVisualStyleBackColor = true;
            this.escape_button.Click += new System.EventHandler(this.escape_button_Click);
            // 
            // errorProvider_source_combobox
            // 
            this.errorProvider_source_combobox.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider_source_combobox.ContainerControl = this;
            // 
            // Tip_for_edit_button
            // 
            this.Tip_for_edit_button.IsBalloon = true;
            this.Tip_for_edit_button.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.Tip_for_edit_button.ToolTipTitle = "Внимание";
            // 
            // Adding_Income_Cost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 405);
            this.ControlBox = false;
            this.Controls.Add(this.escape_button);
            this.Controls.Add(this.dossiers_groupbox);
            this.Controls.Add(this.add_income_cost_groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Adding_Income_Cost";
            this.ShowIcon = false;
            this.Text = "Добавяне на приходи/разходи по досие";
            this.add_income_cost_groupbox.ResumeLayout(false);
            this.add_income_cost_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_income_cost_datagrid)).EndInit();
            this.dossiers_groupbox.ResumeLayout(false);
            this.dossiers_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dossier_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_source_combobox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label document_income_cost_label;
        private System.Windows.Forms.Label value_income_cost_label;
        private System.Windows.Forms.Label source_income_cost_label;
        private System.Windows.Forms.ComboBox type_income_cost_combobox;
        private System.Windows.Forms.Label type_income_cost_label;
        private System.Windows.Forms.Label date_income_cost_label;
        private System.Windows.Forms.ComboBox search_type_dossiers_combobx;
        private System.Windows.Forms.Label dossier_search_id;
        private System.Windows.Forms.TextBox dossier_search_id_textbox;
        private System.Windows.Forms.TextBox dossier_search_year_textbox;
        private System.Windows.Forms.Button dossier_search;
        private System.Windows.Forms.Label dossier_search_status;
        private System.Windows.Forms.RichTextBox document_income_cost_richtextbox;
        private System.Windows.Forms.TextBox value_income_cost_textbox;
        private System.Windows.Forms.DateTimePicker income_cost_dateTimePicker;
        private System.Windows.Forms.Label dossier_search_year;
        private System.Windows.Forms.GroupBox add_income_cost_groupbox;
        private System.Windows.Forms.Label no_chosen_dossier;
        private System.Windows.Forms.Label dossier_chosen_id_label;
        private System.Windows.Forms.Label dossier_chosen_id;
        private System.Windows.Forms.GroupBox dossiers_groupbox;
        private System.Windows.Forms.Button escape_button;
        private System.Windows.Forms.Button add_income_cost_button;
        private System.Windows.Forms.Button clear_search_button;
        private System.Windows.Forms.ToolTip Tip_for_dossiers_search;
        private System.Windows.Forms.Label closed_dossier;
        private System.Windows.Forms.DataGridView add_income_cost_datagrid;
        private System.Windows.Forms.DataGridView dossier_datagrid;
        private System.Windows.Forms.ComboBox source_income_cost_combobox;
        private System.Windows.Forms.ErrorProvider errorProvider_source_combobox;
        private System.Windows.Forms.Button incomes_button;
        private System.Windows.Forms.Button costs_button;
        private System.Windows.Forms.ToolTip Tip_for_incomes;
        private System.Windows.Forms.ToolTip Tip_for_costs;
        private System.Windows.Forms.Button delete_income_cost_button;
        private System.Windows.Forms.Button edit_income_cost_button;
        private System.Windows.Forms.Label no_chosen_dossier_detail;
        private System.Windows.Forms.Label dossier_detail_chosen_id;
        private System.Windows.Forms.Label dossier_detail_chosen_id_label;
        private System.Windows.Forms.ToolTip Tip_for_edit_button;
        private System.Windows.Forms.Label no_rows_label;
    }
}