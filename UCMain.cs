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
        public PictureBox[,] picBoxT = new PictureBox[8, 8];
        public Image TankImage = Resources.TankRed;
        public int x = 0, y = 0;
        public int oldx = 0, oldy = 0;
        public enum Direction { North, South, East, West };
        Direction direction = Direction.North;
        bool NeedsToRotate = false;
        public UCMain(string User)
        {
            InitializeComponent();
            GenerateMap();
            UserName = User;
            setTankColor();
            DrawTank(0, 0, direction);
        }

        private void GenerateMap()
        {
            Random r = new Random();
            char[] mapValue = new char[64];
            int mx = 0, my = 0;

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
                picBoxT[mx,my] = picTemp;
                mx++;
                if (mx == 8)
                {
                    mx = 0;
                    my++;
                }



                fLP_Main.Controls.Add(picTemp);
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

            string code = tbCode.Text;
            string[] commands = code.Split(';');

            foreach (string command in commands)
            {
                string trimmedCommand = command.Trim();
                Match match = Regex.Match(trimmedCommand, @"\(([^)]+)\)");

                if (match.Success)
                {
                    string value = match.Groups[1].Value;
                    int intValue = int.Parse(value);

                    switch (trimmedCommand.ToLower().Split('(')[0].Trim())
                    {
                        case "fel":
                            // Perform action for "erlőre" with value "intValue"
                            if ((y - intValue) >= 0)
                            {
                                y -= intValue;
                                if (direction == Direction.North)
                                {
                                    NeedsToRotate = false;
                                }
                                else
                                {
                                    direction = Direction.North;
                                    NeedsToRotate = true;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nem tudsz tovább menni!");
                            }
                            break;
                        case "le":
                            // Perform action for "le" with value "intValue"
                            if ((y + intValue) <= 8)
                            {
                                y += intValue;
                                if (direction == Direction.South)
                                {
                                    NeedsToRotate = false;
                                }
                                else
                                {
                                    direction = Direction.South;
                                    NeedsToRotate = true;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nem tudsz tovább menni!");
                            }
                            break;
                        case "jobbra":
                            // Perform action for "jobbra" with value "intValue"
                            if ((x + intValue) <= 8)
                            {
                                x += intValue;
                                if (direction == Direction.East)
                                {
                                    NeedsToRotate = false;
                                }
                                else
                                {
                                    direction = Direction.East;
                                    NeedsToRotate = true;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nem tudsz tovább menni!");
                            }
                            break;
                        case "balra":
                            // Perform action for "balra" with value "intValue"
                            if ((x - intValue) >= 0)
                            {
                                x -= intValue;
                                if (direction == Direction.West)
                                {
                                    NeedsToRotate = false;
                                }
                                else
                                {
                                    direction = Direction.West;
                                    NeedsToRotate = true;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nem tudsz tovább menni!");
                            }
                            break;
                        default:
                            MessageBox.Show("Nem megfelelő parancs! " + trimmedCommand.ToLower().Split('(')[0].Trim());
                            break;
                    }
                }
            }
            DrawTank(x, y, direction);
            MessageBox.Show($"Posi x: {x}, y: {y}");

        }

        private void setTankColor()
        {
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
        }

        private void DrawTank(int x, int y, Direction dir)
        {
            Image TankImgToUse = new Bitmap(TankImage);
            if (NeedsToRotate)
            {
                switch (dir)
                {
                    case Direction.North:
                        // No rotation needed for North direction
                        break;
                    case Direction.South:
                        TankImgToUse.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        break;
                    case Direction.East:
                        TankImgToUse.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        break;
                    case Direction.West:
                        TankImgToUse.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        break;
                }
            }
            picBoxT[oldx, oldy].Image = null;
            picBoxT[x, y].Image = TankImgToUse;
            oldx = x; oldy = y;
        }
    }
}
