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
using System.Security.Cryptography;
using SzakTank2._0.Properties;

namespace SzakTank2._0
{
    public partial class UCLogin : UserControl
    {
        public UCLogin()
        {
            InitializeComponent();
        }

        private void btnBackL_Click(object sender, EventArgs e)
        {
            UCLR UCLogReg = new UCLR();
            Controls.Clear();
            Controls.Add(UCLogReg);
        }

        private void btnLoginL_Click(object sender, EventArgs e)
        {

            using SHA256 sha256 = SHA256.Create();

            byte[] buffer = Encoding.ASCII.GetBytes(tBLPass.Text);

            byte[] hashValue = sha256.ComputeHash(buffer);

            //check is if username and password is correct
            SqlConnection con = new SqlConnection(Resources.ConnString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Jatekos WHERE Felhasznalonev = @Username AND Jelszo = @Password", con);
            cmd.Parameters.AddWithValue("@Username", tBLUser.Text);
            cmd.Parameters.AddWithValue("@Password", hashValue);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Sikeres bejelentkezés!");

                //if so, open the main form
                UCModeSelector Main = new UCModeSelector(tBLUser.Text);
                Controls.Clear();
                Controls.Add(Main);
            }
            else
            {
                MessageBox.Show("Hibás felhasználónév vagy jelszó!");
            }
        }
    }
}
