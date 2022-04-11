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



namespace OOPLAB_1PreLab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private string _connectionString = "Data Source=sql5063.site4now.net;Initial Catalog=db_a855cf_ooplab; User Id = db_a855cf_ooplab_admin; Password=ataolcan123";
        private void button1_Click(object sender, EventArgs e)
        {
            string hashedPassword = sha256Converter.ComputeSha256Hash(txtPassword.Text);
            Console.WriteLine(hashedPassword);
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

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }
    }
}
