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
    public delegate void ShowForm();
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.constring);
        SqlCommand com;
        SqlDataAdapter adapt;
        public Login()
        {
            InitializeComponent();
        }
        public event ShowForm Enable;

        private void login_button_Click(object sender, EventArgs e)
        {
            if (username_textbox.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете данни за потребителско име");
                return;
            }
            if (password_textbox.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете данни за парола");
                return;
            }
            com = new SqlCommand("Select * from USERS where USERNAME=@username COLLATE SQL_Latin1_General_CP1_CS_AS and PASSWORD=@password COLLATE SQL_Latin1_General_CP1_CS_AS", con);
            com.Parameters.AddWithValue("@username", username_textbox.Text);
            com.Parameters.AddWithValue("@password", password_textbox.Text);
            con.Open();
            adapt = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                Enable();
                this.Close();
            }
            else
            {
                MessageBox.Show("Грешно потребителско име или парола!");
                return;
            }
        }
    }
}
