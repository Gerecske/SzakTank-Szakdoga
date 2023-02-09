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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SzakTank2._0.Properties;

namespace SzakTank2._0
{
    public partial class UCMain : UserControl
    {
        public string UserName;
        public PictureBox pixStart;
        public UCMain(string User)
        {
            InitializeComponent();
            GenerateMap();
            UserName = User;
            setTankColor();
        }

        private void GenerateMap()
        {
            Random r = new Random();
            char[] mapValue = new char[64];
            for (int i = 0; i < 64; i++)
            {
                PictureBox picTemp = new PictureBox();

                picTemp.Margin = new Padding(0);
                picTemp.Name = "picBox" + i;
                picTemp.Size = new System.Drawing.Size(48, 48);
                picTemp.TabIndex = 0;
                picTemp.Text = "";

                switch (r.Next(0, 5))
                {
                    case 0:
                        picTemp.BackColor = Color.Brown;
                        mapValue[i] = 'B';
                        break;
                    case 1:
                        picTemp.BackColor = Color.Gray;
                        mapValue[i] = 'R';
                        break;
                    default:
                        picTemp.BackColor = Color.Green;
                        mapValue[i] = 'G';
                        break;

                }

                fLP_Main.Controls.Add(picTemp);

                if (i == 50)
                {
                    pixStart = picTemp;
                }
            }
            string StrMap = new string(mapValue);

            //uploadd to DB
            SqlConnection con = new SqlConnection(Resources.ConnString);
            SqlCommand cmd = new SqlCommand("INSERT INTO Terkep (Nev, TerkepMap, Pont) VALUES (@Nev, @TerkepMap, @Pont)", con);
            cmd.Parameters.AddWithValue("@Nev", "NévtelenMap");
            cmd.Parameters.AddWithValue("@TerkepMap", StrMap);
            cmd.Parameters.AddWithValue("@Pont", 0);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button_RunCode_Click(object sender, EventArgs e)
        {
            //if (textBox_Code.Text != null)
            //{
            //    List<Command> commands = new List<Command>();
            //    string code = textBox_Code.Text;
            //    string[] lines = code.Split(';');
            //    int x = 0;
            //    int y = 0;
            //    for (int i = 0; i < lines.Length - 1; i++)
            //    {
            //        commands.Add(new Command()
            //        {
            //            CommandName = lines[i].Substring(0, lines[i].IndexOf('(')),
            //            CommandValue = Convert.ToInt32(lines[i].Substring(lines[i].IndexOf('(') + 1, lines[i].IndexOf(')') - lines[i].IndexOf('(') - 1))
            //        });
            //    }
            //    string err = "";
            //    foreach (var com in commands)
            //    {
            //        err += com.CommandName + " " + com.CommandValue;
            //        switch (com.CommandName)
            //        {
            //            case "Előre":
            //                x += com.CommandValue;
            //                break;
            //            case "Hátra":
            //                x -= com.CommandValue;
            //                break;
            //            case "Jobbra":
            //                y += com.CommandValue;
            //                break;
            //            case "Balra":
            //                y -= com.CommandValue;
            //                break;
            //        }
            //    }
            //    label_Error.Text = err;
            //    DraweTank(x, y);
            //}



            int x, y;
            x = y = 0;
            string code = textBox_Code.Text;
            string[] commands = code.Split(';');

            foreach (string command in commands)
            {
                string trimmedCommand = command.Trim();
                Match match = Regex.Match(trimmedCommand, @"\(([^)]+)\)");

                if (match.Success)
                {
                    string value = match.Groups[1].Value;
                    int intValue = int.Parse(value);
                    MessageBox.Show(value);

                    switch (trimmedCommand.ToLower().Split('(')[0].Trim())
                    {
                        case "erlőre":
                            // Perform action for "erlőre" with value "intValue"
                            y += intValue;
                            break;
                        case "jobbra":
                            // Perform action for "jobra" with value "intValue"
                            x += intValue;
                            break;
                        case "balra":
                            // Perform action for "balra" with value "intValue"
                            x -= intValue;
                            break;
                        default:
                            // Handle unknown command
                            break;
                    }
                }
            }
            //DraweTank(x, y);
            MessageBox.Show($"Posi x: {x}, y: {y}");

        }

        private void setTankColor()
        {
            Image TankImage;
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
                    TankImage = Resources.TankBlue;
                    c = Color.Blue;
                    break;
                case 3:
                    //yellow
                    TankImage = Resources.TankYellow;
                    c = Color.Yellow;
                    break;
                default:
                    //red
                    TankImage = Resources.TankRed;
                    c = Color.Red;
                    break;
            }
            //pixStart.BackColor = c;
            pixStart.Image = Image.FromFile("C:\\Users\\szilg\\source\\repos\\SzakTank2.0\\Resources\\TankFullSmall.png");
        }

        private void DraweTank(int x, int y)
        {
            MessageBox.Show($"Posi x: {x}, y: {y}");
        }
    }
}
