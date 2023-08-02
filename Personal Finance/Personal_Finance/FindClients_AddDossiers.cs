using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Personal_Finance
{
    public partial class FindClients_AddDossiers : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.constring);
        SqlCommand com;
        SqlDataAdapter adapt;
        int ID_clients = 0;
        int ID_dossiers = 0;
        public FindClients_AddDossiers()
        {
            InitializeComponent();
            Tip_for_clients.SetToolTip(this.clear_button_clients, "Изчистете данните от търсенето");
            Tip_for_dossiers.SetToolTip(this.clear_button_dossiers, "Изчистете данните от търсенето");
            DisplayClientsData();
            ClearData();
            clients_datagrid.AllowUserToResizeColumns = false;
            clients_datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            clients_datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            clients_datagrid.AllowUserToResizeRows = false;
            dossier_datagrid.AllowUserToResizeColumns = false;
            dossier_datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dossier_datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dossier_datagrid.AllowUserToResizeRows = false;
        }

        public Form RefToMainForm { get; set; }

        private void DisplayClientsData()
        {
            DataTable client = new DataTable();
            adapt = new SqlDataAdapter("SELECT CLIENT_ID [Идент. номер], CLIENT_EGN ЕГН, CLIENT_NAME Име, CLIENT_SURNAME Презиме, CLIENT_LASTNAME Фамилия, CLIENT_EMAIL Имейл, CLIENT_PHONE Телефон FROM CLIENT", con);
            adapt.Fill(client);
            clients_datagrid.DataSource = client;
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
            ID_clients = 0;
            ID_dossiers = 0;
            no_chosen_client_label.Visible = true;
            chosen_id_clients.Visible = false;
            chosen_id_clients_label.Visible = true;
            dossiers_groupbox.Enabled = false;
            dossier_search.Enabled = false;
            clear_button_dossiers.Enabled = false;
            add_dossier.Enabled = false;
            ident_number_textbox.Clear();
            first_name_textbox.Clear();
            sur_name_textbox.Clear();
            last_name_textbox.Clear();
            dossier_search_year_textbox.Clear();
            dossiers_status_search_combobox.SelectedIndex = -1;
            dossier_search_id_textbox.Clear();
            dossier_year_textbox.Clear();
            dossiers_add_status_combobox.SelectedIndex = -1;
            dossier_min_balance_textbox.Clear();
            DataTable dossier = new DataTable();
            dossier_datagrid.DataSource = dossier;
            dossier.Clear();
        }

        private void search_client_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT CLIENT_ID [Идент. номер], CLIENT_EGN ЕГН, CLIENT_NAME Име, CLIENT_SURNAME Презиме, CLIENT_LASTNAME Фамилия, CLIENT_EMAIL Имейл, CLIENT_PHONE Телефон FROM CLIENT where CLIENT_EGN like N'%" + ident_number_textbox.Text + "%' and CLIENT_NAME like N'%" + first_name_textbox.Text + "%' and CLIENT_SURNAME like N'%" + sur_name_textbox.Text + "%' and CLIENT_LASTNAME like N'%" + last_name_textbox.Text + "%'", con);
            adapt.Fill(dt);
            clients_datagrid.DataSource = dt;
            ID_clients = 0;
            ID_dossiers = 0;
            no_chosen_client_label.Visible = true;
            chosen_id_clients.Visible = false;
            chosen_id_clients_label.Visible = true;
            dossiers_groupbox.Enabled = false;
            dossier_search.Enabled = false;
            clear_button_dossiers.Enabled = false;
            add_dossier.Enabled = false;
            dossier_search_year_textbox.Clear();
            dossiers_status_search_combobox.SelectedIndex = -1;
            dossier_search_id_textbox.Clear();
            dossier_year_textbox.Clear();
            dossiers_add_status_combobox.SelectedIndex = -1;
            dossier_min_balance_textbox.Clear();
            DataTable dossier = new DataTable();
            dossier_datagrid.DataSource = dossier;
            dossier.Clear();
        }

        private void dossier_search_Click(object sender, EventArgs e)
        {
            ID_dossiers = Convert.ToInt32(chosen_id_clients.Text);
            if (dossiers_status_search_combobox.SelectedIndex == -1)
            {
                DataTable dossiers = new DataTable();
                adapt = new SqlDataAdapter("SELECT DOSSIER_NO [Идент. номер на досие], CLIENT_ID [Идент. номер на клиент], DOSSIER_YEAR [Година на досие], DOSSIER_STATUS [Статус на досие], DOSSIER_MIN_BALANCE [Мин. баланс на досието] FROM DOSSIER where DOSSIER_NO like '%" + dossier_search_id_textbox.Text + "%' and CLIENT_ID = " + ID_dossiers + " and DOSSIER_YEAR like '%" + dossier_search_year_textbox.Text + "%'", con);
                adapt.Fill(dossiers);
                dossier_datagrid.DataSource = dossiers;
            }
            else if (dossiers_status_search_combobox.SelectedIndex == 0)
            {
                DataTable dossiers = new DataTable();
                adapt = new SqlDataAdapter("SELECT DOSSIER_NO [Идент. номер на досие], CLIENT_ID [Идент. номер на клиент], DOSSIER_YEAR [Година на досие], DOSSIER_STATUS [Статус на досие], DOSSIER_MIN_BALANCE [Мин. баланс на досието] FROM DOSSIER where DOSSIER_NO like '%" + dossier_search_id_textbox.Text + "%' and CLIENT_ID = " + ID_dossiers + " and DOSSIER_STATUS = 'O' and DOSSIER_YEAR like '%" + dossier_search_year_textbox.Text + "%'", con);
                adapt.Fill(dossiers);
                dossier_datagrid.DataSource = dossiers;
            }
            else if (dossiers_status_search_combobox.SelectedIndex == 1)
            {
                DataTable dossiers = new DataTable();
                adapt = new SqlDataAdapter("SELECT DOSSIER_NO [Идент. номер на досие], CLIENT_ID [Идент. номер на клиент], DOSSIER_YEAR [Година на досие], DOSSIER_STATUS [Статус на досие], DOSSIER_MIN_BALANCE [Мин. баланс на досието] FROM DOSSIER where DOSSIER_NO like '%" + dossier_search_id_textbox.Text + "%' and CLIENT_ID = " + ID_dossiers + " and DOSSIER_STATUS = 'C' and DOSSIER_YEAR like '%" + dossier_search_year_textbox.Text + "%'", con);
                adapt.Fill(dossiers);
                dossier_datagrid.DataSource = dossiers;
            }
        }

        private void add_dossier_Click(object sender, EventArgs e)
        {
            ID_dossiers = Convert.ToInt32(chosen_id_clients.Text);
            if (dossier_year_textbox.Text == string.Empty)
            {
                MessageBox.Show("Добавете данни за година на досие");
                return;
            }
            if (dossiers_add_status_combobox.SelectedIndex == -1)
            {
                MessageBox.Show("Добавете данни за статус на досие");
                return;
            }
            if (dossier_min_balance_textbox.Text == string.Empty)
            {
                MessageBox.Show("Добавете данни за мин. баланс по досие");
                return;
            }
            string message = "Сигурни ли сте че искате да добавите досието?";
            string caption = "Добавяне на досие";
            var exit = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dossiers_add_status_combobox.SelectedIndex == 0)
            {
                if (exit == DialogResult.Yes)
                {
                    string query = "INSERT INTO DOSSIER (CLIENT_ID, DOSSIER_YEAR, DOSSIER_STATUS, DOSSIER_MIN_BALANCE) values ('" + ID_dossiers + "' , '" + dossier_year_textbox.Text + "' , 'O', '" + dossier_min_balance_textbox.Text.Replace(",", ".") + "')";
                    com = new SqlCommand(query, con);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Досието е добавено успешно!", "Message/Съобщение");
                    dossier_year_textbox.Clear();
                    dossiers_add_status_combobox.SelectedIndex = -1;
                    dossier_min_balance_textbox.Clear();
                    DataTable dossiers = new DataTable();
                    adapt = new SqlDataAdapter("SELECT DOSSIER_NO [Идент. номер на досие], CLIENT_ID [Идент. номер на клиент], DOSSIER_YEAR [Година на досие], DOSSIER_STATUS [Статус на досие], DOSSIER_MIN_BALANCE [Мин. баланс на досието] FROM DOSSIER where CLIENT_ID='" + ID_clients + "'", con);
                    adapt.Fill(dossiers);
                    dossier_datagrid.DataSource = dossiers;
                }
                else
                {
                    return;
                }
            }
            else if (dossiers_add_status_combobox.SelectedIndex == 1)
            {
                if(exit == DialogResult.Yes)
                {
                    string query = "INSERT INTO DOSSIER (CLIENT_ID, DOSSIER_YEAR, DOSSIER_STATUS, DOSSIER_MIN_BALANCE) values ('" + ID_dossiers + "' , '" + dossier_year_textbox.Text + "' , 'C', '" + dossier_min_balance_textbox.Text.Replace(",", ".") + "')";
                    com = new SqlCommand(query, con);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Досието е добавено успешно!", "Message/Съобщение");
                    dossier_year_textbox.Clear();
                    dossiers_add_status_combobox.SelectedIndex = -1;
                    dossier_min_balance_textbox.Clear();
                    DataTable dossiers = new DataTable();
                    adapt = new SqlDataAdapter("SELECT DOSSIER_NO [Идент. номер на досие], CLIENT_ID [Идент. номер на клиент], DOSSIER_YEAR [Година на досие], DOSSIER_STATUS [Статус на досие], DOSSIER_MIN_BALANCE [Мин. баланс на досието] FROM DOSSIER where CLIENT_ID='" + ID_clients + "'", con);
                    adapt.Fill(dossiers);
                    dossier_datagrid.DataSource = dossiers;
                }
                else
                {
                    return;
                }
            }
        }

        private void clients_datagrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            chosen_id_clients.Text = Convert.ToInt32(clients_datagrid.Rows[e.RowIndex].Cells[0].Value.ToString()).ToString();
            ID_clients = Convert.ToInt32(clients_datagrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            dossiers_groupbox.Enabled = true;
            dossier_search.Enabled = true;
            clear_button_dossiers.Enabled = true;
            add_dossier.Enabled = true;
            DataTable dossiers = new DataTable();
            adapt = new SqlDataAdapter("SELECT DOSSIER_NO [Идент. номер на досие], CLIENT_ID [Идент. номер на клиент], DOSSIER_YEAR [Година на досие], DOSSIER_STATUS [Статус на досие], DOSSIER_MIN_BALANCE [Мин. баланс на досието] FROM DOSSIER where CLIENT_ID='" + ID_clients + "'", con);
            adapt.Fill(dossiers);
            dossier_datagrid.DataSource = dossiers;
            chosen_id_clients_label.Visible = true;
            chosen_id_clients.Visible = true;
            no_chosen_client_label.Visible = false;
            dossier_search_year_textbox.Clear();
            dossier_search_id_textbox.Clear();
            dossiers_status_search_combobox.SelectedIndex = -1;
            dossier_year_textbox.Clear();
            dossiers_add_status_combobox.SelectedIndex = -1;
            dossier_min_balance_textbox.Clear();
        }

        private void clear_button_clients_Click(object sender, EventArgs e)
        {
            DisplayClientsData();
            ClearData();
        }

        private void clear_button_dossiers_Click(object sender, EventArgs e)
        {
            ID_dossiers = Convert.ToInt32(chosen_id_clients.Text);
            dossier_search_year_textbox.Clear();
            dossiers_status_search_combobox.SelectedIndex = -1;
            dossier_search_id_textbox.Clear();
            DataTable dossiers = new DataTable();
            adapt = new SqlDataAdapter("SELECT DOSSIER_NO [Идент. номер на досие], CLIENT_ID [Идент. номер на клиент], DOSSIER_YEAR [Година на досие], DOSSIER_STATUS [Статус на досие], DOSSIER_MIN_BALANCE [Мин. баланс на досието] FROM DOSSIER where CLIENT_ID='" + ID_clients + "'", con);
            adapt.Fill(dossiers);
            dossier_datagrid.DataSource = dossiers;
        }

        private void escape_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToMainForm.Show();
        }

        private void clients_datagrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            foreach (DataGridViewRow r in gridView.Rows)
            {
                gridView.Rows[r.Index].HeaderCell.Value = "Ред " + (r.Index + 1).ToString() + "";
                gridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
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
    }
}
