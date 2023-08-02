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
    public partial class AddClient_EditDossiers : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.constring);
        SqlCommand com;
        SqlDataAdapter adapt;
        int ID_clients = 0;
        int ID_dossiers = 0;
        public AddClient_EditDossiers()
        {
            InitializeComponent();
            Tip_for_search_client.SetToolTip(this.search_client, "Не можете да търсите клиент по имейл и телефон!");
            Tip_for_clear_button.SetToolTip(this.clear_button, "Изчистете данните от търсенето");
            DisplayClientsData();
            ClearData();
            clients_datagrid.AllowUserToResizeColumns = false;
            clients_datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            clients_datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            clients_datagrid.AllowUserToResizeRows = false;
            dossier_datagrid.AllowUserToResizeColumns = false;
            dossier_datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
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
            dossiers_groupbox.Enabled = false;
            dossier_change.Enabled = false;
            DataTable dossier = new DataTable();
            dossier_datagrid.DataSource = dossier;
            dossier.Clear();
            closed_dossier.Visible = false;
            no_client_chosen.Visible = true;
            no_chosen_dossier.Visible = false;
            chosen_id_clients.Visible = false;
            chosen_id_clients_label.Visible = true;
            dossier_chosen_id.Visible = false;
            dossier_chosen_id_label.Visible = false;
            ident_number_textbox.Clear();
            first_name_textbox.Clear();
            sur_name_textbox.Clear();
            last_name_textbox.Clear();
            email_texbox.Clear();
            phone_textbox.Clear();
            dossier_year_textbox.Clear();
            dossiers_status_combobox.SelectedIndex = -1;
            dossier_min_balance_textbox.Clear();
        }

        private void add_client_Click(object sender, EventArgs e)
        {
            if (ident_number_textbox.Text == string.Empty)
            {
                MessageBox.Show("Добавете данни за ЕГН");
                return;
            }
            if (first_name_textbox.Text == string.Empty)
            {
                MessageBox.Show("Добавете данни за име");
                return;
            }
            if (sur_name_textbox.Text == string.Empty)
            {
                MessageBox.Show("Добавете данни за презиме");
                return;
            }
            if (last_name_textbox.Text == string.Empty)
            {
                MessageBox.Show("Добавете данни за фамилия");
                return;
            }
            if (email_texbox.Text == string.Empty)
            {
                MessageBox.Show("Добавете данни за имейл");
                return;
            }
            if (phone_textbox.Text == string.Empty)
            {
                MessageBox.Show("Добавете данни за телефон");
                return;
            }
            if (ident_number_textbox.TextLength <= 10)
            {
                string message = "Сигурни ли сте че искате да добавите клиента?";
                string caption = "Добавяне на клиент";
                var exit = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (exit == DialogResult.Yes)
                {
                    string query = "INSERT INTO CLIENT (CLIENT_EGN, CLIENT_NAME, CLIENT_SURNAME, CLIENT_LASTNAME, CLIENT_EMAIL, CLIENT_PHONE) VALUES (N'" + ident_number_textbox.Text + "',N'" + first_name_textbox.Text + "',N'" + sur_name_textbox.Text + "',N'" + last_name_textbox.Text + "',N'" + email_texbox.Text + "',N'" + phone_textbox.Text + "') INSERT INTO DOSSIER (CLIENT_ID, DOSSIER_YEAR, DOSSIER_STATUS, DOSSIER_MIN_BALANCE) values (IDENT_CURRENT('CLIENT') , year(getdate()) , 'O', 0)";
                    com = new SqlCommand(query, con);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Клиента е добавен успешно!", "Message/Съобщение");
                    DisplayClientsData();
                    ClearData();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Данните за ЕГН са невалидни");
                return;
            }
        }

        private void dossier_datagrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            dossier_year_textbox.Text = dossier_datagrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (dossier_datagrid.Rows[e.RowIndex].Cells[3].Value.ToString() == "O")
            {
                dossiers_status_combobox.SelectedIndex = 0;
            }
            else if (dossier_datagrid.Rows[e.RowIndex].Cells[3].Value.ToString() == "C")
            {
                dossiers_status_combobox.SelectedIndex = 1;
            }
            dossier_min_balance_textbox.Text = dossier_datagrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (chosen_id_clients.Visible == true)
            {
                dossier_chosen_id.Visible = true;
                dossier_chosen_id_label.Visible = true;
                no_chosen_dossier.Visible = false;
                dossier_chosen_id.Text = Convert.ToInt32(dossier_datagrid.Rows[e.RowIndex].Cells[0].Value.ToString()).ToString();
                if (dossiers_status_combobox.SelectedIndex == 0)
                {
                    dossier_change.Enabled = true;
                    closed_dossier.Visible = false;
                }
                else if (dossiers_status_combobox.SelectedIndex == 1)
                {
                    dossier_change.Enabled = false;
                    closed_dossier.Visible = true;
                }
            }
        }

        private void clients_datagrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dossiers_groupbox.Enabled = true;
            dossier_chosen_id_label.Visible = true;
            chosen_id_clients.Text = Convert.ToInt32(clients_datagrid.Rows[e.RowIndex].Cells[0].Value.ToString()).ToString();
            ID_clients = Convert.ToInt32(clients_datagrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            no_client_chosen.Visible = false;
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT DOSSIER_NO [Идент. номер на досие], CLIENT_ID [Идент. номер на клиент], DOSSIER_YEAR [Година на досие], DOSSIER_STATUS [Статус на досие], DOSSIER_MIN_BALANCE [Мин. баланс на досието] FROM DOSSIER where CLIENT_ID='" + ID_clients + "'", con);
            adapt.Fill(dt);
            dossier_datagrid.DataSource = dt;
            no_chosen_dossier.Visible = true;
            chosen_id_clients_label.Visible = true;
            chosen_id_clients.Visible = true;
            closed_dossier.Visible = false;
            ident_number_textbox.Text = clients_datagrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            first_name_textbox.Text = clients_datagrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            sur_name_textbox.Text = clients_datagrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            last_name_textbox.Text = clients_datagrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            email_texbox.Text = clients_datagrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            phone_textbox.Text = clients_datagrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            dossier_chosen_id.Visible = false;
            dossier_year_textbox.Clear();
            dossier_min_balance_textbox.Clear();
            dossiers_status_combobox.SelectedIndex = -1;
        }

        private void dossier_change_Click(object sender, EventArgs e)
        {
            ID_dossiers = Convert.ToInt32(dossier_chosen_id.Text);
            if (dossier_chosen_id.Visible == true)
            {
                if (dossier_year_textbox.Text == string.Empty)
                {
                    MessageBox.Show("Добавете данни за година на досие");
                    return;
                }
                if (dossiers_status_combobox.SelectedIndex == -1)
                {
                    MessageBox.Show("Добавете данни за статус на досие");
                    return;
                }
                if (dossier_min_balance_textbox.Text == string.Empty)
                {
                    MessageBox.Show("Добавете данни за мин. баланс по досие");
                    return;
                }
                if (dossiers_status_combobox.SelectedIndex == 0)
                {
                    com = new SqlCommand("UPDATE DOSSIER SET DOSSIER_YEAR=" + dossier_year_textbox.Text + ", DOSSIER_STATUS='O', DOSSIER_MIN_BALANCE=" + dossier_min_balance_textbox.Text.Replace(",",".") + " WHERE DOSSIER_NO=" + ID_dossiers + "", con);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Данните са успешно променени");
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("SELECT DOSSIER_NO [Идент. номер на досие], CLIENT_ID [Идент. номер на клиент], DOSSIER_YEAR [Година на досие], DOSSIER_STATUS [Статус на досие], DOSSIER_MIN_BALANCE [Мин. баланс на досието] FROM DOSSIER where CLIENT_ID='" + Convert.ToInt32(chosen_id_clients.Text) + "'", con);
                    adapt.Fill(dt);
                    dossier_datagrid.DataSource = dt;
                    dossier_year_textbox.Clear();
                    dossiers_status_combobox.SelectedIndex = -1;
                    dossier_min_balance_textbox.Clear();
                    no_chosen_dossier.Visible = true;
                    dossier_chosen_id.Visible = false;
                }
                else if (dossiers_status_combobox.SelectedIndex == 1)
                {
                    com = new SqlCommand("UPDATE DOSSIER SET DOSSIER_YEAR=" + dossier_year_textbox.Text + ", DOSSIER_STATUS='C', DOSSIER_MIN_BALANCE=" + dossier_min_balance_textbox.Text.Replace(",", ".") + " WHERE DOSSIER_NO=" + ID_dossiers + "", con);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Данните са успешно променени");
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("SELECT DOSSIER_NO [Идент. номер на досие], CLIENT_ID [Идент. номер на клиент], DOSSIER_YEAR [Година на досие], DOSSIER_STATUS [Статус на досие], DOSSIER_MIN_BALANCE [Мин. баланс на досието] FROM DOSSIER where CLIENT_ID='" + Convert.ToInt32(chosen_id_clients.Text) + "'", con);
                    adapt.Fill(dt);
                    dossier_datagrid.DataSource = dt;
                    dossier_year_textbox.Clear();
                    dossiers_status_combobox.SelectedIndex = -1;
                    dossier_min_balance_textbox.Clear();
                    no_chosen_dossier.Visible = true;
                    dossier_chosen_id.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Изберете ред за редактиране.");
                return;
            }
        }

        private void client_change_Click(object sender, EventArgs e)
        {
            if (ID_clients != 0)
            {
                if (ident_number_textbox.Text == string.Empty)
                {
                    MessageBox.Show("Добавете данни за ЕГН");
                    return;
                }
                if (first_name_textbox.Text == string.Empty)
                {
                    MessageBox.Show("Добавете данни за име");
                    return;
                }
                if (sur_name_textbox.Text == string.Empty)
                {
                    MessageBox.Show("Добавете данни за презиме");
                    return;
                }
                if (last_name_textbox.Text == string.Empty)
                {
                    MessageBox.Show("Добавете данни за фамилия");
                    return;
                }
                if (email_texbox.Text == string.Empty)
                {
                    MessageBox.Show("Добавете данни за имейл");
                    return;
                }
                if (phone_textbox.Text == string.Empty)
                {
                    MessageBox.Show("Добавете данни за телефон");
                    return;
                }
                if (ident_number_textbox.TextLength <= 10)
                {
                    com = new SqlCommand("UPDATE CLIENT SET CLIENT_EGN=N'" + ident_number_textbox.Text + "', CLIENT_NAME=N'" + first_name_textbox.Text + "', CLIENT_SURNAME=N'" + sur_name_textbox.Text + "', CLIENT_LASTNAME=N'" + last_name_textbox.Text + "', CLIENT_EMAIL=N'" + email_texbox.Text + "', CLIENT_PHONE=N'" + phone_textbox.Text + "' WHERE CLIENT_ID=" + ID_clients + "", con);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Данните са успешно променени");
                    DisplayClientsData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Данните за ЕГН са невалидни");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Изберете ред за редактиране.");
                return;
            }
        }

        private void escape_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToMainForm.Show();
        }

        private void search_client_Click(object sender, EventArgs e)
        {
            DataTable client = new DataTable();
            adapt = new SqlDataAdapter("SELECT CLIENT_ID [Идент. номер], CLIENT_EGN ЕГН, CLIENT_NAME Име, CLIENT_SURNAME Презиме, CLIENT_LASTNAME Фамилия, CLIENT_EMAIL Имейл, CLIENT_PHONE Телефон FROM CLIENT where CLIENT_EGN like N'%" + ident_number_textbox.Text + "%' and CLIENT_NAME like N'%" + first_name_textbox.Text + "%' and CLIENT_SURNAME like N'%" + sur_name_textbox.Text + "%' and CLIENT_LASTNAME like N'%" + last_name_textbox.Text + "%'", con);
            adapt.Fill(client);
            clients_datagrid.DataSource = client;
            ID_clients = 0;
            ID_dossiers = 0;
            dossiers_groupbox.Enabled = false;
            dossier_change.Enabled = false;
            DataTable dossier = new DataTable();
            dossier_datagrid.DataSource = dossier;
            dossier.Clear();
            closed_dossier.Visible = false;
            no_client_chosen.Visible = true;
            no_chosen_dossier.Visible = false;
            chosen_id_clients.Visible = false;
            chosen_id_clients_label.Visible = true;
            dossier_chosen_id.Visible = false;
            dossier_chosen_id_label.Visible = false;
            dossier_year_textbox.Clear();
            dossiers_status_combobox.SelectedIndex = -1;
            dossier_min_balance_textbox.Clear();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            DisplayClientsData();
            ClearData();
        }

        private void search_client_MouseHover(object sender, EventArgs e)
        {
            email_texbox.Enabled = false;
            email.Enabled = false;
            phone.Enabled = false;
            phone_textbox.Enabled = false;
        }

        private void search_client_MouseLeave(object sender, EventArgs e)
        {
            email_texbox.Enabled = true;
            email.Enabled = true;
            phone.Enabled = true;
            phone_textbox.Enabled = true;
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
