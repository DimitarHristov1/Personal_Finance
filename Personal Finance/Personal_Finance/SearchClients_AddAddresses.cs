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
    public partial class SearchClients_AddAddresses : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.constring);
        SqlCommand com;
        SqlDataAdapter adapt;
        int ID_clients = 0;
        int ID_addresses = 0;
        public SearchClients_AddAddresses()
        {
            InitializeComponent();
            Tip_for_clear_button.SetToolTip(this.clear_button, "Изчистете данните от търсенето");
            DisplayData_Clients();
            DisplayData_Addresses();
            ClearData();
            clients_datagrid.AllowUserToResizeColumns = false;
            clients_datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            clients_datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            clients_datagrid.AllowUserToResizeRows = false;
            addresses_datagrid.AllowUserToResizeColumns = false;
            addresses_datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            addresses_datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            addresses_datagrid.AllowUserToResizeRows = false;
        }

        public Form RefToMainForm { get; set; }

        private void DisplayData_Clients()
        {
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT CLIENT_ID [Идент. номер], CLIENT_EGN ЕГН, CLIENT_NAME Име, CLIENT_SURNAME Презиме, CLIENT_LASTNAME Фамилия, CLIENT_EMAIL Имейл, CLIENT_PHONE Телефон FROM CLIENT", con);
            adapt.Fill(dt);
            clients_datagrid.DataSource = dt;
        }
        private void DisplayData_Addresses()
        {
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT ADDRESS_ID [Идент. номер на адрес], CLIENT_ID [Идент. номер на клиент], ADDRESS_TYPE [Тип адрес], ADDRESS_REGION [Регион], ADDRES_MUNICIPALITY Община, ADDRESS_PLACE [Местонахождение на адреса], ADDRESS_PCODE [Пощенски код], ADDRESS_TEXT [Наименование на адреса] FROM ADDRESS", con);
            adapt.Fill(dt);
            addresses_datagrid.DataSource = dt;
        }
        private void ClearData()
        {
            ID_clients = 0;
            ID_addresses = 0;
            chosen_id.Visible = false;
            add_address.Enabled = false;
            addresses_groupbox.Enabled = false;
            no_rows_label.Visible = false;
            no_chosen_client_label.Visible = true;
            ident_number_textbox.Clear();
            first_name_textbox.Clear();
            sur_name_textbox.Clear();
            last_name_textbox.Clear();
            email_texbox.Clear();
            phone_textbox.Clear();
            address_region_textbox.Clear();
            address_minicipality_textbox.Clear();
            address_place_textbox.Clear();
            address_postcode_textbox.Clear();
            address_text_textbox.Clear();
            address_type_combobox.SelectedIndex = -1;
            DataTable addresses = new DataTable();
            addresses_datagrid.DataSource = addresses;
            addresses.Clear();
        }
        
        private void search_client_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT CLIENT_ID [Идент. номер], CLIENT_EGN ЕГН, CLIENT_NAME Име, CLIENT_SURNAME Презиме, CLIENT_LASTNAME Фамилия, CLIENT_EMAIL Имейл, CLIENT_PHONE Телефон FROM CLIENT where CLIENT_EGN like N'%" + ident_number_textbox.Text + "%' and CLIENT_NAME like N'%" + first_name_textbox.Text + "%' and CLIENT_SURNAME like N'%" + sur_name_textbox.Text + "%' and CLIENT_LASTNAME like N'%" + last_name_textbox.Text + "%' and CLIENT_EMAIL like N'%" + email_texbox.Text + "%' and CLIENT_PHONE like N'%" + phone_textbox.Text + "%'", con);
            adapt.Fill(dt);
            clients_datagrid.DataSource = dt;
            ID_clients = 0;
            ID_addresses = 0;
            chosen_id.Visible = false;
            add_address.Enabled = false;
            addresses_groupbox.Enabled = false;
            no_rows_label.Visible = false;
            no_chosen_client_label.Visible = true;
            address_region_textbox.Clear();
            address_minicipality_textbox.Clear();
            address_place_textbox.Clear();
            address_postcode_textbox.Clear();
            address_text_textbox.Clear();
            address_type_combobox.SelectedIndex = -1;
            DataTable addresses = new DataTable();
            addresses_datagrid.DataSource = addresses;
            addresses.Clear();
        }

        private void clients_datagrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            chosen_id.Text = Convert.ToInt32(clients_datagrid.Rows[e.RowIndex].Cells[0].Value.ToString()).ToString();
            ID_clients = Convert.ToInt32(clients_datagrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            add_address.Enabled = true;
            addresses_groupbox.Enabled = true;
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT ADDRESS_ID [Идент. номер на адрес], CLIENT_ID [Идент. номер на клиент], ADDRESS_TYPE [Тип адрес], ADDRESS_REGION [Регион], ADDRES_MUNICIPALITY Община, ADDRESS_PLACE [Местонахождение на адреса], ADDRESS_PCODE [Пощенски код], ADDRESS_TEXT [Наименование на адреса] FROM ADDRESS where CLIENT_ID='" + ID_clients + "'", con);
            adapt.Fill(dt);
            addresses_datagrid.DataSource = dt;
            chosen_id.Visible = true;
            no_chosen_client_label.Visible = false;
            if (addresses_datagrid.RowCount == 0)
            {
                no_rows_label.Visible = true;
                no_rows_label.ForeColor = Color.Red;
            }
            else
            {
                no_rows_label.Visible = false;
            }
        }

        private void add_address_Click(object sender, EventArgs e)
        {
            ID_addresses = Convert.ToInt32(chosen_id.Text);
            if (address_type_combobox.SelectedIndex == -1)
            {
                MessageBox.Show("Добавете данни за тип");
                return;
            }
            if (address_region_textbox.Text == string.Empty)
            {
                MessageBox.Show("Добавете данни за регион");
                return;
            }
            if (address_minicipality_textbox.Text == string.Empty)
            {
                MessageBox.Show("Добавете данни за община");
                return;
            }
            if (address_place_textbox.Text == string.Empty)
            {
                MessageBox.Show("Добавете данни за място");
                return;
            }
            if (address_postcode_textbox.Text == string.Empty)
            {
                MessageBox.Show("Добавете данни за пощенски код");
                return;
            }
            if (address_text_textbox.Text == string.Empty)
            {
                MessageBox.Show("Добавете данни за наименование на адрес");
                return;
            }
            string message = "Сигурни ли сте че искате да добавите адреса?";
            string caption = "Добавяне на адрес";
            var exit = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (address_type_combobox.SelectedIndex == 0)
            {
                if (exit == DialogResult.Yes)
                {
                    string query = "INSERT INTO ADDRESS (CLIENT_ID, ADDRESS_TYPE, ADDRESS_REGION, ADDRES_MUNICIPALITY, ADDRESS_PLACE, ADDRESS_PCODE , ADDRESS_TEXT) VALUES ('" + ID_addresses + "', 'P',N'" + address_region_textbox.Text + "',N'" + address_minicipality_textbox.Text + "',N'" + address_place_textbox.Text + "',N'" + address_postcode_textbox.Text + "',N'" + address_text_textbox.Text + "')";
                    com = new SqlCommand(query, con);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Адресът е добавен успешно!", "Message/Съобщение");
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("SELECT ADDRESS_ID [Идент. номер на адрес], CLIENT_ID [Идент. номер на клиент], ADDRESS_TYPE [Тип адрес], ADDRESS_REGION [Регион], ADDRES_MUNICIPALITY Община, ADDRESS_PLACE [Местонахождение на адреса], ADDRESS_PCODE [Пощенски код], ADDRESS_TEXT [Наименование на адреса] FROM ADDRESS where CLIENT_ID='" + ID_addresses + "'", con);
                    adapt.Fill(dt);
                    addresses_datagrid.DataSource = dt;
                    address_region_textbox.Clear();
                    address_minicipality_textbox.Clear();
                    address_place_textbox.Clear();
                    address_postcode_textbox.Clear();
                    address_text_textbox.Clear();
                    address_type_combobox.SelectedIndex = -1;
                    if (addresses_datagrid.RowCount == 0)
                    {
                        no_rows_label.Visible = true;
                        no_rows_label.ForeColor = Color.Red;
                    }
                    else
                    {
                        no_rows_label.Visible = false;
                    }
                }
                else
                {
                    return;
                }
            }
            else if (address_type_combobox.SelectedIndex == 1)
            {
                if (exit == DialogResult.Yes)
                {
                    string query = "INSERT INTO ADDRESS (CLIENT_ID, ADDRESS_TYPE, ADDRESS_REGION, ADDRES_MUNICIPALITY, ADDRESS_PLACE, ADDRESS_PCODE , ADDRESS_TEXT) VALUES ('" + ID_addresses + "', 'K',N'" + address_region_textbox.Text + "',N'" + address_minicipality_textbox.Text + "',N'" + address_place_textbox.Text + "',N'" + address_postcode_textbox.Text + "',N'" + address_text_textbox.Text + "')";
                    com = new SqlCommand(query, con);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Адресът е добавен успешно!", "Message/Съобщение");
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("SELECT ADDRESS_ID [Идент. номер на адрес], CLIENT_ID [Идент. номер на клиент], ADDRESS_TYPE [Тип адрес], ADDRESS_REGION [Регион], ADDRES_MUNICIPALITY Община, ADDRESS_PLACE [Местонахождение на адреса], ADDRESS_PCODE [Пощенски код], ADDRESS_TEXT [Наименование на адреса] FROM ADDRESS where CLIENT_ID='" + ID_addresses + "'", con);
                    adapt.Fill(dt);
                    addresses_datagrid.DataSource = dt;
                    address_region_textbox.Clear();
                    address_minicipality_textbox.Clear();
                    address_place_textbox.Clear();
                    address_postcode_textbox.Clear();
                    address_text_textbox.Clear();
                    address_type_combobox.SelectedIndex = -1;
                    if (addresses_datagrid.RowCount == 0)
                    {
                        no_rows_label.Visible = true;
                        no_rows_label.ForeColor = Color.Red;
                    }
                    else
                    {
                        no_rows_label.Visible = false;
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void escape_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToMainForm.Show();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            DisplayData_Clients();
            ClearData();
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

        private void addresses_datagrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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
