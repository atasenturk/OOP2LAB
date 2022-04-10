using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OopLab
{
    public partial class Form1 : Form
    {
        Panel pnlMenu;


        public Form1()
        {
            InitializeComponent();
            pnlMenu = new Panel();
            pnlMenu.Location = new Point(180, 100);
            pnlMenu.BackColor = Color.FromArgb(47, 47, 47);
            pnlMenu.AutoSize = false;
            pnlMenu.Size = new Size(750, 450);
            pnlMenu.BorderStyle = BorderStyle.FixedSingle;

        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.Show();
            settings.BringToFront();
            settings.TopMost = true;
        }



    }
}
