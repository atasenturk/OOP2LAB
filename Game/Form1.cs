using OOPLAB_1PreLab;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace OopLab
{
    public partial class Form1 : Form
    {
        Panel pnlMenu;
        private string _connectionString = "Data Source=sql5063.site4now.net;Initial Catalog=db_a855cf_ooplab; User Id = db_a855cf_ooplab_admin; Password=ataolcan123";
        private Users _currentUser;
        public TableLayoutPanel gameBoard;
        List<int> sourceCoord = new List<int>();
        Point destCoord = new Point();
        public int point = 0;

        public Form1()
        {

            InitializeComponent();
            lblHighestScore.Text = "0";
            pnlMenu = new Panel();
            pnlMenu.Location = new Point(180, 100);
            pnlMenu.BackColor = Color.FromArgb(47, 47, 47);
            pnlMenu.AutoSize = false;
            pnlMenu.Size = new Size(750, 450);
            pnlMenu.BorderStyle = BorderStyle.FixedSingle;
            _currentUser = UserManager.Instance;
            lblWelcome.Text = "Welcome: " + _currentUser.Username + "!";
            createBoard();
            getHighestScore();

        }

        private void getHighestScore()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Scores WHERE Username = @username", connection);
                    command.Parameters.AddWithValue("@username", _currentUser.Username);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (Convert.ToInt32(reader["Score_Value"]) > Convert.ToInt32( lblHighestScore.Text))
                        {
                            lblHighestScore.Text = reader["Score_Value"].ToString();
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void createBoard()
        {
            if(Properties.Settings.Default.red == false && Properties.Settings.Default.blue == false && Properties.Settings.Default.yellow == false
                && Properties.Settings.Default.square == false && Properties.Settings.Default.rounded == false && Properties.Settings.Default.triangle == false)
            {
                Properties.Settings.Default.red = true;
                Properties.Settings.Default.blue = true;
                Properties.Settings.Default.triangle = true;
                Properties.Settings.Default.square = true;
            }


            //board size
            if (Properties.Settings.Default.difficulty_level == -1)
            {
                Properties.Settings.Default.difficulty_level = 0;
            }
            gameBoard = new TableLayoutPanel();
            if (Properties.Settings.Default.difficulty_level == 0)
            {
                gameBoard.RowCount = 15;
                gameBoard.ColumnCount = 15;
            }
            else if (Properties.Settings.Default.difficulty_level == 1)
            {
                gameBoard.RowCount = 9;
                gameBoard.ColumnCount = 9;
            }
            else if (Properties.Settings.Default.difficulty_level == 2)
            {
                gameBoard.RowCount = 6;
                gameBoard.ColumnCount = 6;
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
            gameBoard.AutoScroll = true;
            pnlBoard.Controls.Add(gameBoard);
            pnlBoard.AutoSize = true;
            pnlMain.Controls.Add(pnlBoard);

            for (int i = 0; i < gameBoard.RowCount; i++)
            {
                gameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, (float)100 / gameBoard.RowCount));
            }

            for (int i = 0; i < gameBoard.ColumnCount; i++)
            {
                gameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float)100 / gameBoard.ColumnCount));
            }

            gameBoard.MouseClick += new MouseEventHandler(clickOnSpace);
            getRandom();


            gameBoard.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            gameBoard.CellPaint += new TableLayoutCellPaintEventHandler(gameBoard_CellPaint);
        }

        private void clickOnSpace(object sender, MouseEventArgs e)
        {
            //x column, y row
            var cellPos = GetRowColIndex(gameBoard, gameBoard.PointToClient(Cursor.Position));
            Console.WriteLine("Dest coord: " + destCoord.Y + " " + destCoord.X);
            makeMove();
            sourceCoord.Clear();
            lblSourceCoord.Text = "";
        }

        private object GetRowColIndex(TableLayoutPanel gameBoard, Point point)
        {
            if (point.X > gameBoard.Width || point.Y > gameBoard.Height)
                return null;

            int w = gameBoard.Width;
            int h = gameBoard.Height;
            int[] widths = gameBoard.GetColumnWidths();

            int i;
            for (i = widths.Length - 1; i >= 0 && point.X < w; i--)
                w -= widths[i];
            int col = i + 1;

            int[] heights = gameBoard.GetRowHeights();
            for (i = heights.Length - 1; i >= 0 && point.Y < h; i--)
                h -= heights[i];

            int row = i + 1;
            destCoord.Y = row;
            destCoord.X = col;
            return new Point(col, row);
        }

        private void getRandom()
        {
            Random r = new Random();
            int randomRow = r.Next(0, gameBoard.RowCount);
            int randomCol = r.Next(0, gameBoard.ColumnCount);
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
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Tag = "Square_Red"

                        };
                        pb.MouseClick += new MouseEventHandler(clickPicture);
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
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Tag = "Square_Blue"
                        };
                        pb.MouseClick += new MouseEventHandler(clickPicture);
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
                            Image = Properties.Resources.Square_Yellow,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Tag = "Square_Yellow"
                        };
                        pb.MouseClick += new MouseEventHandler(clickPicture);
                        if (gameBoard.GetControlFromPosition(randomCol, randomRow) == null)
                        {
                            gameBoard.Controls.Add(pb, randomCol, randomRow);
                            counter++;
                        }
                    }
                }

                if (randomColor == 0 && Properties.Settings.Default.red == true)
                {
                    if (randomShape == 1 && Properties.Settings.Default.triangle == true)
                    {
                        pb = new PictureBox()
                        {
                            Image = Properties.Resources.Triangle_Red,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Tag = "Triangle_Red"
                        };
                        pb.MouseClick += new MouseEventHandler(clickPicture);
                        if (gameBoard.GetControlFromPosition(randomCol, randomRow) == null)
                        {
                            gameBoard.Controls.Add(pb, randomCol, randomRow);
                            counter++;
                        }
                    }
                }

                if (randomColor == 1 && Properties.Settings.Default.blue == true)
                {
                    if (randomShape == 1 && Properties.Settings.Default.triangle == true)
                    {
                        pb = new PictureBox()
                        {
                            Image = Properties.Resources.Triangle_Blue,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Tag = "Triangle_Blue"
                        };
                        pb.MouseClick += new MouseEventHandler(clickPicture);
                        if (gameBoard.GetControlFromPosition(randomCol, randomRow) == null)
                        {
                            gameBoard.Controls.Add(pb, randomCol, randomRow);
                            counter++;
                        }
                    }
                }

                if (randomColor == 2 && Properties.Settings.Default.yellow == true)
                {
                    if (randomShape == 1 && Properties.Settings.Default.triangle == true)
                    {
                        pb = new PictureBox()
                        {
                            Image = Properties.Resources.Triangle_Yellow,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Tag = "Triangle_Yellow"
                        };
                        pb.MouseClick += new MouseEventHandler(clickPicture);
                        if (gameBoard.GetControlFromPosition(randomCol, randomRow) == null)
                        {
                            gameBoard.Controls.Add(pb, randomCol, randomRow);
                            counter++;
                        }
                    }
                }

                if (randomColor == 0 && Properties.Settings.Default.red == true)
                {
                    if (randomShape == 2 && Properties.Settings.Default.rounded == true)
                    {
                        pb = new PictureBox()
                        {
                            Image = Properties.Resources.Rounded_Red,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Tag = "Rounded_Red"
                        };
                        pb.MouseClick += new MouseEventHandler(clickPicture);
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
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Tag = "Rounded_Blue"
                        };
                        pb.MouseClick += new MouseEventHandler(clickPicture);
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
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Tag = "Rounded_Yellow"
                        };
                        pb.MouseClick += new MouseEventHandler(clickPicture);
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
                randomRow = r.Next(0, gameBoard.RowCount);
                randomCol = r.Next(0, gameBoard.RowCount);
                randomColor = r.Next(0, 3); ; //0-red 1-blue -2yellow
                randomShape = r.Next(0, 3); ; //0-square 1-triangle 3-rounded
            }
            checkIfGameEnd();

        }

        private void checkIfGameEnd()
        {
            for (int i = 0; i < gameBoard.RowCount; i++)
            {
                for (int j = 0; j < gameBoard.ColumnCount; j++)
                {
                    if (gameBoard.GetControlFromPosition(j, i) == null)
                    {
                        return;
                    }
                }
            }
            MessageBox.Show("Game is over! Your point is " + point);
            addScoreToDB();
            point = 0;
            MessageBox.Show("Restart!");
            for (int i = 0; i < gameBoard.RowCount; i++)
            {
                for (int j = 0; j < gameBoard.ColumnCount; j++)
                {
                    gameBoard.Controls.Remove(gameBoard.GetControlFromPosition(j, i));
                }
            }
            getRandom();
            gameBoard.Refresh();
        }

        private void addScoreToDB()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Users VALUES (@username, @score)", connection);
                    command.Parameters.AddWithValue("@username", _currentUser.Username);
                    command.Parameters.AddWithValue("@password", point);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void clickPicture(object sender, MouseEventArgs e)
        {
            if (sourceCoord.Count == 0)
            {
                sourceCoord.Add(gameBoard.GetRow((PictureBox)sender));
                sourceCoord.Add(gameBoard.GetColumn((PictureBox)sender));
                lblSourceCoord.Text = (sourceCoord[0] + ", " + sourceCoord[1]);
            }
        }

        private void makeMove()
        {
            if (destCoord != null && sourceCoord.Count != 0)
            {
                if (minDistance() != -1)
                {
                    gameBoard.Controls.Add(gameBoard.GetControlFromPosition(sourceCoord[1], sourceCoord[0]), destCoord.X, destCoord.Y);
                    gameBoard.Controls.Remove(gameBoard.GetControlFromPosition(sourceCoord[1], sourceCoord[0]));
                    checkIfGetPoint();
                }
                else MessageBox.Show("There is an obstacle on path!");

            }
            else MessageBox.Show("You have to choose source");


        }

        private void checkIfGetPoint()
        {
            int startRowHorizontal = 0;
            int startRowVertical = 0;
            int startColHorizontal = 0;
            int startColVertical = 0;
            int horizontalCounter = 1;
            int verticalCounter = 1;
            for (int i = 0; i < gameBoard.RowCount; i++)
            {
                for (int j = 0; j < gameBoard.ColumnCount - 4; j++)
                {
                    if (gameBoard.GetControlFromPosition(j, i) != null)
                    {
                        PictureBox pb = new PictureBox();
                        pb.Tag = gameBoard.GetControlFromPosition(j, i).Tag;

                        //check horizonatally
                        for (int k = j + 1; k < j + 5; k++)
                        {
                            if (gameBoard.GetControlFromPosition(k, i) != null)
                            {
                                PictureBox pb2 = new PictureBox();
                                pb2.Tag = gameBoard.GetControlFromPosition(k, i).Tag;
                                if (pb.Tag != pb2.Tag)
                                {
                                    break;
                                }
                                else
                                {
                                    horizontalCounter++;
                                    if (horizontalCounter == 5)
                                    {
                                        startRowHorizontal = i;
                                        startColHorizontal = j;
                                    }
                                }
                            }
                        }
                    }
                    if (horizontalCounter == 5)
                    {
                        break;
                    }
                    horizontalCounter = 1;

                }
            }



            for (int i = 0; i < gameBoard.RowCount - 4; i++)
            {
                for (int j = 0; j < gameBoard.ColumnCount; j++)
                {
                    if (gameBoard.GetControlFromPosition(j, i) != null)
                    {
                        PictureBox pb = new PictureBox();
                        pb.Tag = gameBoard.GetControlFromPosition(j, i).Tag;

                        //check vertically
                        for (int k = i + 1; k < i + 5; k++)
                        {
                            if (gameBoard.GetControlFromPosition(j, k) != null)
                            {
                                PictureBox pb2 = new PictureBox();
                                pb2.Tag = gameBoard.GetControlFromPosition(j, k).Tag;
                                if (pb.Tag != pb2.Tag)
                                {
                                    break;
                                }
                                else
                                {
                                    verticalCounter++;
                                    if (verticalCounter == 5)
                                    {
                                        startRowVertical = i;
                                        startColVertical = j;
                                    }
                                }
                            }
                        }
                    }
                    if (verticalCounter == 5)
                    {
                        break;
                    }
                    verticalCounter = 1;

                }
            }


            if (horizontalCounter == 5)
            {
                for (int i = startColHorizontal; i < startColHorizontal + 5; i++)
                {
                    gameBoard.Controls.Remove(gameBoard.GetControlFromPosition(i, startRowHorizontal));
                }
                if (Properties.Settings.Default.difficulty_level == 0) point += 1;
                else if (Properties.Settings.Default.difficulty_level == 1) point += 3;
                else if (Properties.Settings.Default.difficulty_level == 2) point += 5;
                else if (Properties.Settings.Default.difficulty_level == 3) point += 2;
                getHighestScore();

            }


            if (verticalCounter == 5)
            {
                for (int i = startRowVertical; i < startRowVertical + 5; i++)
                {
                    gameBoard.Controls.Remove(gameBoard.GetControlFromPosition(startColVertical, i));
                }
                if (Properties.Settings.Default.difficulty_level == 0) point += 1;
                else if (Properties.Settings.Default.difficulty_level == 1) point += 3;
                else if (Properties.Settings.Default.difficulty_level == 2) point += 5;
                else if (Properties.Settings.Default.difficulty_level == 3) point += 2;
                getHighestScore();
            }
            else if (verticalCounter != 5 && horizontalCounter != 5)
            {
                getRandom();
            }
            lblPoint.Text = point.ToString();


        }

        int minDistance()
        {
            QItem source = new QItem(0, 0, 0);

            // To keep track of visited QItems. Marking
            // blocked cells as visited.
            bool[,] visited = new bool[gameBoard.RowCount, gameBoard.ColumnCount];
            for (int i = 0; i < gameBoard.RowCount; i++)
            {
                for (int j = 0; j < gameBoard.ColumnCount; j++)
                {
                    if (gameBoard.GetControlFromPosition(j, i) != null)
                        visited[i, j] = true;
                    else
                        visited[i, j] = false;

                    // Finding source
                    if (i == sourceCoord[0] && j == sourceCoord[1])
                    {
                        source.row = i;
                        source.col = j;
                    }
                }
            }

            // applying BFS on matrix cells starting from source
            Queue<QItem> q = new Queue<QItem>();
            q.Enqueue(source);
            visited[source.row, source.col] = true;
            while (q.Count != 0)
            {
                QItem p = q.First();
                q.Dequeue();

                // Destination found;
                if (p.row == destCoord.Y && p.col == destCoord.X)
                    return p.dist;

                // moving up
                if (p.row - 1 >= 0 &&
                    visited[p.row - 1, p.col] == false)
                {
                    q.Enqueue(new QItem(p.row - 1, p.col, p.dist + 1));
                    visited[p.row - 1, p.col] = true;
                }

                // moving down
                if (p.row + 1 < gameBoard.RowCount &&
                    visited[p.row + 1, p.col] == false)
                {
                    q.Enqueue(new QItem(p.row + 1, p.col, p.dist + 1));
                    visited[p.row + 1, p.col] = true;
                }

                // moving left
                if (p.col - 1 >= 0 &&
                    visited[p.row, p.col - 1] == false)
                {
                    q.Enqueue(new QItem(p.row, p.col - 1, p.dist + 1));
                    visited[p.row, p.col - 1] = true;
                }

                // moving right
                if (p.col + 1 < gameBoard.ColumnCount &&
                    visited[p.row, p.col + 1] == false)
                {
                    q.Enqueue(new QItem(p.row, p.col + 1, p.dist + 1));
                    visited[p.row, p.col + 1] = true;
                }
            }
            return -1;
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
            SettingsForm settings = new SettingsForm(this);
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

        private void button1_Click(object sender, EventArgs e)
        {
            getRandom();
        }
    }
}
