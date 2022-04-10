using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OopLab;

namespace OOPLAB_1PreLab
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        List<Admin> admins = new List<Admin>();

        public Form1()
        {
            InitializeComponent();
            users.Add(new User
            {
                userName = "user",
                password = "user"

            });

            admins.Add(new Admin
            {
                userName = "admin",
                password = "admin"
            });
            getSuccessfulLogin();

        }

        private void getSuccessfulLogin()
        {
            textBox1.Text = Properties.Settings.Default.userName;
            textBox2.Text = Properties.Settings.Default.password;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validateLogin = false;

            foreach (var us in users)
            {
                if (textBox1.Text == us.userName && textBox2.Text == us.password && radioButton1.Checked)
                {
                    validateLogin = true;
                    Form game = new OopLab.Form1();
                    game.Show();
                    this.Hide();
                }
            }

            foreach (var ad in admins)
            {
                if (textBox1.Text == ad.userName && textBox2.Text == ad.password && radioButton2.Checked)
                {
                    validateLogin = true;
                  
            }

            if (validateLogin)
            {

                Properties.Settings.Default.userName = textBox1.Text;
                Properties.Settings.Default.password = textBox2.Text;
                Properties.Settings.Default.Save();

               

            }

            else
            {
                MessageBox.Show("Wrong password or user!");
            }

         

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {


            textBox2.MaxLength = 6;


        }





        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                textBox2.PasswordChar = (char)0;


            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
          

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


        }
    }
}