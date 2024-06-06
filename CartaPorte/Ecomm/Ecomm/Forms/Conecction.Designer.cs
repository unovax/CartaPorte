namespace Ecomm.Forms
{
    partial class Conecction
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
            this.RemotePanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BtnClose = new Ecomm.Components.DangerButton();
            this.BtnAccept = new Ecomm.Components.PrimaryButton();
            this.inputLabel1 = new Ecomm.Components.InputLabel();
            this.RbtnLocal = new Ecomm.Components.RButton();
            this.LblDataSource = new Ecomm.Components.InputLabel();
            this.InputPort = new Ecomm.Components.Input();
            this.InputPassword = new Ecomm.Components.Input();
            this.InputDatasource = new Ecomm.Components.Input();
            this.InputUsername = new Ecomm.Components.Input();
            this.InputDatabase = new Ecomm.Components.Input();
            this.LblUsername = new Ecomm.Components.InputLabel();
            this.LblPort = new Ecomm.Components.InputLabel();
            this.LblDatabase = new Ecomm.Components.InputLabel();
            this.LblPassword = new Ecomm.Components.InputLabel();
            this.RBtnRemote = new Ecomm.Components.RButton();
            this.RemotePanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemotePanel
            // 
            this.RemotePanel.Controls.Add(this.LblDataSource);
            this.RemotePanel.Controls.Add(this.InputPort);
            this.RemotePanel.Controls.Add(this.InputPassword);
            this.RemotePanel.Controls.Add(this.InputDatasource);
            this.RemotePanel.Controls.Add(this.InputUsername);
            this.RemotePanel.Controls.Add(this.InputDatabase);
            this.RemotePanel.Controls.Add(this.LblUsername);
            this.RemotePanel.Controls.Add(this.LblPort);
            this.RemotePanel.Controls.Add(this.LblDatabase);
            this.RemotePanel.Controls.Add(this.LblPassword);
            this.RemotePanel.Location = new System.Drawing.Point(10, 65);
            this.RemotePanel.Name = "RemotePanel";
            this.RemotePanel.Size = new System.Drawing.Size(380, 238);
            this.RemotePanel.TabIndex = 4;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BtnClose);
            this.MainPanel.Controls.Add(this.BtnAccept);
            this.MainPanel.Controls.Add(this.inputLabel1);
            this.MainPanel.Controls.Add(this.RbtnLocal);
            this.MainPanel.Controls.Add(this.RemotePanel);
            this.MainPanel.Controls.Add(this.RBtnRemote);
            this.MainPanel.Location = new System.Drawing.Point(3, 3);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(400, 400);
            this.MainPanel.TabIndex = 5;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnClose.Location = new System.Drawing.Point(207, 333);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnClose.Size = new System.Drawing.Size(100, 39);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Cerrar";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAccept
            // 
            this.BtnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.BtnAccept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.BtnAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.BtnAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.BtnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAccept.ForeColor = System.Drawing.Color.White;
            this.BtnAccept.Location = new System.Drawing.Point(101, 333);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnAccept.Size = new System.Drawing.Size(100, 39);
            this.BtnAccept.TabIndex = 5;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = false;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // inputLabel1
            // 
            this.inputLabel1.AutoSize = true;
            this.inputLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.inputLabel1.Location = new System.Drawing.Point(10, 10);
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Size = new System.Drawing.Size(152, 13);
            this.inputLabel1.TabIndex = 1;
            this.inputLabel1.Text = "Selecciona el tipo de conexión";
            // 
            // RbtnLocal
            // 
            this.RbtnLocal.AutoSize = true;
            this.RbtnLocal.Checked = true;
            this.RbtnLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.RbtnLocal.Location = new System.Drawing.Point(13, 31);
            this.RbtnLocal.Name = "RbtnLocal";
            this.RbtnLocal.Size = new System.Drawing.Size(51, 17);
            this.RbtnLocal.TabIndex = 2;
            this.RbtnLocal.TabStop = true;
            this.RbtnLocal.Text = "Local";
            this.RbtnLocal.UseVisualStyleBackColor = true;
            this.RbtnLocal.CheckedChanged += new System.EventHandler(this.RbtnLocal_CheckedChanged);
            // 
            // LblDataSource
            // 
            this.LblDataSource.AutoSize = true;
            this.LblDataSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.LblDataSource.Location = new System.Drawing.Point(12, 11);
            this.LblDataSource.Name = "LblDataSource";
            this.LblDataSource.Size = new System.Drawing.Size(64, 13);
            this.LblDataSource.TabIndex = 1;
            this.LblDataSource.Text = "Direccion Ip";
            // 
            // InputPort
            // 
            this.InputPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.InputPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPort.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.InputPort.Location = new System.Drawing.Point(258, 81);
            this.InputPort.Name = "InputPort";
            this.InputPort.Size = new System.Drawing.Size(112, 26);
            this.InputPort.TabIndex = 0;
            this.InputPort.Text = "3050";
            // 
            // InputPassword
            // 
            this.InputPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.InputPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.InputPassword.Location = new System.Drawing.Point(10, 195);
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.PasswordChar = '*';
            this.InputPassword.Size = new System.Drawing.Size(360, 26);
            this.InputPassword.TabIndex = 0;
            // 
            // InputDatasource
            // 
            this.InputDatasource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.InputDatasource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputDatasource.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDatasource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.InputDatasource.Location = new System.Drawing.Point(10, 27);
            this.InputDatasource.Name = "InputDatasource";
            this.InputDatasource.Size = new System.Drawing.Size(360, 26);
            this.InputDatasource.TabIndex = 0;
            this.InputDatasource.Text = "Localhost";
            // 
            // InputUsername
            // 
            this.InputUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.InputUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.InputUsername.Location = new System.Drawing.Point(10, 138);
            this.InputUsername.Name = "InputUsername";
            this.InputUsername.Size = new System.Drawing.Size(360, 26);
            this.InputUsername.TabIndex = 0;
            // 
            // InputDatabase
            // 
            this.InputDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.InputDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputDatabase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.InputDatabase.Location = new System.Drawing.Point(10, 81);
            this.InputDatabase.Name = "InputDatabase";
            this.InputDatabase.Size = new System.Drawing.Size(242, 26);
            this.InputDatabase.TabIndex = 0;
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.LblUsername.Location = new System.Drawing.Point(12, 122);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(43, 13);
            this.LblUsername.TabIndex = 1;
            this.LblUsername.Text = "Usuario";
            // 
            // LblPort
            // 
            this.LblPort.AutoSize = true;
            this.LblPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.LblPort.Location = new System.Drawing.Point(255, 65);
            this.LblPort.Name = "LblPort";
            this.LblPort.Size = new System.Drawing.Size(38, 13);
            this.LblPort.TabIndex = 1;
            this.LblPort.Text = "Puerto";
            // 
            // LblDatabase
            // 
            this.LblDatabase.AutoSize = true;
            this.LblDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.LblDatabase.Location = new System.Drawing.Point(12, 65);
            this.LblDatabase.Name = "LblDatabase";
            this.LblDatabase.Size = new System.Drawing.Size(75, 13);
            this.LblDatabase.TabIndex = 1;
            this.LblDatabase.Text = "Base de datos";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.LblPassword.Location = new System.Drawing.Point(12, 179);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(61, 13);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Contraseña";
            // 
            // RBtnRemote
            // 
            this.RBtnRemote.AutoSize = true;
            this.RBtnRemote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.RBtnRemote.Location = new System.Drawing.Point(70, 31);
            this.RBtnRemote.Name = "RBtnRemote";
            this.RBtnRemote.Size = new System.Drawing.Size(62, 17);
            this.RBtnRemote.TabIndex = 2;
            this.RBtnRemote.Text = "Remota";
            this.RBtnRemote.UseVisualStyleBackColor = true;
            this.RBtnRemote.CheckedChanged += new System.EventHandler(this.RBtnRemote_CheckedChanged);
            // 
            // Conecction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(406, 406);
            this.Controls.Add(this.MainPanel);
            this.Name = "Conecction";
            this.Text = "Conecction";
            this.Load += new System.EventHandler(this.Conecction_Load);
            this.Resize += new System.EventHandler(this.Conecction_Resize);
            this.RemotePanel.ResumeLayout(false);
            this.RemotePanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.Input InputDatasource;
        private Components.InputLabel LblDataSource;
        private Components.Input InputPassword;
        private Components.InputLabel LblPassword;
        private Components.RButton RbtnLocal;
        private Components.RButton RBtnRemote;
        private Components.InputLabel inputLabel1;
        private Components.Input InputDatabase;
        private Components.InputLabel LblDatabase;
        private System.Windows.Forms.Panel RemotePanel;
        private System.Windows.Forms.Panel MainPanel;
        private Components.PrimaryButton BtnAccept;
        private Components.DangerButton BtnClose;
        private Components.Input InputUsername;
        private Components.InputLabel LblUsername;
        private Components.Input InputPort;
        private Components.InputLabel LblPort;
    }
}