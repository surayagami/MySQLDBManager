namespace MySQLDBManager
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
            this.button1 = new System.Windows.Forms.Button();
            this.lServer = new System.Windows.Forms.Label();
            this.lPort = new System.Windows.Forms.Label();
            this.lDatabase = new System.Windows.Forms.Label();
            this.lUser = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbDatabase = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.bConnect = new System.Windows.Forms.Button();
            this.lErrorConnect = new System.Windows.Forms.Label();
            this.lDataBaseName = new System.Windows.Forms.Label();
            this.lSelectTable = new System.Windows.Forms.Label();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(933, 502);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lServer
            // 
            this.lServer.AutoSize = true;
            this.lServer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lServer.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lServer.Location = new System.Drawing.Point(346, 97);
            this.lServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lServer.Name = "lServer";
            this.lServer.Size = new System.Drawing.Size(133, 19);
            this.lServer.TabIndex = 1;
            this.lServer.Text = "Server Name/IP:";
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPort.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lPort.Location = new System.Drawing.Point(370, 147);
            this.lPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(109, 19);
            this.lPort.TabIndex = 2;
            this.lPort.Text = "Port Number:";
            // 
            // lDatabase
            // 
            this.lDatabase.AutoSize = true;
            this.lDatabase.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDatabase.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lDatabase.Location = new System.Drawing.Point(338, 197);
            this.lDatabase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDatabase.Name = "lDatabase";
            this.lDatabase.Size = new System.Drawing.Size(141, 19);
            this.lDatabase.TabIndex = 3;
            this.lDatabase.Text = "Database Name:";
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lUser.Location = new System.Drawing.Point(416, 248);
            this.lUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(63, 19);
            this.lUser.TabIndex = 4;
            this.lUser.Text = "User ID:";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lPassword.Location = new System.Drawing.Point(395, 297);
            this.lPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(84, 19);
            this.lPassword.TabIndex = 5;
            this.lPassword.Text = "Password:";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(527, 94);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(246, 27);
            this.tbServer.TabIndex = 6;
            this.tbServer.Text = "localhost";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(527, 144);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(246, 27);
            this.tbPort.TabIndex = 7;
            this.tbPort.Text = "3306";
            // 
            // tbDatabase
            // 
            this.tbDatabase.Location = new System.Drawing.Point(527, 194);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.Size = new System.Drawing.Size(246, 27);
            this.tbDatabase.TabIndex = 8;
            this.tbDatabase.Text = "cssdb";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(527, 245);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(246, 27);
            this.tbUser.TabIndex = 9;
            this.tbUser.Text = "destine";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(527, 294);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(246, 27);
            this.tbPassword.TabIndex = 10;
            this.tbPassword.Text = "destine";
            // 
            // bConnect
            // 
            this.bConnect.ForeColor = System.Drawing.SystemColors.MenuText;
            this.bConnect.Location = new System.Drawing.Point(588, 359);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(124, 57);
            this.bConnect.TabIndex = 11;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // lErrorConnect
            // 
            this.lErrorConnect.AutoSize = true;
            this.lErrorConnect.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorConnect.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lErrorConnect.Location = new System.Drawing.Point(380, 454);
            this.lErrorConnect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lErrorConnect.Name = "lErrorConnect";
            this.lErrorConnect.Size = new System.Drawing.Size(568, 21);
            this.lErrorConnect.TabIndex = 12;
            this.lErrorConnect.Text = "Cannot connect to MySQL Server, please check your input and try again";
            this.lErrorConnect.Visible = false;
            // 
            // lDataBaseName
            // 
            this.lDataBaseName.AutoSize = true;
            this.lDataBaseName.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDataBaseName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lDataBaseName.Location = new System.Drawing.Point(24, 30);
            this.lDataBaseName.Name = "lDataBaseName";
            this.lDataBaseName.Size = new System.Drawing.Size(0, 26);
            this.lDataBaseName.TabIndex = 13;
            this.lDataBaseName.Visible = false;
            // 
            // lSelectTable
            // 
            this.lSelectTable.AutoSize = true;
            this.lSelectTable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSelectTable.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lSelectTable.Location = new System.Drawing.Point(25, 111);
            this.lSelectTable.Name = "lSelectTable";
            this.lSelectTable.Size = new System.Drawing.Size(102, 19);
            this.lSelectTable.TabIndex = 14;
            this.lSelectTable.Text = "Select Table";
            this.lSelectTable.Visible = false;
            // 
            // cbTable
            // 
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(29, 139);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(226, 27);
            this.cbTable.TabIndex = 15;
            this.cbTable.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 830);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.lSelectTable);
            this.Controls.Add(this.lDataBaseName);
            this.Controls.Add(this.lErrorConnect);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbDatabase);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.lDatabase);
            this.Controls.Add(this.lPort);
            this.Controls.Add(this.lServer);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MySQL Database Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lServer;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.Label lDatabase;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbDatabase;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Label lErrorConnect;
        private System.Windows.Forms.Label lDataBaseName;
        private System.Windows.Forms.Label lSelectTable;
        private System.Windows.Forms.ComboBox cbTable;
    }
}

