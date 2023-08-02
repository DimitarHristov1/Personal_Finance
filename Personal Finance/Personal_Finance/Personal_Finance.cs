using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Finance
{
    public partial class Personal_Finance : Form
    {
        public Personal_Finance()
        {
            InitializeComponent();
            clients.Enabled = false;
            dossiers.Enabled = false;
            logout.Enabled = false;
        }

        private void новКлиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClient_EditDossiers new_client = new AddClient_EditDossiers();
            new_client.RefToMainForm = this;
            new_client.Show();
            this.Hide();
        }

        private void списъкСКлиентитеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchClients_AddAddresses client_list = new SearchClients_AddAddresses();
            client_list.RefToMainForm = this;
            client_list.Show();
            this.Hide();
        }

        private void търсенеИДобавянеНаДосиетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindClients_AddDossiers find_add_dossiers = new FindClients_AddDossiers();
            find_add_dossiers.RefToMainForm = this;
            find_add_dossiers.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Enable += new ShowForm(Enable);
            login.ShowDialog();
        }
        private void Enable()
        {
            login.Enabled = false;
            clients.Enabled = true;
            dossiers.Enabled = true;
            logout.Enabled = true;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            string message = "Сигурни ли сте че искате да излезнете от акаунта?";
            string caption = "Изход";
            var exit = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.No)
            {
                return;
            }
            else
            {
                login.Enabled = true;
                clients.Enabled = false;
                dossiers.Enabled = false;
                logout.Enabled = false;
            }
        }

        private void добавянеНаПриходиВДосиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adding_Income_Cost adding_income = new Adding_Income_Cost();
            adding_income.RefToMainForm = this;
            adding_income.Show();
            this.Hide();
        }
    }
}
