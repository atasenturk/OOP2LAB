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
            lblWelcome.Text = "Hoşgeldiniz! " + _currentUser.Username;

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
    }
}
