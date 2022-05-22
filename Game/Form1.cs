using OOPLAB_1PreLab;
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

namespace OopLab
{
    public partial class Form1 : Form
    {
        Panel pnlMenu;
        private string _connectionString = "Data Source=sql5063.site4now.net;Initial Catalog=db_a855cf_ooplab; User Id = db_a855cf_ooplab_admin; Password=ataolcan123";
        private Users _currentUser;
        TableLayoutPanel gameBoard;


        public Form1()
        {
            InitializeComponent();
            pnlMenu = new Panel();
            pnlMenu.Location = new Point(180, 100);
            pnlMenu.BackColor = Color.FromArgb(47, 47, 47);
            pnlMenu.AutoSize = false;
            pnlMenu.Size = new Size(750, 450);
            pnlMenu.BorderStyle = BorderStyle.FixedSingle;
            _currentUser = UserManager.Instance;
            lblWelcome.Text = "Welcome: " + _currentUser.Username+"!";


        }

        private void createBoard()
        {
            //creating list for randomless
            //List<string> colorList = new List<string>();
            //List<string> shapeList = new List<string>();
            //if (Properties.Settings.Default.red == true) colorList.Add("Red");
            //if (Properties.Settings.Default.blue == true) colorList.Add("Blue");
            //if (Properties.Settings.Default.yellow == true) colorList.Add("Yellow");
            //if (Properties.Settings.Default.square == true) shapeList.Add("Square");
            //if (Properties.Settings.Default.triangle == true) shapeList.Add("Triangle");
            //if (Properties.Settings.Default.rounded == true) shapeList.Add("Rounded");

            //Random r = new Random();
            //int index = r.Next(colorList.Count);
            //string randomColor = colorList[index];

            //board size
            gameBoard = new TableLayoutPanel();
            if (Properties.Settings.Default.difficulty_level == 0)
            {
                gameBoard.RowCount = 9;
                gameBoard.ColumnCount = 9;
            }
            else if (Properties.Settings.Default.difficulty_level == 1)
            {
                gameBoard.RowCount = 9;
                gameBoard.ColumnCount = 9;
            }
            else if (Properties.Settings.Default.difficulty_level == 2)
            {
                gameBoard.RowCount = 9;
                gameBoard.ColumnCount = 9;
            }
            else if (Properties.Settings.Default.difficulty_level == 3)
            {
                gameBoard.RowCount = Properties.Settings.Default.customFirstVal;
                gameBoard.ColumnCount = Properties.Settings.Default.customSecVal;
            }


            //randomless




            gameBoard.Size = new Size(580, 580);
            gameBoard.Visible = true;
            gameBoard.Dock = DockStyle.Fill;
            gameBoard.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            gameBoard.AutoScroll = true;
            pnlBoard.Controls.Add(gameBoard);
            pnlBoard.AutoSize = true;
            pnlMain.Controls.Add(pnlBoard);

            for (int i = 0; i < 9; i++)
            {
                gameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, (float)100/9));
                gameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float)100 / 9));
            }

            getRandom();


            gameBoard.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            gameBoard.CellPaint += new TableLayoutCellPaintEventHandler(gameBoard_CellPaint);
        }

        private void getRandom()
        {
            Random r = new Random();
            int randomRow = r.Next(0, 9);
            int randomCol = r.Next(0, 9);
            int counter = 0;
            int randomColor = r.Next(0, 3); ; //0-red 1-blue -2yellow
            int randomShape = r.Next(0, 3); ; //0-square 1-triangle 3-rounded
            PictureBox pb = new PictureBox();
            while (true)
            {


                if (randomColor == 0 && Properties.Settings.Default.red == true)
                {
                    if (randomShape == 0 && Properties.Settings.Default.square == true)
                    {
                        pb = new PictureBox()
                        {
                            Image = Properties.Resources.Square_Red,
                            SizeMode = PictureBoxSizeMode.StretchImage
                        };
                        if (gameBoard.GetControlFromPosition(randomCol, randomRow) == null)
                        {
                            gameBoard.Controls.Add(pb, randomCol, randomRow);
                            counter++;
                        }
                    }
                }

                if (randomColor == 1 && Properties.Settings.Default.blue == true)
                {
                    if (randomShape == 0 && Properties.Settings.Default.square == true)
                    {
                        pb = new PictureBox()
                        {
                            Image = Properties.Resources.Square_Blue,
                            SizeMode = PictureBoxSizeMode.StretchImage
                        };
                        if (gameBoard.GetControlFromPosition(randomCol, randomRow) == null)
                        {
                            gameBoard.Controls.Add(pb, randomCol, randomRow);
                            counter++;
                        }
                    }
                }

                if (randomColor == 2 && Properties.Settings.Default.yellow == true)
                {
                    if (randomShape == 0 && Properties.Settings.Default.square == true)
                    {
                        pb = new PictureBox()
                        {
                            Image = Properties.Resources.Square_Blue,
                            SizeMode = PictureBoxSizeMode.StretchImage
                        };
                        if (gameBoard.GetControlFromPosition(randomCol, randomRow) == null)
                        {
                            gameBoard.Controls.Add(pb, randomCol, randomRow);
                            counter++;
                        }
                    }
                }

                //if (randomColor == 0 && Properties.Settings.Default.red == true)
                //{
                //    if (randomShape == 1 && Properties.Settings.Default.triangle == true)
                //    {
                //        PictureBox pb = new PictureBox()
                //        {
                //            Image = Properties.Resources.Triangle_Red,
                //            SizeMode = PictureBoxSizeMode.StretchImage
                //        };
                //    }
                //}

                if (randomColor == 0 && Properties.Settings.Default.red == true)
                {
                    if (randomShape == 2 && Properties.Settings.Default.rounded == true)
                    {
                        pb = new PictureBox()
                        {
                            Image = Properties.Resources.Rounded_Red,
                            SizeMode = PictureBoxSizeMode.StretchImage
                        };
                        if (gameBoard.GetControlFromPosition(randomCol, randomRow) == null)
                        {
                            gameBoard.Controls.Add(pb, randomCol, randomRow);
                            counter++;
                        }
                    }
                }

                if (randomColor == 1 && Properties.Settings.Default.blue == true)
                {
                    if (randomShape == 2 && Properties.Settings.Default.rounded == true)
                    {
                        pb = new PictureBox()
                        {
                            Image = Properties.Resources.Rounded_Blue,
                            SizeMode = PictureBoxSizeMode.StretchImage
                        };
                        if (gameBoard.GetControlFromPosition(randomCol, randomRow) == null)
                        {
                            gameBoard.Controls.Add(pb, randomCol, randomRow);
                            counter++;
                        }
                    }
                }

                if (randomColor == 2 && Properties.Settings.Default.yellow == true)
                {
                    if (randomShape == 2 && Properties.Settings.Default.rounded == true)
                    {
                        pb = new PictureBox()
                        {
                            Image = Properties.Resources.Rounded_Yellow,
                            SizeMode = PictureBoxSizeMode.StretchImage
                        };
                        if (gameBoard.GetControlFromPosition(randomCol, randomRow) == null)
                        {
                            gameBoard.Controls.Add(pb, randomCol, randomRow);
                            counter++;
                        }
                    }
                }





                if (counter == 3)
                {
                    counter = 0;
                    break;
                }
                randomRow = r.Next(0, 9);
                randomCol = r.Next(0, 9);
                randomColor = r.Next(0, 3); ; //0-red 1-blue -2yellow
                randomShape = r.Next(0, 3); ; //0-square 1-triangle 3-rounded
            }
        }

        private void gameBoard_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            e.Graphics.DrawLine(
            Pens.Black,
            e.CellBounds.Location,
            new Point(e.CellBounds.Right, e.CellBounds.Top)
            );
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.Show();
            settings.BringToFront();
            settings.TopMost = true;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = true;
            txtAddressFound.Text = _currentUser.Address;
            txtCityFound.Text = _currentUser.City;
            txtCountyFound.Text = _currentUser.Country;
            txtNameFound.Text = _currentUser.Name_Surname;
            txtPhoneFound.Text = _currentUser.Phone_Number;
            txtEmailFound.Text = _currentUser.Email;
        }

        private void btnUpdateMe_Click(object sender, EventArgs e)
        {
            string hashedPass = sha256Converter.ComputeSha256Hash(txtPasswordFound.Text);
            if (txtPasswordFound.Text != "" && txtNameFound.Text != "")
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("UPDATE Users SET Password = @password, Name_Surname = @namesurname, Phone_Number = @phone_number," +
                            " Address = @address, City = @city, Country = @county, Email = @email WHERE Username = @username", connection);
                        command.Parameters.AddWithValue("@password", hashedPass);
                        command.Parameters.AddWithValue("@namesurname", txtNameFound.Text);
                        command.Parameters.AddWithValue("@username", _currentUser.Username);
                        command.Parameters.AddWithValue("@phone_number", txtPhoneFound.Text);
                        command.Parameters.AddWithValue("@address", txtAddressFound.Text);
                        command.Parameters.AddWithValue("@city", txtCityFound.Text);
                        command.Parameters.AddWithValue("@county", txtCountyFound.Text);
                        command.Parameters.AddWithValue("@email", txtEmailFound.Text);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    txtPasswordFound.Clear();
                    txtNameFound.Clear();
                    txtPhoneFound.Clear();
                    txtAddressFound.Clear();
                    txtCityFound.Clear();
                    txtCountyFound.Clear();
                    txtEmailFound.Clear();
                    MessageBox.Show("User is uccessfully updated!");
                }
            }
            else MessageBox.Show("Password can't be empty!");
        }

        private void btnCloseProfile_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = false;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
            aboutForm.TopMost = true;
            this.Enabled = false;
        }

    }
}
