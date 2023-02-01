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
using SzakTank2._0.Properties;

namespace SzakTank2._0
{
    public partial class UCRegister : UserControl
    {
        public UCRegister()
        {
            InitializeComponent();
        }

        private void btnBackR_Click(object sender, EventArgs e)
        {
            UCLR UCLogReg = new UCLR();
            Controls.Clear();
            Controls.Add(UCLogReg);
        }

        private void btnRegR_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Resources.ConnString);
            con.Open();
            //check if the username is already taken
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Jatekos WHERE Felhasznalonev = @Username", con);
            cmd.Parameters.AddWithValue("@Username", tBRUser.Text);
            int count = (int)cmd.ExecuteScalar();
            if (count == 0)
            {
                //if not, chack if the passwords match and it is not empty
                if (tBRPass.Text == tBRPassA.Text && tBRPass.Text != "")
                {
                    //chacks color
                    //1 = Red, 2 = Blue, 3 = Yellow
                    int color = 1;
                    if (rBBlue.Checked)
                    {
                        color = 2;
                    }
                    else if (rBYellow.Checked)
                    {
                        color = 3;
                    }

                    //if so, insert the new user into the database
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO Jatekos (Felhasznalonev, Jelszo, Szin) VALUES (@Username, @Password, @Color)", con);
                    cmd2.Parameters.AddWithValue("@Username", tBRUser.Text);
                    cmd2.Parameters.AddWithValue("@Password", tBRPass.Text);
                    cmd2.Parameters.AddWithValue("@Color", color);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Sikeres regisztráció!");

                    //and log in
                    UCLogin UCLog = new UCLogin();
                    Controls.Clear();
                    Controls.Add(UCLog);
                }
                else
                {
                    MessageBox.Show("A két jelszó nem egyezik meg, vagy üres!");
                }
            }
            else
            {
                MessageBox.Show("A felhasználónév már foglalt!");
            }
            con.Close();
        }
    }
}
