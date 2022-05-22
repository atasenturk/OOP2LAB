
namespace OopLab
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.btnCloseProfile = new System.Windows.Forms.Button();
            this.btnUpdateMe = new System.Windows.Forms.Button();
            this.txtEmailFound = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCountyFound = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCityFound = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddressFound = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPhoneFound = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNameFound = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPasswordFound = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();

            this.pnlTop.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.pnlTop.Controls.Add(this.btnAbout);
            this.pnlTop.Controls.Add(this.lblWelcome);
            this.pnlTop.Controls.Add(this.btnProfile);
            this.pnlTop.Controls.Add(this.btnMenu);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1136, 62);
            this.pnlTop.TabIndex = 0;
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbout.Location = new System.Drawing.Point(112, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(85, 35);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWelcome.Location = new System.Drawing.Point(747, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(89, 18);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome:";
            // 
            // btnProfile
            // 
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProfile.Location = new System.Drawing.Point(1004, 12);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(108, 35);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(85, 35);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.button1);
            this.pnlMain.Controls.Add(this.pnlBoard);
            this.pnlMain.Controls.Add(this.pnlProfile);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 62);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1136, 599);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlBoard
            // 
            this.pnlBoard.AutoScroll = true;
            this.pnlBoard.Location = new System.Drawing.Point(242, 6);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(581, 581);
            this.pnlBoard.TabIndex = 1;
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.pnlProfile.Controls.Add(this.btnCloseProfile);
            this.pnlProfile.Controls.Add(this.btnUpdateMe);
            this.pnlProfile.Controls.Add(this.txtEmailFound);
            this.pnlProfile.Controls.Add(this.label9);
            this.pnlProfile.Controls.Add(this.txtCountyFound);
            this.pnlProfile.Controls.Add(this.label10);
            this.pnlProfile.Controls.Add(this.txtCityFound);
            this.pnlProfile.Controls.Add(this.label11);
            this.pnlProfile.Controls.Add(this.txtAddressFound);
            this.pnlProfile.Controls.Add(this.label12);
            this.pnlProfile.Controls.Add(this.txtPhoneFound);
            this.pnlProfile.Controls.Add(this.label13);
            this.pnlProfile.Controls.Add(this.txtNameFound);
            this.pnlProfile.Controls.Add(this.label14);
            this.pnlProfile.Controls.Add(this.txtPasswordFound);
            this.pnlProfile.Controls.Add(this.label15);
            this.pnlProfile.Location = new System.Drawing.Point(730, 63);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(852, 492);
            this.pnlProfile.TabIndex = 0;
            this.pnlProfile.Visible = false;
            // 
            // btnCloseProfile
            // 
            this.btnCloseProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCloseProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCloseProfile.Location = new System.Drawing.Point(685, 18);
            this.btnCloseProfile.Name = "btnCloseProfile";
            this.btnCloseProfile.Size = new System.Drawing.Size(125, 33);
            this.btnCloseProfile.TabIndex = 47;
            this.btnCloseProfile.Text = "Close Profile";
            this.btnCloseProfile.UseVisualStyleBackColor = true;
            this.btnCloseProfile.Click += new System.EventHandler(this.btnCloseProfile_Click);
            // 
            // btnUpdateMe
            // 
            this.btnUpdateMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateMe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateMe.Location = new System.Drawing.Point(547, 360);
            this.btnUpdateMe.Name = "btnUpdateMe";
            this.btnUpdateMe.Size = new System.Drawing.Size(140, 50);
            this.btnUpdateMe.TabIndex = 32;
            this.btnUpdateMe.Text = "Update My Informations";
            this.btnUpdateMe.UseVisualStyleBackColor = true;
            this.btnUpdateMe.Click += new System.EventHandler(this.btnUpdateMe_Click);
            // 
            // txtEmailFound
            // 
            this.txtEmailFound.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailFound.Location = new System.Drawing.Point(334, 385);
            this.txtEmailFound.Name = "txtEmailFound";
            this.txtEmailFound.Size = new System.Drawing.Size(194, 25);
            this.txtEmailFound.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(263, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "Email";
            // 
            // txtCountyFound
            // 
            this.txtCountyFound.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountyFound.Location = new System.Drawing.Point(334, 332);
            this.txtCountyFound.Name = "txtCountyFound";
            this.txtCountyFound.Size = new System.Drawing.Size(194, 25);
            this.txtCountyFound.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(245, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Country";
            // 
            // txtCityFound
            // 
            this.txtCityFound.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCityFound.Location = new System.Drawing.Point(334, 278);
            this.txtCityFound.Name = "txtCityFound";
            this.txtCityFound.Size = new System.Drawing.Size(194, 25);
            this.txtCityFound.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(275, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 41;
            this.label11.Text = "City";
            // 
            // txtAddressFound
            // 
            this.txtAddressFound.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressFound.Location = new System.Drawing.Point(334, 225);
            this.txtAddressFound.Name = "txtAddressFound";
            this.txtAddressFound.Size = new System.Drawing.Size(194, 25);
            this.txtAddressFound.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(242, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 39;
            this.label12.Text = "Address";
            // 
            // txtPhoneFound
            // 
            this.txtPhoneFound.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneFound.Location = new System.Drawing.Point(334, 175);
            this.txtPhoneFound.Name = "txtPhoneFound";
            this.txtPhoneFound.Size = new System.Drawing.Size(194, 25);
            this.txtPhoneFound.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(195, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "Phone Number";
            // 
            // txtNameFound
            // 
            this.txtNameFound.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameFound.Location = new System.Drawing.Point(334, 124);
            this.txtNameFound.Name = "txtNameFound";
            this.txtNameFound.Size = new System.Drawing.Size(194, 25);
            this.txtNameFound.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(186, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 17);
            this.label14.TabIndex = 35;
            this.label14.Text = "Name, Surname";
            // 
            // txtPasswordFound
            // 
            this.txtPasswordFound.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordFound.Location = new System.Drawing.Point(334, 77);
            this.txtPasswordFound.Name = "txtPasswordFound";
            this.txtPasswordFound.Size = new System.Drawing.Size(194, 25);
            this.txtPasswordFound.TabIndex = 34;
            this.txtPasswordFound.UseSystemPasswordChar = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(231, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "Password";

            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1136, 661);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Board Game";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Button btnUpdateMe;
        private System.Windows.Forms.TextBox txtEmailFound;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCountyFound;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCityFound;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAddressFound;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPhoneFound;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNameFound;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPasswordFound;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCloseProfile;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnAbout;

    }
}

