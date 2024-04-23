using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2SI
{
    public partial class FormInscription : Form
    {
        private string strcon = @"Server = .\SQLEXPRESS; Database=GestionMatos;Trusted_Connection=True;";

        public FormInscription()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private string Hacher(string pwd)
        {
            SHA256 mySHA256 = SHA256.Create();
            ASCIIEncoding ascii = new ASCIIEncoding();
            byte[] hash = mySHA256.ComputeHash(ascii.GetBytes(pwd));

            string theash = BitConverter.ToString(hash).Replace("-", "");

            return theash;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();

            string login = textBoxLogin.Text;
            string pwd = textBoxPwd.Text;
            string hashpwd = Hacher(pwd);

            string strsqL = "insert into utilisateur values('" + login + "','" + hashpwd + "')";

            SqlCommand com = new SqlCommand(strsqL, cn);
            com.ExecuteNonQuery();

            MessageBox.Show("Nouvel utilisateur inscrit");

            cn.Close();

            this.Close();

        }

        private void FormInscription_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
