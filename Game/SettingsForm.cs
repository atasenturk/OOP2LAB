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

    public partial class SettingsForm : Form
    {
        public int firstVal;
        public int secondVal;
        public int difficultyLevel;
        TextBox txtFirstVal = new TextBox();
        TextBox txtSecondVal = new TextBox();



        public SettingsForm()
        {
            InitializeComponent();
            btnEasy.CheckedChanged += new EventHandler(difficulty_radio_CheckedChanged);
            btnMedium.CheckedChanged += new EventHandler(difficulty_radio_CheckedChanged);
            btnHard.CheckedChanged += new EventHandler(difficulty_radio_CheckedChanged);
            btnCustom.CheckedChanged += new EventHandler(difficulty_radio_CheckedChanged);
            getSettings();

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
                Label label1 = new Label();
                label1.AutoSize = true;
                label1.Text = "First Value";
                label1.ForeColor = Color.White;
                label1.Location = new Point(30, 140);

                Label label2 = new Label();
                label2.AutoSize = true;
                label2.Text = "Second Value";
                label2.ForeColor = Color.White;
                label2.Location = new Point(30, 170);

                txtFirstVal.Location = new Point(150, 140);
                txtSecondVal.Location = new Point(150, 170);
                difficultyGroupBox.Controls.Add(label1);
                difficultyGroupBox.Controls.Add(txtFirstVal);
                difficultyGroupBox.Controls.Add(label2);
                difficultyGroupBox.Controls.Add(txtSecondVal);
            }
            else
            {
                for (int i = difficultyGroupBox.Controls.Count - 1; i >= 0; i--)
                {
                    if (difficultyGroupBox.Controls[i] is TextBox || difficultyGroupBox.Controls[i] is Label)
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
        }






        //Setters
        private void saveSettings_Click(object sender, EventArgs e)
        {
            saveDifficultySettings();
            saveShapeSettings();
            saveColorSettings();
            saveCustomValSettings();
        }

        private void saveCustomValSettings()
        {
            Properties.Settings.Default.customSecVal = Convert.ToInt32(txtSecondVal.Text);
            Properties.Settings.Default.customFirstVal = Convert.ToInt32(txtFirstVal.Text);
            Properties.Settings.Default.Save();
        }
        private void saveShapeSettings()
        {
            if (chkSquare.Checked == true)
            {
                Properties.Settings.Default.square = true;
            }
            else Properties.Settings.Default.square = false;
            if (chkTriangle.Checked == true)
            {
                Properties.Settings.Default.triangle = true;
            }
            else Properties.Settings.Default.triangle = false;
            if (chkRounded.Checked == true)
            {
                Properties.Settings.Default.rounded = true;
            }
            else Properties.Settings.Default.rounded = false;
            Properties.Settings.Default.Save();
        }

        public void saveDifficultySettings()
        {
            Properties.Settings.Default.difficulty_level = difficultyLevel;
            Properties.Settings.Default.Save();
        }

        private void saveColorSettings()
        {
            if (chkRed.Checked == true)
            {
                Properties.Settings.Default.red = true;
            }
            else Properties.Settings.Default.red = false;
            if (chkBlue.Checked == true)
            {
                Properties.Settings.Default.blue = true;
            }
            else Properties.Settings.Default.blue = false;
            if (chkYellow.Checked == true)
            {
                Properties.Settings.Default.yellow = true;
            }
            else Properties.Settings.Default.yellow = false;
            Properties.Settings.Default.Save();
        }



        //Getters
        private void getSettings()
        {
            getDifficultySettings();
            getColorSettings();
            getValueSettings();
            getShapeSettings();
            getValSettings();
        }

        private void getValSettings()
        {
            txtSecondVal.Text = Properties.Settings.Default.customSecVal.ToString();
            txtFirstVal.Text = Properties.Settings.Default.customFirstVal.ToString();
        }

        public void getDifficultySettings()
        {
            difficultyLevel = Properties.Settings.Default.difficulty_level;
            if (difficultyLevel == 0) btnEasy.Checked = true;
            if (difficultyLevel == 1) btnMedium.Checked = true;
            if (difficultyLevel == 2) btnHard.Checked = true;
            if (difficultyLevel == 3)
            {
                btnCustom.Checked = true;
                txtFirstVal.Size = new Size(40, 20);
                txtSecondVal.Size = new Size(40, 20);
                difficultyGroupBox.Controls.Add(txtFirstVal);
                txtFirstVal.Location = new Point(60, 140);
                difficultyGroupBox.Controls.Add(txtSecondVal);
                txtSecondVal.Location = new Point(120, 140);
            }
        }
        private void getShapeSettings()
        {
            if (Properties.Settings.Default.triangle == true) chkTriangle.Checked = true;
            else chkTriangle.Checked = false;
            if (Properties.Settings.Default.square == true) chkSquare.Checked = true;
            else chkSquare.Checked = false;
            if (Properties.Settings.Default.rounded == true) chkRounded.Checked = true;
            else chkRounded.Checked = false;
        }

        private void getColorSettings()
        {
            if (Properties.Settings.Default.red == true) chkRed.Checked = true;
            else chkRed.Checked = false;
            if (Properties.Settings.Default.blue == true) chkBlue.Checked = true;
            else chkBlue.Checked = false;
            if (Properties.Settings.Default.yellow == true) chkYellow.Checked = true;
            else chkYellow.Checked = false;
        }


        private void getValueSettings()
        {
            txtFirstVal.Text = Properties.Settings.Default.customFirstVal.ToString();
            txtSecondVal.Text = Properties.Settings.Default.customSecVal.ToString();
        }
    }
}
