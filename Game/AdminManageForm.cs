﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace OopLab
{
    public partial class AdminManageForm : Form
    {

        private string _connectionString = "Data Source=sql5063.site4now.net;Initial Catalog=db_a855cf_ooplab; User Id = db_a855cf_ooplab_admin; Password=ataolcan123";
        List<Users> users = new List<Users>();
        public AdminManageForm()
        {
            InitializeComponent();
        }

        private void btnListUsers_Click(object sender, EventArgs e)
        {
            pnlDelete.Visible = false;
            pnlUpdate.Visible = false;
            pntAdd.Visible = false;
            dataGridView1.Visible = true;
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
            dataGridView1.Visible = false;
        }

        private void btnCompleteAdd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "" && txtNameSurname.Text != "")
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("INSERT INTO Users VALUES (@username, @password, @namesurname,@phone_number, @address, @city, @county, @email)", connection);
                        command.Parameters.AddWithValue("@username", txtUsername.Text);
                        command.Parameters.AddWithValue("@password", txtPassword.Text);
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
                        txtPasswordFound.Text = reader["Password"].ToString();
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
                        command.Parameters.AddWithValue("@password", txtPasswordFound.Text);
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
            dataGridView1.Visible = false;
        }
    }
}