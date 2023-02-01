using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SzakTank2._0.Properties;

namespace SzakTank2._0
{
    public partial class UCMain : UserControl
    {
        public string UserName;
        public Button BtnStart;
        public UCMain(string User)
        {
            InitializeComponent();
            DrawMap();
            UserName = User;
            setTankColor();
        }

        private void DrawMap()
        {
            Random r = new Random();
            for (int i = 0; i < 56; i++)
            {
                Button btnTemp = new Button();

                btnTemp.Margin = new Padding(0);
                btnTemp.Name = "btn ";
                btnTemp.Size = new System.Drawing.Size(50, 50);
                btnTemp.TabIndex = 0;
                btnTemp.Text = "";
                btnTemp.UseVisualStyleBackColor = true;

                switch (r.Next(0, 5))
                {
                    case 0:
                        btnTemp.BackColor = Color.Brown;
                        break;
                    case 1:
                        btnTemp.BackColor = Color.Gray;
                        break;
                    default:
                        btnTemp.BackColor = Color.Green;
                        break;

                }

                fLP_Main.Controls.Add(btnTemp);

                if (i == 50)
                {
                    BtnStart = btnTemp;
                }
            }
        }

        private void button_RunCode_Click(object sender, EventArgs e)
        {
            if (textBox_Code.Text != null)
            {
                List<Command> commands = new List<Command>();
                string code = textBox_Code.Text;
                string[] lines = code.Split(';');
                int x = 0;
                int y = 0;
                for (int i = 0; i < lines.Length - 1; i++)
                {
                    commands.Add(new Command()
                    {
                        CommandName = lines[i].Substring(0, lines[i].IndexOf('(')),
                        CommandValue = Convert.ToInt32(lines[i].Substring(lines[i].IndexOf('(') + 1, lines[i].IndexOf(')') - lines[i].IndexOf('(') - 1))
                    });
                }
                string err = "";
                foreach (var com in commands)
                {
                    err += com.CommandName + " " + com.CommandValue;
                    switch (com.CommandName)
                    {
                        case "Előre":
                            x += com.CommandValue;
                            break;
                        case "Hátra":
                            x -= com.CommandValue;
                            break;
                        case "Jobbra":
                            y += com.CommandValue;
                            break;
                        case "Balra":
                            y -= com.CommandValue;
                            break;
                    }
                }
                label_Error.Text = err;
                DraweTank(x, y);
            }
        }

        private void setTankColor()
        {
            //Image TankImage;
            Color c = new Color();
            SqlConnection con = new SqlConnection(Resources.ConnString);
            con.Open();
            //check if the username is already taken
            SqlCommand cmd = new SqlCommand("SELECT Szin FROM Jatekos WHERE Felhasznalonev = @Username", con);
            cmd.Parameters.AddWithValue("@Username", UserName);
            int colorId = (int)cmd.ExecuteScalar();
            switch (colorId)
            {
                case 2:
                    //set color to blue
                    //TankImage = Resources.TankBlue;
                    c = Color.Blue;
                    break;
                case 3:
                    //yellow
                    //TankImage = Resources.TankYellow;
                    c = Color.Yellow;
                    break;
                default:
                    //red
                    //TankImage = Resources.TankRed;
                    c = Color.Red;
                    break;
            }
            BtnStart.BackColor = c;
        }

        private void DraweTank(int x, int y)
        {
            MessageBox.Show($"Posi x: {x}, y: {y}");
        }
    }
}
