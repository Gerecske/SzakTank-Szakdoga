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
        public int mapID;
        public int partCount = 0;
        public int movesLeft = 21;
        public int partsToGet = 0;
        public enum Direction { North, South, East, West };
        Direction direction = Direction.North;
        public UCMain(string User)
        {
            InitializeComponent();
            GenerateMap();
            UserName = User;
            setTankColor();
            DrawTank(0, 0, direction);

            lblPoints.Text = "Pontok:" + partCount;
            lblMoves.Text = "Lépések:" + movesLeft;
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
                if(i == 0)
                {
                    picTemp.BackColor = Color.Green;
                    mapValue[i] = 'G';
                }
                else
                {
                    switch (r.Next(0, 100))
                    {
                        case < 20:
                            picTemp.BackColor = Color.Red; // 20%
                            mapValue[i] = 'R';
                            break;
                        case < 40:
                            picTemp.BackColor = Color.Black; // 20%
                            mapValue[i] = 'B';
                            break;
                        case < 50:
                            picTemp.BackColor = Color.Yellow; //PART 10%
                            mapValue[i] = 'Y';
                            partsToGet++;
                            break;
                        default:
                            picTemp.BackColor = Color.Green; // 50%
                            mapValue[i] = 'G';
                            break;

                    }
                }
                picBoxT[mx,my] = picTemp;
                mx++;
                if (mx == 8)
                {
                    mx = 0;
                    my++;
                }



                fLPMain.Controls.Add(picTemp);
            }

            string StrMap = new string(mapValue);

            //uploadd to DB
            SqlConnection con = new SqlConnection(Resources.ConnString);
            SqlCommand cmd = new SqlCommand("INSERT INTO Terkep (Nev, TerkepMap, Pont) VALUES (@Nev, @TerkepMap, @Pont)", con);
            cmd.Parameters.AddWithValue("@Nev", "NévtelenMap");
            cmd.Parameters.AddWithValue("@TerkepMap", StrMap);
            cmd.Parameters.AddWithValue("@Pont", 0);
            con.Open();
            mapID = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
        }

        private void btnRunCodeClick(object sender, EventArgs e)
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
                            if ((y - intValue) >= 0 && picBoxT[x, (y - intValue)].BackColor != Color.Black)
                            {
                                y -= intValue;
                                direction = Direction.North;
                            }
                            else
                            {
                                MessageBox.Show("Nem tudsz tovább menni!");
                            }
                            break;
                        case "le":
                            // Perform action for "le" with value "intValue"
                            if ((y + intValue) <= 8 && picBoxT[x, (y + intValue)].BackColor != Color.Black)
                            {
                                y += intValue;
                                direction = Direction.South;
                            }
                            else
                            {
                                MessageBox.Show("Nem tudsz tovább menni!");
                            }
                            break;
                        case "jobbra":
                            // Perform action for "jobbra" with value "intValue"
                            if ((x + intValue) <= 8 && picBoxT[(x + intValue), y].BackColor != Color.Black)
                            {
                                x += intValue;
                                direction = Direction.East;
                            }
                            else
                            {
                                MessageBox.Show("Nem tudsz tovább menni!");
                            }
                            break;
                        case "balra":
                            // Perform action for "balra" with value "intValue"
                            if ((x - intValue) >= 0 && picBoxT[(x - intValue), y].BackColor != Color.Black)
                            {
                                x -= intValue;
                                direction = Direction.West;
                            }
                            else
                            {
                                MessageBox.Show("Nem tudsz tovább menni!");
                            }
                            break;
                        //case "lő":
                        //    //Shoot(x, y, direction);
                        //    break;
                        default:
                            MessageBox.Show("Nem megfelelő parancs! " + trimmedCommand.ToLower().Split('(')[0].Trim());
                            break;
                    }
                    DrawTank(x, y, direction);
                    
                    
                }

            }
            if (partsToGet == 0) // Found all the parts
            {
                MessageBox.Show("Gratulálok az összes alkatrészt összeszedted!");
                ResetWorolod();
            }
            if (movesLeft == 0) // No more moves left
            {
                MessageBox.Show($"Nincs több lépésed! De {partCount} alkatrészt találtál!");
                ResetWorolod();
            }
            
            LogMoveToDB();
            //DrawTank(x, y, direction);

            //MessageBox.Show($"Posi x: {x}, y: {y}, direction: {direction}");

        }

        //private void Shoot(int x, int y, Direction dir)
        //{
        //    MessageBox.Show("Lövésbe eljutottunk!");
        //    int sx = 0, sy = 0;
        //    int oldSx = 0, oldSy = 0;
        //    bool wall = false;
        //    Image BulletImgToUse = new Bitmap(TankImage);

        //    switch (dir)
        //    {
        //        case Direction.North:
        //            // No rotation needed for North direction
        //            if ((y - 1) >= 0 && picBoxT[x, (y - 1)].BackColor != Color.Black)
        //            {
        //                sx = x;
        //                sy = y - 1;
        //            }
        //            else
        //            {
        //                wall = true;
        //            }
        //            break;
        //        case Direction.South:     
        //            if ((y + 1) <= 8 && picBoxT[x, (y + 1)].BackColor != Color.Black)
        //            {
        //                sx = x;
        //                sy = y + 1;
        //            }
        //            else
        //            {
        //                wall = true;
        //                break;
        //            }
        //            BulletImgToUse.RotateFlip(RotateFlipType.Rotate180FlipNone);
        //            break;
        //        case Direction.East:
        //            if ((x + 1) <= 8 && picBoxT[(x + 1), y].BackColor != Color.Black)
        //            {
        //                sx = x + 1;
        //                sy = y;
        //            }
        //            else
        //            {
        //                wall = true;
        //                break;
        //            }
        //            BulletImgToUse.RotateFlip(RotateFlipType.Rotate90FlipNone);
        //            break;
        //        case Direction.West:
        //            if ((x - 1) >= 0 && picBoxT[(x - 1), y].BackColor != Color.Black)
        //                {
        //                sx = x + 1;
        //                sy = y;
        //            }
        //            else
        //            {
        //                wall = true;
        //                break;
        //            }
        //            BulletImgToUse.RotateFlip(RotateFlipType.Rotate270FlipNone);
        //            break;
        //    }
        //    if (wall == true)
        //    {
        //        MessageBox.Show("A falba nem lehet lőni!");
        //    }
        //    bool started = true;
        //    MessageBox.Show("While elöttig eljutottunk");
        //    while (((y - 1) >= 0 && picBoxT[x, (y - 1)].BackColor != Color.Black) &&
        //           ((y + 1) <= 8 && picBoxT[x, (y + 1)].BackColor != Color.Black) &&
        //           ((x + 1) <= 8 && picBoxT[(x + 1), y].BackColor != Color.Black) &&
        //           ((x - 1) >= 0 && picBoxT[(x - 1), y].BackColor != Color.Black) &&
        //           wall == false)
        //    {
        //        MessageBox.Show("Whileba bejutottunk");
        //        if (started)
        //        {
        //            started = false;
        //        }
        //        else
        //        {
        //            picBoxT[oldSx, oldSy].Image = null;
        //        }
        //        picBoxT[sx, sy].Image = BulletImgToUse;
        //        oldSx = sx;
        //        oldSy = sy;
        //        Task.Delay(500).Wait();
        //    }

        //}

        private void ResetWorolod()
        {
            LogEndToDB(UserName, mapID, partCount);

            // Reset the world
            UCMain Main = new UCMain(UserName);
            Controls.Clear();
            Controls.Add(Main);
        }

        private void setTankColor()
        {
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
                    break;
                case 3:
                    //yellow
                    TankImage = Resources.TankYellow;
                    break;
                default:
                    //red
                    TankImage = Resources.TankRed;
                    break;
            }
        }

        private void DrawTank(int x, int y, Direction dir)
        {
            Image TankImgToUse = new Bitmap(TankImage);
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
            picBoxT[oldx, oldy].Image = null;
            picBoxT[x, y].Image = TankImgToUse;
            if (picBoxT[x, y].BackColor == Color.Yellow)
            {
                partsToGet--;
                partCount++;
                lblPoints.Text = "Pontok:" + partCount;
                picBoxT[x, y].BackColor = Color.Green;
            }
            if (picBoxT[x, y].BackColor == Color.Red)
            {
                partCount = 0;
                lblPoints.Text = "Pontok:" + partCount;
                picBoxT[x, y].BackColor = Color.Green;
            }
            oldx = x; oldy = y;

            movesLeft--;
            lblMoves.Text = "Lépések:" + movesLeft;
        }

        private void LogMoveToDB()
        {
            string lepes = $"X:{oldx} Y:{oldy} X:{x} Y:{y}";

            //MessageBox.Show(lepes);

            SqlConnection con = new SqlConnection(Resources.ConnString);
            SqlCommand cmd = new SqlCommand("INSERT INTO Lepesek (TerkepID, Felhasznalonev, Lepes) VALUES (@TerkepID, @Felhasznalonv, @Lepes)", con);
            cmd.Parameters.AddWithValue("@TerkepID", mapID);
            cmd.Parameters.AddWithValue("@Felhasznalonv", UserName);
            cmd.Parameters.AddWithValue("@Lepes", lepes);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void LogEndToDB(string UserName, int mapID, int partCount)
        {
            SqlConnection con = new SqlConnection(Resources.ConnString);
            SqlCommand cmd = new SqlCommand("INSERT INTO Jatek (TerkepID, Felhasznalonev, Pont) VALUES (@TerkepID, @Felhasznalonv, @Pont)", con);
            cmd.Parameters.AddWithValue("@TerkepID", mapID);
            cmd.Parameters.AddWithValue("@Felhasznalonv", UserName);
            cmd.Parameters.AddWithValue("@Pont", partCount);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
