using OopLab;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOPLAB_1PreLab
{
    public partial class Form1 : Form
    {
        List<Users> users = new List<Users>();
        List<Admin> admins = new List<Admin>();
        public static UserManager _userManager;
        private string _connectionString = "Data Source=sql5063.site4now.net;Initial Catalog=db_a855cf_ooplab; User Id = db_a855cf_ooplab_admin; Password=ataolcan123";
        public Form1()
        {
            InitializeComponent();

            admins.Add(new Admin
            {
                userName = "admin",
                password = "admin"
            });
            radioUser.Checked = true;
            getSuccessfulLogin();
            txtPassword.PasswordChar = '*';

        }

        private void getSuccessfulLogin()
        {
            txtUsername.Text = Properties.Settings.Default.userName;
            txtPassword.Text = Properties.Settings.Default.password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hashedPassword = sha256Converter.ComputeSha256Hash(txtPassword.Text);
            bool validateLogin = false;
            Users currentUser = new Users();
            if (radioUser.Checked == true)
            {
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
                            if (user.Username == txtUsername.Text && user.Password == hashedPassword)
                            {
                                currentUser = user;
                                validateLogin = true;
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

            if (radioAdmin.Checked == true)
            {
                foreach (var ad in admins)
                {
                    if (txtUsername.Text == ad.userName && txtPassword.Text == ad.password)
                    {
                        validateLogin = true;
                    }
                }
            }


            if (validateLogin)
            {
                if (radioUser.Checked == true)
                {
                    UserManager user = new UserManager(currentUser);
                    Form game = new OopLab.Form1();
                    game.Show();
                    this.Hide();
                }

                if (radioAdmin.Checked == true)
                {
                    Form adminForm = new OopLab.AdminManageForm();
                    adminForm.Show();
                    this.Hide();
                }
                Properties.Settings.Default.userName = txtUsername.Text;
                Properties.Settings.Default.password = txtPassword.Text;
                Properties.Settings.Default.Save();
            }

            else MessageBox.Show("Wrong username or password");




        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtUsername.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                txtUsername.Text.Remove(txtUsername.Text.Length - 1);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                txtPassword.PasswordChar = (char)0;


            else
            {
                txtPassword.PasswordChar = '*';
            }
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();


        }
    }
}