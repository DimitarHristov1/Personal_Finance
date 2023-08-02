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
    public partial class Incomes_Form : Form
    {
        public event EventHandler CloseEvent;
        SqlConnection con = new SqlConnection(Properties.Settings.Default.constring);
        SqlCommand com;
        public Incomes_Form()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            listView_incomes.View = View.Details;

            listView_incomes.Columns.Add("Идент. номер на приход");
            listView_incomes.Columns.Add("Име на приход");
            listView_incomes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            con.Open();
            string queryString = "select * from INCOME_EXPNECE where INCEXP_TYPE = 'I'";
            com = new SqlCommand(queryString, con);
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                var item = new ListViewItem();
                item.Text = reader["INCEXP_ID"].ToString();
                item.SubItems.Add(reader["INCEXP_NAME"].ToString());
                listView_incomes.Items.Add(item);
            }
        }

        private void escape_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CloseForm()
        {
            var handler = CloseEvent;
            if (CloseEvent != null)
                CloseEvent(this, EventArgs.Empty);
        }
    }
}
