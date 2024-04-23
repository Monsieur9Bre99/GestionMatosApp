using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace WindowsFormsApp2SI
{
    public partial class FormMateriel : Form
    {
        private string strcon = @"Server = .\SQLEXPRESS; Database=GestionMatos;Trusted_Connection=True;";
        private string thenom;
        public FormMateriel()
        {
            InitializeComponent();
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void affMatos()
        {
            listBoxMatos.Items.Clear();
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            string sql = "select * from MATERIEL";
            SqlCommand com = new SqlCommand(sql, cn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                listBoxMatos.Items.Add(dr["Nom"].ToString());
            }

            dr.Close();
            cn.Close();
        }

        private void FormMateriel_Load(object sender, EventArgs e)
        {
            affMatos();
            fillComboClient();
        }

        private void fillComboClient()
        {
            comboBoxClient.Items.Clear();
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            string sql = "select * from client";
            SqlCommand com = new SqlCommand(sql, cn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                comboBoxClient.Items.Add(dr["Nom"].ToString());                
            }

            dr.Close();
            cn.Close();
        }

        private void listBoxMatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMatos.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un matériel !!");
                return;
            }

            string strnom = listBoxMatos.SelectedItem.ToString();
            string sql = "select * from MATERIEL where Nom = '" + strnom + "'";

            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            SqlCommand com = new SqlCommand(sql, cn);
            SqlDataReader dr = com.ExecuteReader();
            dr.Read();

            textBoxNom.Text = dr["Nom"].ToString();
            textBoxSerie.Text = dr["NoSerie"].ToString();
            dateTimePickerInstall.Value = Convert.ToDateTime(dr["Date_install"]);
            numericUpDownMTBF.Value = Convert.ToDecimal(dr["MTBF"]);
            textBoxType.Text = dr["Type"].ToString();
            textBoxMarque.Text = dr["Marque"].ToString();
            comboBoxClient.SelectedItem = findNameById(Convert.ToInt32(dr["ID_CLIENT"]));

            dr.Close();
            cn.Close();
        }

        private string findNameById(int id)
        {
            string sql = "select * from Client where ID_CLIENT = " + id.ToString();
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            SqlCommand com = new SqlCommand(sql, cn);
            SqlDataReader dr = com.ExecuteReader();
            dr.Read();
            string nom = dr["Nom"].ToString();            
            dr.Close();
            cn.Close();
            return nom;
        }

        private bool checkName(string name)
        {
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            string strsqL = "select count(*) as compte from MATERIEL where Nom = '" + name + "'";

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

        private int getCLientID(string name)
        {
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            string strsqL = "select ID_CLIENT from CLIENT where Nom = '" + name + "'";

            SqlCommand com = new SqlCommand(strsqL, cn);
            SqlDataReader dr = com.ExecuteReader();
            dr.Read();
            int nb = Convert.ToInt32(dr["ID_CLIENT"]);
            cn.Close();

            return nb;
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

            string nom = textBoxNom.Text;
            string nserie = textBoxSerie.Text;
            string type = textBoxType.Text;
            string marque = textBoxMarque.Text;

            string dateInstall = dateTimePickerInstall.Value.ToString("yyyy-MM-dd");
            string mtbf = numericUpDownMTBF.Value.ToString();
            int idc = getCLientID(comboBoxClient.SelectedItem.ToString());

            string strsqL = "insert into Materiel values('" + nom + "','" + nserie + "','" +
                dateInstall + "'," + mtbf + ",'" + type + "','" + marque + "'," + idc + ")";

            SqlCommand com = new SqlCommand(strsqL, cn);
            com.ExecuteNonQuery();
            cn.Close();
            affMatos();
            fillComboClient();
            MessageBox.Show("Matériel bien ajouté !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cleanMatos();
        }

        private void cleanMatos()
        {
            textBoxNom.Text = textBoxSerie.Text = textBoxType.Text = textBoxMarque.Text = "";

            dateTimePickerInstall.Value = DateTime.Today;
            numericUpDownMTBF.Value = 0;
            comboBoxClient.SelectedIndex = -1;
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (checkName(textBoxNom.Text.Trim()) == false)
            {
                MessageBox.Show("Matériel inexistant", "ERREUR", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                textBoxNom.Focus();
                return;
            }

            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();

            string nom = textBoxNom.Text;
            string nserie = textBoxSerie.Text;
            string type = textBoxType.Text;
            string marque = textBoxMarque.Text;

            string dateInstall = dateTimePickerInstall.Value.ToString("yyyy-MM-dd");
            string mtbf = numericUpDownMTBF.Value.ToString();
            int idc = getCLientID(comboBoxClient.SelectedItem.ToString());

            string strsqL = " UPDATE Materiel set Nom='" + nom + "', NoSerie = '" + nserie + 
                "', Date_install = '" + dateInstall + "', MTBF = " + mtbf +
                ", Type = '" + type + "', Marque = '" + marque + "', ID_CLIENT = " + idc +
                " where Nom = '" + listBoxMatos.SelectedItem.ToString() + "'";

   
            SqlCommand com = new SqlCommand(strsqL, cn);
            com.ExecuteNonQuery();
            cn.Close();
            affMatos();
            fillComboClient();
            MessageBox.Show("Matériel bien mis à jour !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cleanMatos();

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (listBoxMatos.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionnner un matériel", "ERREUR", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                listBoxMatos.Focus();
                return;
            }

            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            string strsqL = "delete from MATERIEL where Nom = '" + textBoxNom.Text + "'";

            SqlCommand com = new SqlCommand(strsqL, cn);
            com.ExecuteNonQuery();

            cn.Close();

            affMatos();
            cleanMatos();

        }

        private void buttonAddPicture_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG (*.jpg)|png (*.png)|(*.*)|*.*";
            DialogResult dr = dlg.ShowDialog();
            if (dr == DialogResult.OK)
            {
                thenom = dlg.FileName;
                /*
                string curdir = Directory.GetCurrentDirectory();

                string nameimage = Path.GetFileName(thenom);

                File.Move(thenom, curdir + "/images/" + nameimage);
                */
            }
        }
    }
}
