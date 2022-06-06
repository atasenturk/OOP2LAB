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
    public partial class ConnectForm : Form
    {
        public ConnectForm()
        {
            InitializeComponent();
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1(false, false, Convert.ToInt32(txtPortNum.Text), txtIPAddress.Text);
            Visible = false;
            if (!game.IsDisposed)
            {
                game.ShowDialog();
            }
            Visible = true;

        }
        private void btnServer_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1(false, true);
            Visible = false;
            if (!game.IsDisposed)
            {
                game.ShowDialog();
            }
            Visible = true;
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            pnlMulti.Visible = true;
        }

        private void btnSingleplayer_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1(true, false);
            Visible = false;
            if (!game.IsDisposed)
            {
                game.ShowDialog();
            }
            Visible = true;
        }
    }
}
