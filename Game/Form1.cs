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
        public int shape;
        public int color;
        Panel pnlMenu;
        GroupBox difficultyGroupBox;
        GroupBox shapeGroupBox;
        GroupBox colorGroupBox;
        RadioButton easyButton = new RadioButton();
        RadioButton mediumButton = new RadioButton();
        RadioButton hardButton = new RadioButton();
        RadioButton customButton = new RadioButton();
        CheckBox squareButton = new CheckBox();
        CheckBox triangleButton = new CheckBox();
        CheckBox roundShapesButton = new CheckBox();
        CheckBox redColorButton = new CheckBox();
        CheckBox blueColorButton = new CheckBox();
        CheckBox yellowColorButton = new CheckBox();
        TextBox txtFirstVal = new TextBox();
        TextBox txtSecondVal = new TextBox();
        public int firstVal;
        public int secondVal;


        public Form1()
        {
            InitializeComponent();
            pnlMenu = new Panel();
            pnlMenu.Location = new Point(180, 100);
            pnlMenu.BackColor = Color.FromArgb(47, 47, 47);
            pnlMenu.AutoSize = false;
            pnlMenu.Size = new Size(750, 450);
            pnlMenu.BorderStyle = BorderStyle.FixedSingle;

            difficultyGroupBox = new GroupBox();
            difficultyGroupBox.AutoSize = true;
            difficultyGroupBox.Text = "";
            difficultyGroupBox.Location = new Point(50, 100);

            colorGroupBox = new GroupBox();
            colorGroupBox.AutoSize = true;
            colorGroupBox.Text = "";
            colorGroupBox.Location = new Point(50, 300);

            shapeGroupBox = new GroupBox();
            shapeGroupBox.AutoSize = true;
            shapeGroupBox.Text = "";
            shapeGroupBox.Location = new Point(330, 100);

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
            getShapeSettings();
            getValueSettings();
            getColorSettings();
        }

        private void getColorSettings()
        {
            color = Properties.Settings.Default.color;
            if (color == 0)
            {
                redColorButton.Checked = true;
                pnlMain.BackColor = Color.Red;
            }
            if (color == 1)
            {
                blueColorButton.Checked = true;
                pnlMain.BackColor = Color.Blue;
            }
            if (color == 2)
            {
                yellowColorButton.Checked = true;
                pnlMain.BackColor = Color.Yellow;
            }
        }

        private void getShapeSettings()
        {
            shape = Properties.Settings.Default.shape;
            if (shape == 0) squareButton.Checked = true;
            if (shape == 1) triangleButton.Checked = true;
            if (shape == 2) roundShapesButton.Checked = true;
        }

        private void getValueSettings()
        {
            txtFirstVal.Text = Properties.Settings.Default.customFirstVal.ToString();
            txtSecondVal.Text = Properties.Settings.Default.customSecVal.ToString();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnlMenu.BringToFront();
            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Text = "SETTINGS";
            label1.Font = new Font("Bauhaus 93", 18);
            label1.ForeColor = Color.White;
            label1.Location = new Point(240, 20);

            Button btnCloseMenu = new Button();
            btnCloseMenu.Location = new Point(550, 20);
            btnCloseMenu.AutoSize = true;
            btnCloseMenu.Text = "Close";
            btnCloseMenu.ForeColor = Color.White;
            btnCloseMenu.Click += new EventHandler(btnCloseMenu_Click);

            Label label = new Label();
            label.AutoSize = true;
            label.Text = "DIFFICULTY LEVEL";
            label.Font = new Font(label.Font.FontFamily, 13);
            label.ForeColor = Color.White;
            label.Location = new Point(50, 70);

            Label label2 = new Label();
            label2.AutoSize = true;
            label2.Text = "CHOOSE SHAPE";
            label2.Font = new Font(label.Font.FontFamily, 13);
            label2.ForeColor = Color.White;
            label2.Location = new Point(330, 70);


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


            squareButton.ForeColor = Color.White;
            squareButton.Font = new Font(squareButton.Font.FontFamily, 13);
            squareButton.Location = new Point(60, 20);
            squareButton.Name = "btnSquare";
            squareButton.Text = "Square";
            squareButton.CheckedChanged += new EventHandler(shape_radio_CheckedChanged);


            triangleButton.ForeColor = Color.White;
            triangleButton.Font = new Font(easyButton.Font.FontFamily, 13);
            triangleButton.Location = new Point(60, 50);
            triangleButton.Name = "btnTriangle";
            triangleButton.Text = "Triangle";
            triangleButton.CheckedChanged += new EventHandler(shape_radio_CheckedChanged);


            roundShapesButton.ForeColor = Color.White;
            roundShapesButton.Font = new Font(easyButton.Font.FontFamily, 13);
            roundShapesButton.Location = new Point(60, 80);
            roundShapesButton.Name = "btnRound";
            roundShapesButton.Text = "Round";
            roundShapesButton.CheckedChanged += new EventHandler(shape_radio_CheckedChanged);


            redColorButton.ForeColor = Color.White;
            redColorButton.Font = new Font(easyButton.Font.FontFamily, 13);
            redColorButton.Name = "btnRedColor";
            redColorButton.Text = "Red Color";
            redColorButton.Location = new Point(60, 20);
            redColorButton.CheckedChanged += new EventHandler(color_radio_CheckedChanged);

            blueColorButton.ForeColor = Color.White;
            blueColorButton.Font = new Font(easyButton.Font.FontFamily, 13);
            blueColorButton.Name = "btnBlueColor";
            blueColorButton.Text = "Blue Color";
            blueColorButton.Location = new Point(60, 50);
            blueColorButton.CheckedChanged += new EventHandler(color_radio_CheckedChanged);

            yellowColorButton.ForeColor = Color.White;
            yellowColorButton.Font = new Font(easyButton.Font.FontFamily, 13);
            yellowColorButton.Name = "btnYellowColor";
            yellowColorButton.Text = "Yellow Color";
            yellowColorButton.Location = new Point(60, 80);
            yellowColorButton.CheckedChanged += new EventHandler(color_radio_CheckedChanged);

            difficultyGroupBox.Controls.AddRange(new Control[] { easyButton, mediumButton, hardButton, customButton });
            shapeGroupBox.Controls.AddRange(new Control[] { squareButton, triangleButton, roundShapesButton});
            colorGroupBox.Controls.AddRange(new Control[] { redColorButton , blueColorButton , yellowColorButton });
            pnlMenu.Controls.Add(difficultyGroupBox);
            pnlMenu.Controls.Add(shapeGroupBox);
            pnlMenu.Controls.Add(colorGroupBox);
            pnlMenu.Controls.Add(label);
            pnlMenu.Controls.Add(btnCloseMenu);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Controls.Add(label2);
            pnlMain.Controls.Add(pnlMenu);
        }

        private void color_radio_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox RD = sender as CheckBox;
            if (RD.Name == "btnRedColor")
            {
                color = 0;
                pnlMain.BackColor = Color.Red;
            }
            if (RD.Name == "btnBlueColor")
            {
                color = 1;
                pnlMain.BackColor = Color.Blue;
            }
            if (RD.Name == "btnYellowColor")
            {
                color = 2;
                pnlMain.BackColor = Color.Yellow;
            }
            saveColorSettings();
        }

        private void saveColorSettings()
        {
            Properties.Settings.Default.color = color;
            Properties.Settings.Default.Save();
        }

        private void btnCloseMenu_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Remove(pnlMenu);
            pnlMain.BackColor = Color.FromArgb(47, 47, 47);
        }

        private void shape_radio_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox RD = sender as CheckBox;
            if (RD.Name == "btnSquare")
            {
                shape = 0;
            }
            if (RD.Name == "btnTriangle")
            {
                shape = 1;
            }
            if (RD.Name == "btnRound")
            {
                shape = 2;
            }
            saveShapeSettings();

        }

        private void saveShapeSettings()
        {
            Properties.Settings.Default.shape = shape;
            Properties.Settings.Default.Save();
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

                difficultyGroupBox.Controls.Add(label1);
                difficultyGroupBox.Controls.Add(txtFirstVal);
                txtFirstVal.Location = new Point(150, 140);
                difficultyGroupBox.Controls.Add(label2);
                difficultyGroupBox.Controls.Add(txtSecondVal);
                txtSecondVal.Location = new Point(150, 170);
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
