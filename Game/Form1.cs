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
        public int difficultyLevel;
        Panel pnlMenu;
        GroupBox difficultyGroupBox;

        public Form1()
        {
            InitializeComponent();
            pnlMenu = new Panel();
            pnlMenu.Location = new Point(233, 123);
            pnlMenu.BackColor = Color.FromArgb(47, 47, 47);
            pnlMenu.AutoSize = false;
            pnlMenu.Size = new Size(634, 364);

            difficultyGroupBox = new GroupBox();
            difficultyGroupBox.AutoSize = true;
            difficultyGroupBox.Text = "";
            difficultyGroupBox.Location = new Point(100, 100);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnlMenu.BringToFront();
            Label label = new Label();
            label.AutoSize = true;
            label.Text = "DIFFICULTY LEVEL";
            label.Font = new Font("Viner Hand ITC", 20);
            label.ForeColor = Color.White;
            label.Location = new Point(130, 50);



            RadioButton easyButton = new RadioButton();
            easyButton.ForeColor = Color.White;
            easyButton.Font = new Font(easyButton.Font.FontFamily, 13);
            easyButton.Location = new Point(60, 20);
            easyButton.Name = "btnEasy";
            easyButton.Text = "Easy";
            easyButton.Checked = true;
            easyButton.CheckedChanged += new EventHandler(difficulty_radio_CheckedChanged);

            RadioButton mediumButton = new RadioButton();
            mediumButton.ForeColor = Color.White;
            mediumButton.Font = new Font(easyButton.Font.FontFamily, 13);
            mediumButton.Name = "btnMedium";
            mediumButton.Text = "Medium";
            mediumButton.Location = new Point(60, 50);
            mediumButton.CheckedChanged += new EventHandler(difficulty_radio_CheckedChanged);


            RadioButton hardButton = new RadioButton();
            hardButton.ForeColor = Color.White;
            hardButton.Font = new Font(easyButton.Font.FontFamily, 13);
            hardButton.Name = "btnHard";
            hardButton.Text = "Hard";
            hardButton.Location = new Point(60, 80);
            hardButton.CheckedChanged += new EventHandler(difficulty_radio_CheckedChanged);



            RadioButton customButton = new RadioButton();
            customButton.ForeColor = Color.White;
            customButton.Font = new Font(easyButton.Font.FontFamily, 13);
            customButton.Name = "btnCustom";
            customButton.Text = "Custom";
            customButton.Location = new Point(60, 110);
            customButton.CheckedChanged += new EventHandler(difficulty_radio_CheckedChanged);



            difficultyGroupBox.Controls.AddRange(new Control[] { easyButton, mediumButton, hardButton, customButton });
            pnlMenu.Controls.Add(difficultyGroupBox);
            pnlMenu.Controls.Add(label);
            pnlMain.Controls.Add(pnlMenu);
        }

        private void difficulty_radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton RD = sender as RadioButton;
            if (RD.Checked == false) return;
            if (RD.Name == "btnCustom")
            {
                difficultyLevel = 3;
                TextBox firstVal = new TextBox();
                firstVal.Size = new Size(40, 20);
                TextBox secondVal = new TextBox();
                secondVal.Size = new Size(40, 20);
                difficultyGroupBox.Controls.Add(firstVal);
                firstVal.Location = new Point(60, 140);
                difficultyGroupBox.Controls.Add(secondVal);
                secondVal.Location = new Point(120, 140);

            }
            else
            {
                foreach (Control c in difficultyGroupBox.Controls)
                {
                    if (c is TextBox)
                    {
                        difficultyGroupBox.Controls.Remove(c);
                    }
                }
                if (RD.Name == "btnEasy")
                {
                    difficultyLevel = 0;
                }
                if (RD.Name == "btnMedium")
                {
                    difficultyLevel = 1;
                }
                if (RD.Name == "btnHard")
                {
                    difficultyLevel = 2;
                }
            }


        }
    }
}
