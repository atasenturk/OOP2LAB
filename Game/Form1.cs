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
        string difficulty;
        Panel pnlMenu;
        public Form1()
        {
            InitializeComponent();
            pnlMenu = new Panel();
            pnlMenu.Location = new Point(233, 123);
            pnlMenu.BackColor = Color.FromArgb(47, 47, 47);
            pnlMenu.AutoSize = false;
            pnlMenu.Size = new Size(634, 364);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnlMenu.BringToFront();
            Label label = new Label();
            label.AutoSize = true;
            label.Text = "CHOOSE DIFFICULTY LEVEL";
            label.ForeColor = Color.White;
            label.Location = new Point(200, 50);
            pnlMenu.Controls.Add(label);
            pnlMain.Controls.Add(pnlMenu);
        }
    }
}
