using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2SI
{
    public partial class FormClients : Form
    {
        private string strcon = @"Server = .\SQLEXPRESS; Database=GestionMatos;Trusted_Connection=True;";
        public FormClients()
        {
            InitializeComponent();
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormClients_Load(object sender, EventArgs e)
        {
            affclients();
        }

        private void affclients()
        {
            listBoxClients.Items.Clear();
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            string sql = "select * from client";
            SqlCommand com = new SqlCommand(sql, cn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                listBoxClients.Items.Add(dr["Nom"].ToString());
            }

            dr.Close();
            cn.Close();
        }


        private void listBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxClients.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un client !!!");
                return;
            }

            string strnom = listBoxClients.SelectedItem.ToString();
            string sql = "select * from client where Nom = '" + strnom + "'";

            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            SqlCommand com = new SqlCommand(sql, cn);
            SqlDataReader dr = com.ExecuteReader();
            dr.Read();

            textBoxNom.Text = dr["Nom"].ToString();
            textBoxAdresse.Text = dr["Adresse"].ToString();
            textBoxMail.Text = dr["Mail"].ToString();
            textBoxTel.Text = dr["Tel"].ToString();

            dr.Close();
            cn.Close();
        }

        private Boolean checkName(string name)
        {
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            string strsqL = "select count(*) as compte from Client where Nom = '" + name + "'";

            SqlCommand com = new SqlCommand(strsqL, cn);
            SqlDataReader dr = com.ExecuteReader();
            dr.Read();
            int nb = Convert.ToInt32(dr["compte"]);
            cn.Close();

            if (nb == 0)
                return false;
            else
                return true;

        }
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (checkName(textBoxNom.Text.Trim()) == true)
            {
                MessageBox.Show("Nom déja présent", "ERREUR", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                textBoxNom.Focus();
                return;
            }


            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            string strsqL = "insert into client values('" + textBoxNom.Text + "','" +
                textBoxAdresse.Text + "','" + textBoxMail.Text + "','" +
                textBoxTel.Text + "')";

            SqlCommand com = new SqlCommand(strsqL, cn);
            com.ExecuteNonQuery();

            cn.Close();

            affclients();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (listBoxClients.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionnner un client", "ERREUR", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                listBoxClients.Focus();
                return;
            }

            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            string strsqL = "delete from CLIENT where Nom = '" + textBoxNom.Text + "'";

            SqlCommand com = new SqlCommand(strsqL, cn);
            com.ExecuteNonQuery();

            cn.Close();

            affclients();



        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            Boolean b = checkName(textBoxNom.Text);
            if (b == false)
            {
                MessageBox.Show("La société n'existe pas ", "ERREUR", MessageBoxButtons.OK,
                      MessageBoxIcon.Asterisk);
                textBoxNom.Focus();
                return;
            }

            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            string strsqL = "update client set Nom = '" + textBoxNom.Text +
                "', Adresse = '" + textBoxAdresse.Text + "', Mail = '" +
                textBoxMail.Text + "', Tel = '" + textBoxTel.Text + "' where Nom = '" +
                textBoxNom.Text + "'";

            SqlCommand com = new SqlCommand(strsqL, cn);
            com.ExecuteNonQuery();

            cn.Close();

            affclients();
        }

        private void buttonFermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
