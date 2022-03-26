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
        RadioButton easyButton = new RadioButton();
        RadioButton mediumButton = new RadioButton();
        RadioButton hardButton = new RadioButton();
        RadioButton customButton = new RadioButton();
        TextBox txtFirstVal = new TextBox();
        TextBox txtSecondVal = new TextBox();
        public int firstVal;
        public int secondVal;


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
            difficultyGroupBox.Location = new Point(50, 100);
            txtFirstVal.TextChanged += new EventHandler(firstVal_Text_Changed);
            txtSecondVal.TextChanged += new EventHandler(secondVal_Text_Changed);
        }

        private void secondVal_Text_Changed(object sender, EventArgs e)
        {
            saveSecondValSetting();
        }

        private void saveSecondValSetting()
        {
            Properties.Settings.Default.customSecVal = Convert.ToInt32(txtSecondVal.Text);
            Properties.Settings.Default.Save();

        }

        private void firstVal_Text_Changed(object sender, EventArgs e)
        {
            saveFirstValSetting();
        }

        private void saveFirstValSetting()
        {
            Properties.Settings.Default.customFirstVal = Convert.ToInt32(txtFirstVal.Text);
            Properties.Settings.Default.Save();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getDifficultySettings();
            getValueSettings();

        }

        private void getValueSettings()
        {
            txtFirstVal.Text = Properties.Settings.Default.customFirstVal.ToString();
            txtSecondVal.Text = Properties.Settings.Default.customSecVal.ToString();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnlMenu.BringToFront();
            Label label = new Label();
            label.AutoSize = true;
            label.Text = "DIFFICULTY LEVEL";
            label.Font = new Font("Bauhaus 93", 18);
            label.ForeColor = Color.White;
            label.Location = new Point(60, 50);


            easyButton.ForeColor = Color.White;
            easyButton.Font = new Font(easyButton.Font.FontFamily, 13);
            easyButton.Location = new Point(60, 20);
            easyButton.Name = "btnEasy";
            easyButton.Text = "Easy";
            easyButton.CheckedChanged += new EventHandler(difficulty_radio_CheckedChanged);

            mediumButton.ForeColor = Color.White;
            mediumButton.Font = new Font(easyButton.Font.FontFamily, 13);
            mediumButton.Name = "btnMedium";
            mediumButton.Text = "Medium";
            mediumButton.Location = new Point(60, 50);
            mediumButton.CheckedChanged += new EventHandler(difficulty_radio_CheckedChanged);


            hardButton.ForeColor = Color.White;
            hardButton.Font = new Font(easyButton.Font.FontFamily, 13);
            hardButton.Name = "btnHard";
            hardButton.Text = "Hard";
            hardButton.Location = new Point(60, 80);
            hardButton.CheckedChanged += new EventHandler(difficulty_radio_CheckedChanged);


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
                txtFirstVal.Size = new Size(40, 20);
                txtSecondVal.Size = new Size(40, 20);
                difficultyGroupBox.Controls.Add(txtFirstVal);
                txtFirstVal.Location = new Point(60, 140);
                difficultyGroupBox.Controls.Add(txtSecondVal);
                txtSecondVal.Location = new Point(120, 140);
            }
            else
            {
                for (int i = difficultyGroupBox.Controls.Count - 1; i >= 0; i--)
                {
                    if (difficultyGroupBox.Controls[i] is TextBox)
                    {
                        difficultyGroupBox.Controls.Remove(difficultyGroupBox.Controls[i]);
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
            Console.WriteLine(difficultyLevel);
            saveDifficultySettings();


        }

        public void getDifficultySettings()
        {
            difficultyLevel = Properties.Settings.Default.difficulty_level;
            if (difficultyLevel == 0) easyButton.Checked = true;
            if (difficultyLevel == 1) mediumButton.Checked = true;
            if (difficultyLevel == 2) hardButton.Checked = true;
            if (difficultyLevel == 3)
            {
                customButton.Checked = true;
                txtFirstVal.Size = new Size(40, 20);
                txtSecondVal.Size = new Size(40, 20);
                difficultyGroupBox.Controls.Add(txtFirstVal);
                txtFirstVal.Location = new Point(60, 140);
                difficultyGroupBox.Controls.Add(txtSecondVal);
                txtSecondVal.Location = new Point(120, 140);
            }
        }

        public void saveDifficultySettings()
        {
            Properties.Settings.Default.difficulty_level = difficultyLevel;
            Properties.Settings.Default.Save();
        }


    }
}
