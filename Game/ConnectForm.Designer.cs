
namespace OopLab
{
    partial class ConnectForm
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
            this.btnSend = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPortNum = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnServer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMultiplayer = new System.Windows.Forms.Button();
            this.btnSingleplayer = new System.Windows.Forms.Button();
            this.lblNewGame = new System.Windows.Forms.Label();
            this.pnlMulti = new System.Windows.Forms.Panel();
            this.pnlMulti.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSend.Location = new System.Drawing.Point(462, 301);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(85, 35);
            this.btnSend.TabIndex = 33;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMessage.Location = new System.Drawing.Point(366, 316);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 13);
            this.lblMessage.TabIndex = 32;
            this.lblMessage.Text = "label6";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(499, 42);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 35);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConnect.Location = new System.Drawing.Point(448, 144);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(85, 35);
            this.btnConnect.TabIndex = 30;
            this.btnConnect.Text = "Connect !";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPortNum
            // 
            this.txtPortNum.Location = new System.Drawing.Point(240, 204);
            this.txtPortNum.Name = "txtPortNum";
            this.txtPortNum.Size = new System.Drawing.Size(172, 20);
            this.txtPortNum.TabIndex = 29;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(240, 153);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(172, 20);
            this.txtIPAddress.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(168, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Port: ";
            // 
            // btnServer
            // 
            this.btnServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnServer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnServer.Location = new System.Drawing.Point(137, 259);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(85, 35);
            this.btnServer.TabIndex = 26;
            this.btnServer.Text = "Server";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(114, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "IP address: ";
            // 
            // btnMultiplayer
            // 
            this.btnMultiplayer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMultiplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplayer.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMultiplayer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMultiplayer.Location = new System.Drawing.Point(465, 190);
            this.btnMultiplayer.Name = "btnMultiplayer";
            this.btnMultiplayer.Size = new System.Drawing.Size(199, 88);
            this.btnMultiplayer.TabIndex = 36;
            this.btnMultiplayer.Text = "Multi Player";
            this.btnMultiplayer.UseVisualStyleBackColor = true;
            this.btnMultiplayer.Click += new System.EventHandler(this.btnMultiplayer_Click);
            // 
            // btnSingleplayer
            // 
            this.btnSingleplayer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSingleplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingleplayer.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSingleplayer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSingleplayer.Location = new System.Drawing.Point(232, 190);
            this.btnSingleplayer.Name = "btnSingleplayer";
            this.btnSingleplayer.Size = new System.Drawing.Size(199, 88);
            this.btnSingleplayer.TabIndex = 35;
            this.btnSingleplayer.Text = "Single Player";
            this.btnSingleplayer.UseVisualStyleBackColor = true;
            this.btnSingleplayer.Click += new System.EventHandler(this.btnSingleplayer_Click);
            // 
            // lblNewGame
            // 
            this.lblNewGame.AutoSize = true;
            this.lblNewGame.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNewGame.Location = new System.Drawing.Point(400, 135);
            this.lblNewGame.Name = "lblNewGame";
            this.lblNewGame.Size = new System.Drawing.Size(118, 23);
            this.lblNewGame.TabIndex = 34;
            this.lblNewGame.Text = "NEW GAME";
            // 
            // pnlMulti
            // 
            this.pnlMulti.Controls.Add(this.btnConnect);
            this.pnlMulti.Controls.Add(this.label5);
            this.pnlMulti.Controls.Add(this.btnServer);
            this.pnlMulti.Controls.Add(this.label3);
            this.pnlMulti.Controls.Add(this.btnSend);
            this.pnlMulti.Controls.Add(this.txtIPAddress);
            this.pnlMulti.Controls.Add(this.lblMessage);
            this.pnlMulti.Controls.Add(this.txtPortNum);
            this.pnlMulti.Controls.Add(this.btnClose);
            this.pnlMulti.Location = new System.Drawing.Point(129, 99);
            this.pnlMulti.Name = "pnlMulti";
            this.pnlMulti.Size = new System.Drawing.Size(658, 410);
            this.pnlMulti.TabIndex = 37;
            this.pnlMulti.Visible = false;
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(974, 656);
            this.Controls.Add(this.pnlMulti);
            this.Controls.Add(this.btnMultiplayer);
            this.Controls.Add(this.btnSingleplayer);
            this.Controls.Add(this.lblNewGame);
            this.Name = "ConnectForm";
            this.Text = "Entrance";
            this.pnlMulti.ResumeLayout(false);
            this.pnlMulti.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblMessage;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnConnect;
        public System.Windows.Forms.TextBox txtPortNum;
        public System.Windows.Forms.TextBox txtIPAddress;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnServer;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnMultiplayer;
        public System.Windows.Forms.Button btnSingleplayer;
        public System.Windows.Forms.Label lblNewGame;
        private System.Windows.Forms.Panel pnlMulti;
    }
}