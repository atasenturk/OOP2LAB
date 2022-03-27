using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            foreach(var us in users)
            {
                if (textBox1.Text == us.userName && textBox2.Text == us.password)
                {
                    validateLogin = true;
                }
            }

            foreach (var ad in admins)
            {
                if (textBox1.Text == ad.userName && textBox2.Text == ad.password)
                {
                    validateLogin = true;
                }
            }

            if (validateLogin) 
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong password or user!");
            }
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 6;

        }

    }
}
