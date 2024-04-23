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
using System.Security.Cryptography;
using WindowsFormsApp2SI;

namespace WindowsFormsGMF
{
    public partial class FormConnect : Form
    {
        private bool bOK = false, bCancel = false;
        public FormConnect()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string pwd = textBoxPwd.Text;
            string hashpwd = Hacher(textBoxPwd.Text);

            string strcon = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";

            SqlConnection cn = null;
            SqlCommand com = null;
            SqlDataReader rd = null;

            try
            {
                cn = new SqlConnection(strcon);
                cn.Open();

                string strsql = "select COUNT(*) as nb from Utilisateur " +
                    "where Login = '" + login + "' and Pwd = '" + hashpwd + "'";

                com = new SqlCommand(strsql, cn);
                rd = com.ExecuteReader();
                rd.Read();

                int rep = Convert.ToInt32(rd["nb"]);

                if (rep > 0)
                {
                    this.bOK = true;
                    this.Close();
                }
                else
                {
                    textBoxLogin.Focus();              
                    MessageBox.Show("Identifiants incorrects");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
                Application.Exit();
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }                      

        }

        private string Hacher(string pwd)
        {
            SHA256 mySHA256 = SHA256.Create();
            ASCIIEncoding ascii = new ASCIIEncoding();
            byte[] hash = mySHA256.ComputeHash(ascii.GetBytes(pwd));

            string theash = BitConverter.ToString(hash).Replace("-", "");

            return theash;
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.bCancel = true;
            this.Close();
        }

        private void buttonInscription_Click(object sender, EventArgs e)
        {
            FormInscription frm = new FormInscription();
            frm.ShowDialog();

        }

        private void FormConnect_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.bCancel == true)
            {
                e.Cancel = false;
                Application.Exit();
            }
            else
            if (this.bOK == true)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
