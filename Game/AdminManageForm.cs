using OOPLAB_1PreLab;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OopLab
{
    public partial class AdminManageForm : Form
    {

        private string _connectionString = "Data Source=sql5063.site4now.net;Initial Catalog=db_a855cf_ooplab; User Id = db_a855cf_ooplab_admin; Password=ataolcan123";
        List<Users> users = new List<Users>();
        public DataGridView dtg = new DataGridView();
        public AdminManageForm()
        {
            InitializeComponent();
        }

        private void btnListUsers_Click(object sender, EventArgs e)
        {
            pnlDelete.Visible = false;
            pnlUpdate.Visible = false;
            pntAdd.Visible = false;
            pnlScoreList.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.Refresh();
            dataGridView1.Dock = DockStyle.Fill;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Users", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Users user = new Users
                        {
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            Name_Surname = reader["Name_Surname"].ToString(),
                            Phone_Number = reader["Phone_Number"].ToString(),
                            Address = reader["Address"].ToString(),
                            City = reader["City"].ToString(),
                            Country = reader["Country"].ToString(),
                            Email = reader["Email"].ToString()
                        };
                        users.Add(user);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            dataGridView1.DataSource = users;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            pnlDelete.Visible = false;
            pnlUpdate.Visible = false;
            pntAdd.Visible = true;
            pnlScoreList.Visible = false;
            dataGridView1.Visible = false;
        }

        private void btnCompleteAdd_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text != "" && txtPassword.Text != "" && txtNameSurname.Text != "")
            {
                string hashedPassword = OOPLAB_1PreLab.sha256Converter.ComputeSha256Hash(txtPassword.Text);
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("INSERT INTO Users VALUES (@username, @password, @namesurname,@phone_number, @address, @city, @county, @email)", connection);
                        command.Parameters.AddWithValue("@username", txtUsername.Text);
                        command.Parameters.AddWithValue("@password", hashedPassword);
                        command.Parameters.AddWithValue("@namesurname", txtNameSurname.Text);
                        command.Parameters.AddWithValue("@phone_number", txtPhone.Text);
                        command.Parameters.AddWithValue("@address", txtAddress.Text);
                        command.Parameters.AddWithValue("@city", txtCity.Text);
                        command.Parameters.AddWithValue("@county", txtCountry.Text);
                        command.Parameters.AddWithValue("@email", txtEmail.Text);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtNameSurname.Clear();
                    txtPhone.Clear();
                    txtAddress.Clear();
                    txtCity.Clear();
                    txtCountry.Clear();
                    txtEmail.Clear();
                    MessageBox.Show("User is uccessfully added!");
                }
            }

            else
            {
                MessageBox.Show("Username, Password and Name,Surname can't be empty");

            }


        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            pnlDelete.Visible = false;
            pnlUpdate.Visible = true;
            pntAdd.Visible = false;
            pnlScoreList.Visible = false;
            dataGridView1.Visible = false;
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Username= @username", connection);
                    command.Parameters.AddWithValue("@username", txtFindUsername.Text);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        txtUsernameFound.Text = reader["Username"].ToString();
                        txtNameFound.Text = reader["Name_Surname"].ToString();
                        txtPhoneFound.Text = reader["Phone_Number"].ToString();
                        txtAddressFound.Text = reader["Address"].ToString();
                        txtCityFound.Text = reader["City"].ToString();
                        txtCountyFound.Text = reader["Country"].ToString();
                        txtEmailFound.Text = reader["Email"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                        command.Parameters.AddWithValue("@username", txtUsernameFound.Text);
                        command.Parameters.AddWithValue("@password", hashedPass);
                        command.Parameters.AddWithValue("@namesurname", txtNameFound.Text);
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
                    txtUsernameFound.Clear();
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

            else
            {
                MessageBox.Show("Password and Name,Surname can't be empty");

            }
        }

        private void btnDeleteComplete_Click(object sender, EventArgs e)
        {
            if (txtDeleteUsername.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure about deleting this user?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        try
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand("DELETE FROM Users WHERE Username = @deleteusername", connection);
                            command.Parameters.AddWithValue("@deleteusername", txtDeleteUsername.Text);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        txtDeleteUsername.Clear();
                        MessageBox.Show("User is deleted successfully!");
                    }
                }

            }
            else
            {
                MessageBox.Show("Username can't be empty!");

            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            pnlDelete.Visible = true;
            pnlUpdate.Visible = false;
            pntAdd.Visible = false;
            pnlScoreList.Visible = false;
            dataGridView1.Visible = false;
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtUsernameFound_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void btnScoreList_Click(object sender, EventArgs e)
        {
            pnlDelete.Visible = false;
            pnlUpdate.Visible = false;
            pntAdd.Visible = false;
            pnlScoreList.Visible = true;
            dataGridView1.Visible = false;
        }

        private void btnAscOrder_Click(object sender, EventArgs e)
        {
            pnlScoreList.Controls.Remove(dtg);
            dtg.Location = new System.Drawing.Point(28, 180);
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    var dataAdapter = new SqlDataAdapter("SELECT Username, MAX(Score_Value) As [Best Score] FROM Scores GROUP BY Username ORDER BY MAX(Score_Value) ASC", connection);
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dtg.ReadOnly = true;
                    dtg.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            pnlScoreList.Controls.Add(dtg);
            


        }

        private void btnDescOrder_Click(object sender, EventArgs e)
        {
            pnlScoreList.Controls.Remove(dtg);
            dtg.Location = new System.Drawing.Point(28, 180);
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    var dataAdapter = new SqlDataAdapter("SELECT Username, MAX(Score_Value) As [Best Score] FROM Scores GROUP BY Username ORDER BY MAX(Score_Value) DESC", connection);
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dtg.ReadOnly = true;
                    dtg.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            pnlScoreList.Controls.Add(dtg);


        }

    }
}
