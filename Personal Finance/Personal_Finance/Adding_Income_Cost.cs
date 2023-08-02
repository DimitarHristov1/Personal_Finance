using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personal_Finance
{
    public partial class Adding_Income_Cost : Form
    {
        Incomes_Form incomes = new Incomes_Form();
        Costs_Form costs = new Costs_Form();
        SqlConnection con = new SqlConnection(Properties.Settings.Default.constring);
        SqlCommand com;
        SqlDataAdapter adapt;
        int ID_dossiers = 0;
        int ID_income_cost = 0;
        public Adding_Income_Cost()
        {
            InitializeComponent();
            DisplayDossierssData();
            ClearData();
            Tip_for_dossiers_search.SetToolTip(this.clear_search_button, "Изчистете данните от търсенето");
            Tip_for_edit_button.SetToolTip(this.edit_income_cost_button, "Можете да редактирате само типа ,източника/бенефициента и стойността на дадения приход/разход");
            Tip_for_incomes.SetToolTip(this.incomes_button, "Списък със видовете приходи");
            Tip_for_costs.SetToolTip(this.costs_button, "Списък със видовете разходи");
            add_income_cost_datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            add_income_cost_datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            add_income_cost_datagrid.AllowUserToResizeRows = false;
            add_income_cost_datagrid.AllowUserToResizeColumns = false;
            dossier_datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dossier_datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dossier_datagrid.AllowUserToResizeRows = false;
            dossier_datagrid.AllowUserToResizeColumns = false;
        }

        public Form RefToMainForm { get; set; }

        private void escape_button_Click(object sender, EventArgs e)
        {
            if (incomes != null)
            {
                incomes.Close();
            }
            if (costs != null)
            {
                costs.Close();
            }
            this.Close();
            this.RefToMainForm.Show();
        }
        private void DisplayDossierssData()
        {
            DataTable dossier = new DataTable();
            adapt = new SqlDataAdapter("SELECT DOSSIER_NO [Идент. номер на досие], CLIENT_ID [Идент. номер на клиент], DOSSIER_YEAR [Година на досие], DOSSIER_STATUS [Статус на досие], DOSSIER_MIN_BALANCE [Мин. баланс на досието] FROM DOSSIER", con);
            adapt.Fill(dossier);
            dossier_datagrid.DataSource = dossier;
        }

        private void ClearData()
        {
            ID_dossiers = 0;
            ID_income_cost = 0;
            add_income_cost_groupbox.Enabled = false;
            add_income_cost_button.Enabled = false;
            edit_income_cost_button.Enabled = false;
            delete_income_cost_button.Enabled = false;
            DataTable income_cost = new DataTable();
            add_income_cost_datagrid.DataSource = income_cost;
            income_cost.Clear();
            closed_dossier.Visible = false;
            no_chosen_dossier.Visible = true;
            no_chosen_dossier_detail.Visible = false;
            no_rows_label.Visible = false;
            dossier_chosen_id.Visible = false;
            dossier_chosen_id_label.Visible = true;
            dossier_detail_chosen_id.Visible = false;
            dossier_detail_chosen_id_label.Visible = false;
            dossier_search_id_textbox.Clear();
            search_type_dossiers_combobx.SelectedIndex = -1;
            dossier_search_year_textbox.Clear();
            income_cost_dateTimePicker.Value = DateTime.Today;
            type_income_cost_combobox.SelectedIndex = -1;
            source_income_cost_combobox.SelectedIndex = -1;
            value_income_cost_textbox.Clear();
            document_income_cost_richtextbox.Clear();
        }

        private void clear_search_button_Click(object sender, EventArgs e)
        {
            DisplayDossierssData();
            ClearData();
            errorProvider_source_combobox.SetError(this.type_income_cost_combobox, "");
        }

        private void dossier_search_Click(object sender, EventArgs e)
        {
            if (search_type_dossiers_combobx.SelectedIndex == 0)
            {
                DataTable dossiers = new DataTable();
                adapt = new SqlDataAdapter("SELECT DOSSIER_NO [Идент. номер на досие], CLIENT_ID [Идент. номер на клиент], DOSSIER_YEAR [Година на досие], DOSSIER_STATUS [Статус на досие], DOSSIER_MIN_BALANCE [Мин. баланс на досието] FROM DOSSIER where DOSSIER_NO like '%" + dossier_search_id_textbox.Text + "%' and DOSSIER_STATUS = 'O' and DOSSIER_YEAR like N'%" + dossier_search_year_textbox.Text + "%'", con);
                adapt.Fill(dossiers);
                dossier_datagrid.DataSource = dossiers;
                ID_dossiers = 0;
                ID_income_cost = 0;
                no_chosen_dossier.Visible = true;
                dossier_chosen_id.Visible = false;
                dossier_chosen_id_label.Visible = true;
                add_income_cost_groupbox.Enabled = false;
                add_income_cost_button.Enabled = false;
                errorProvider_source_combobox.SetError(this.type_income_cost_combobox, "");
                DataTable income_cost = new DataTable();
                add_income_cost_datagrid.DataSource = income_cost;
                income_cost.Clear();
            }
            else if (search_type_dossiers_combobx.SelectedIndex == 1)
            {
                DataTable dossiers = new DataTable();
                adapt = new SqlDataAdapter("SELECT DOSSIER_NO [Идент. номер на досие], CLIENT_ID [Идент. номер на клиент], DOSSIER_YEAR [Година на досие], DOSSIER_STATUS [Статус на досие], DOSSIER_MIN_BALANCE [Мин. баланс на досието] FROM DOSSIER where DOSSIER_NO like '%" + dossier_search_id_textbox.Text + "%' and DOSSIER_STATUS = 'C' and DOSSIER_YEAR like N'%" + dossier_search_year_textbox.Text + "%'", con);
                adapt.Fill(dossiers);
                dossier_datagrid.DataSource = dossiers;
                ID_dossiers = 0;
                ID_income_cost = 0;
                no_chosen_dossier.Visible = true;
                dossier_chosen_id.Visible = false;
                dossier_chosen_id_label.Visible = true;
                add_income_cost_groupbox.Enabled = false;
                add_income_cost_button.Enabled = false;
                errorProvider_source_combobox.SetError(this.type_income_cost_combobox, "");
                DataTable income_cost = new DataTable();
                add_income_cost_datagrid.DataSource = income_cost;
                income_cost.Clear();
            }
        }

        private void dossier_datagrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dossier_chosen_id.Text = Convert.ToInt32(dossier_datagrid.Rows[e.RowIndex].Cells[0].Value.ToString()).ToString();
            ID_dossiers = Convert.ToInt32(dossier_datagrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (dossier_datagrid.Rows[e.RowIndex].Cells[3].Value.ToString() == "O")
            {
                add_income_cost_groupbox.Enabled = true;
                add_income_cost_button.Enabled = true;
                edit_income_cost_button.Enabled = true;
                delete_income_cost_button.Enabled = true;
                DataTable dossier_income_details = new DataTable();
                adapt = new SqlDataAdapter("SELECT DD_ID [Идент. номер на детайл на досие], DOSSIER_NO [Идент. номер на досие], INCEXP_ID [Идент. номер на приход/разход], DD_DATE [Дата на прихода], DD_VALUE [Стойност на прихода], DD_DOC [Документ] FROM DOSSIER_DETAILS Where DOSSIER_NO = " + ID_dossiers + "", con);
                add_income_cost_datagrid.DataSource = dossier_income_details;
                adapt.Fill(dossier_income_details);
                closed_dossier.Visible = false;
                no_chosen_dossier.Visible = false;
                dossier_chosen_id.Visible = true;
                dossier_chosen_id_label.Visible = true;
                no_chosen_dossier_detail.Visible = true;
                dossier_detail_chosen_id.Visible = false;
                dossier_detail_chosen_id_label.Visible = true;
                if (type_income_cost_combobox.SelectedIndex == -1)
                {
                    source_income_cost_combobox.Enabled = false;
                    source_income_cost_label.Enabled = false;
                    errorProvider_source_combobox.SetError(this.type_income_cost_combobox, "Изберете какво ще добавяте (приход/разход)");
                }
                if (add_income_cost_datagrid.RowCount == 0)
                {
                    no_rows_label.Visible = true;
                    no_rows_label.ForeColor = Color.Red;
                    dossier_detail_chosen_id_label.Visible = false;
                    no_chosen_dossier_detail.Visible = false;
                }
                else
                {
                    no_rows_label.Visible = false;
                }
            }
            else if (dossier_datagrid.Rows[e.RowIndex].Cells[3].Value.ToString() == "C")
            {
                add_income_cost_groupbox.Enabled = false;
                add_income_cost_button.Enabled = false;
                DataTable income_cost = new DataTable();
                add_income_cost_datagrid.DataSource = income_cost;
                income_cost.Clear();
                closed_dossier.Visible = true;
                no_chosen_dossier.Visible = false;
                dossier_chosen_id.Visible = true;
                dossier_chosen_id_label.Visible = true;
                dossier_detail_chosen_id_label.Visible = false;
                no_chosen_dossier_detail.Visible = false;
                no_rows_label.Visible = false;
                errorProvider_source_combobox.SetError(this.type_income_cost_combobox, "");
            }
        }

        private void type_income_cost_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (type_income_cost_combobox.SelectedIndex == 0)
                {
                    DataTable income = new DataTable();
                    adapt = new SqlDataAdapter("select * from INCOME_EXPNECE where INCEXP_TYPE = 'I'", con);
                    adapt.Fill(income);
                    source_income_cost_combobox.DataSource = income;
                    source_income_cost_combobox.DisplayMember = "INCEXP_NAME";
                    source_income_cost_combobox.ValueMember = "INCEXP_ID";
                    source_income_cost_combobox.Enabled = true;
                    source_income_cost_label.Enabled = true;
                    errorProvider_source_combobox.SetError(this.type_income_cost_combobox, "");
                }
                else if (type_income_cost_combobox.SelectedIndex == 1)
                {
                    DataTable income = new DataTable();
                    adapt = new SqlDataAdapter("select * from INCOME_EXPNECE where INCEXP_TYPE = 'C'", con);
                    adapt.Fill(income);
                    source_income_cost_combobox.DataSource = income;
                    source_income_cost_combobox.DisplayMember = "INCEXP_NAME";
                    source_income_cost_combobox.ValueMember = "INCEXP_ID";
                    source_income_cost_combobox.Enabled = true;
                    source_income_cost_label.Enabled = true;
                    errorProvider_source_combobox.SetError(this.type_income_cost_combobox, "");
                }
            }
        }

        private void incomes_button_Click(object sender, EventArgs e)
        {
            incomes.CloseEvent += escape_button_Click;
            if (!incomes.Visible)
            {
                incomes.Show();
            }
            else
            {
                incomes.BringToFront();
            }
        }

        private void costs_button_Click(object sender, EventArgs e)
        {
            costs.CloseEvent += escape_button_Click;
            if (!costs.Visible)
            {
                costs.Show();
            }
            else
            {
                costs.BringToFront();
            }
        }

        private void add_income_cost_button_Click(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            DataRowView row_source_icome_cost = source_income_cost_combobox.SelectedItem as DataRowView;
            ID_dossiers = Convert.ToInt32(dossier_chosen_id.Text);
            if (income_cost_dateTimePicker.Text == string.Empty)
            {
                MessageBox.Show("Добавете данни за дата на прихода/разхода");
                return;
            }
            if (type_income_cost_combobox.SelectedIndex == -1)
            {
                MessageBox.Show("Изберете какво ще добавяте (приход/разход)");
                return;
            }
            if (source_income_cost_combobox.SelectedIndex == -1)
            {
                MessageBox.Show("Добавете данни за източника/бенефициента на прихода/разхода");
                return;
            }
            if (value_income_cost_textbox.Text == string.Empty)
            {
                MessageBox.Show("Добавете данни за стойност на прихода/разхода");
                return;
            }
            if (document_income_cost_richtextbox.Text == string.Empty)
            {
                MessageBox.Show("Добавете данни за документ на прихода/разхода");
                return;
            }
            double numb_for_value = double.Parse(value_income_cost_textbox.Text.Replace(',','.'));
            if (numb_for_value > 0)
            {
                string query = "INSERT INTO DOSSIER_DETAILS (DOSSIER_NO, INCEXP_ID, DD_DATE, DD_VALUE, DD_DOC) values ('" + ID_dossiers + "' , '" + row_source_icome_cost.Row["INCEXP_ID"].ToString() + "' , '" + income_cost_dateTimePicker.Value.ToString("yyyy-MM-dd") + "', '" + value_income_cost_textbox.Text.Replace(",", ".") + "', '" + document_income_cost_richtextbox.Text + "')";
                com = new SqlCommand(query, con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Прихода/разхода е добавен успешно!", "Message/Съобщение");
                income_cost_dateTimePicker.Value = DateTime.Today;
                type_income_cost_combobox.SelectedIndex = -1;
                source_income_cost_combobox.SelectedIndex = -1;
                value_income_cost_textbox.Clear();
                document_income_cost_richtextbox.Clear();
                DataTable dossier_income_details = new DataTable();
                adapt = new SqlDataAdapter("SELECT DD_ID [Идент. номер на детайл на досие], DOSSIER_NO [Идент. номер на досие], INCEXP_ID [Идент. номер на приход/разход], DD_DATE [Дата на прихода], DD_VALUE [Стойност на прихода], DD_DOC [Документ] FROM DOSSIER_DETAILS Where DOSSIER_NO = " + ID_dossiers + "", con);
                adapt.Fill(dossier_income_details);
                add_income_cost_datagrid.DataSource = dossier_income_details;
                no_chosen_dossier_detail.Visible = true;
                dossier_detail_chosen_id.Visible = false;
                if (type_income_cost_combobox.SelectedIndex == -1)
                {
                    source_income_cost_combobox.Enabled = false;
                    source_income_cost_label.Enabled = false;
                    errorProvider_source_combobox.SetError(this.type_income_cost_combobox, "Изберете какво ще добавяте (приход/разход)");
                }
                if (add_income_cost_datagrid.RowCount == 0)
                {
                    no_rows_label.Visible = true;
                    no_rows_label.ForeColor = Color.Red;
                    dossier_detail_chosen_id_label.Visible = false;
                    no_chosen_dossier_detail.Visible = false;
                }
                else
                {
                    no_rows_label.Visible = false;
                }
            }
            else if (numb_for_value <= 0)
            {
                MessageBox.Show("Данните за стойност на прихода/разхода са невалидни");
                return;
            }
        }

        private void edit_income_cost_button_Click(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            DataRowView row_source_icome_cost = source_income_cost_combobox.SelectedItem as DataRowView;
            if (dossier_detail_chosen_id.Visible == true)
            {
                ID_income_cost = Convert.ToInt32(dossier_detail_chosen_id.Text);
                ID_dossiers = Convert.ToInt32(dossier_chosen_id.Text);
                if (type_income_cost_combobox.SelectedIndex == -1)
                {
                    MessageBox.Show("Изберете какво ще добавяте (приход/разход)");
                    return;
                }
                if (source_income_cost_combobox.SelectedIndex == -1)
                {
                    MessageBox.Show("Добавете данни за източника/бенефициента на прихода/разхода");
                    return;
                }
                if (value_income_cost_textbox.Text == string.Empty)
                {
                    MessageBox.Show("Добавете данни за стойност на прихода/разхода");
                    return;
                }
                double numb_for_value = double.Parse(value_income_cost_textbox.Text.Replace(',', '.'));
                if (numb_for_value > 0)
                {
                    string query = "UPDATE DOSSIER_DETAILS SET INCEXP_ID=" + row_source_icome_cost.Row["INCEXP_ID"].ToString() + ", DD_VALUE=" + value_income_cost_textbox.Text.Replace(",", ".") + " WHERE DD_ID=" + ID_income_cost + "";
                    com = new SqlCommand(query, con);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Данните са успешно променени");
                    income_cost_dateTimePicker.Value = DateTime.Today;
                    type_income_cost_combobox.SelectedIndex = -1;
                    source_income_cost_combobox.SelectedIndex = -1;
                    value_income_cost_textbox.Clear();
                    document_income_cost_richtextbox.Clear();
                    no_chosen_dossier_detail.Visible = true;
                    dossier_detail_chosen_id.Visible = false;
                    DataTable dossier_income_details = new DataTable();
                    adapt = new SqlDataAdapter("SELECT DD_ID [Идент. номер на детайл на досие], DOSSIER_NO [Идент. номер на досие], INCEXP_ID [Идент. номер на приход/разход], DD_DATE [Дата на прихода], DD_VALUE [Стойност на прихода], DD_DOC [Документ] FROM DOSSIER_DETAILS Where DOSSIER_NO = " + ID_dossiers + "", con);
                    adapt.Fill(dossier_income_details);
                    add_income_cost_datagrid.DataSource = dossier_income_details;
                    if (type_income_cost_combobox.SelectedIndex == -1)
                    {
                        source_income_cost_combobox.Enabled = false;
                        source_income_cost_label.Enabled = false;
                        errorProvider_source_combobox.SetError(this.type_income_cost_combobox, "Изберете какво ще добавяте (приход/разход)");
                    }
                    if (add_income_cost_datagrid.RowCount == 0)
                    {
                        no_rows_label.Visible = true;
                        no_rows_label.ForeColor = Color.Red;
                        dossier_detail_chosen_id_label.Visible = false;
                        no_chosen_dossier_detail.Visible = false;
                    }
                    else
                    {
                        no_rows_label.Visible = false;
                    }
                }
                else if (numb_for_value <= 0)
                {
                    MessageBox.Show("Данните за стойност на прихода/разхода са невалидни");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Изберете ред за редактиране.");
                return;
            }
        }

        private void delete_income_cost_button_Click(object sender, EventArgs e)
        {
            if (dossier_detail_chosen_id.Visible == true)
            {
                ID_income_cost = Convert.ToInt32(dossier_detail_chosen_id.Text);
                ID_dossiers = Convert.ToInt32(dossier_chosen_id.Text);
                com = new SqlCommand("DELETE DOSSIER_DETAILS WHERE DD_ID=" + ID_income_cost + "", con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Данните са успешно изтрити");
                income_cost_dateTimePicker.Value = DateTime.Today;
                type_income_cost_combobox.SelectedIndex = -1;
                source_income_cost_combobox.SelectedIndex = -1;
                value_income_cost_textbox.Clear();
                document_income_cost_richtextbox.Clear();
                no_chosen_dossier_detail.Visible = true;
                dossier_detail_chosen_id.Visible = false;
                DataTable dossier_income_details = new DataTable();
                adapt = new SqlDataAdapter("SELECT DD_ID [Идент. номер на детайл на досие], DOSSIER_NO [Идент. номер на досие], INCEXP_ID [Идент. номер на приход/разход], DD_DATE [Дата на прихода], DD_VALUE [Стойност на прихода], DD_DOC [Документ] FROM DOSSIER_DETAILS Where DOSSIER_NO = " + ID_dossiers + "", con);
                adapt.Fill(dossier_income_details);
                add_income_cost_datagrid.DataSource = dossier_income_details;
                if (type_income_cost_combobox.SelectedIndex == -1)
                {
                    source_income_cost_combobox.Enabled = false;
                    source_income_cost_label.Enabled = false;
                    errorProvider_source_combobox.SetError(this.type_income_cost_combobox, "Изберете какво ще добавяте (приход/разход)");
                }
                if (add_income_cost_datagrid.RowCount == 0)
                {
                    no_rows_label.Visible = true;
                    no_rows_label.ForeColor = Color.Red;
                    dossier_detail_chosen_id_label.Visible = false;
                    no_chosen_dossier_detail.Visible = false;
                }
                else
                {
                    no_rows_label.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Изберете ред за изтриване.");
            }
        }

        private void dossier_datagrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            foreach (DataGridViewRow r in gridView.Rows)
            {
                gridView.Rows[r.Index].HeaderCell.Value = "Ред " + (r.Index + 1).ToString() + "";
                gridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            }
        }

        private void add_income_cost_datagrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            foreach (DataGridViewRow r in gridView.Rows)
            {
                gridView.Rows[r.Index].HeaderCell.Value = "Ред " + (r.Index + 1).ToString() + "";
                gridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            }
        }

        private void add_income_cost_datagrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dossier_detail_chosen_id.Text = Convert.ToInt32(add_income_cost_datagrid.Rows[e.RowIndex].Cells[0].Value.ToString()).ToString();
            ID_income_cost = Convert.ToInt32(add_income_cost_datagrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            dossier_detail_chosen_id.Visible = true;
            no_chosen_dossier_detail.Visible = false;
        }

        private void edit_income_cost_button_MouseHover(object sender, EventArgs e)
        {
            date_income_cost_label.Enabled = false;
            document_income_cost_label.Enabled = false;
            income_cost_dateTimePicker.Enabled = false;
            document_income_cost_richtextbox.Enabled = false;
        }

        private void edit_income_cost_button_MouseLeave(object sender, EventArgs e)
        {
            date_income_cost_label.Enabled = true;
            document_income_cost_label.Enabled = true;
            income_cost_dateTimePicker.Enabled = true;
            document_income_cost_richtextbox.Enabled = true;
        }
    }
}
