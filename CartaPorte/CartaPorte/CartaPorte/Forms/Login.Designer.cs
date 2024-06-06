namespace CartaPorte.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LinkRegister = new System.Windows.Forms.LinkLabel();
            this.LinkPassword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(9, 14);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(93, 13);
            this.LblEmail.TabIndex = 0;
            this.LblEmail.Text = "Correo electronico";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(12, 30);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(280, 20);
            this.TxtEmail.TabIndex = 0;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(9, 62);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(61, 13);
            this.LblPassword.TabIndex = 0;
            this.LblPassword.Text = "Contraseña";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(12, 78);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(280, 20);
            this.TxtPassword.TabIndex = 1;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(90, 114);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(118, 23);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Iniciar sesión";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LinkRegister
            // 
            this.LinkRegister.AutoSize = true;
            this.LinkRegister.Location = new System.Drawing.Point(69, 143);
            this.LinkRegister.Name = "LinkRegister";
            this.LinkRegister.Size = new System.Drawing.Size(157, 13);
            this.LinkRegister.TabIndex = 3;
            this.LinkRegister.TabStop = true;
            this.LinkRegister.Text = "¿No tienes cuenta? ¡Registrate!";
            this.LinkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LinkPassword
            // 
            this.LinkPassword.AutoSize = true;
            this.LinkPassword.Location = new System.Drawing.Point(96, 161);
            this.LinkPassword.Name = "LinkPassword";
            this.LinkPassword.Size = new System.Drawing.Size(106, 13);
            this.LinkPassword.TabIndex = 4;
            this.LinkPassword.TabStop = true;
            this.LinkPassword.Text = "Olvide mi contraseña";
            this.LinkPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPassword_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 181);
            this.Controls.Add(this.LinkPassword);
            this.Controls.Add(this.LinkRegister);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(320, 240);
            this.MinimumSize = new System.Drawing.Size(320, 220);
            this.Name = "Login";
            this.Text = "Iniciar sesión";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.LinkLabel LinkRegister;
        private System.Windows.Forms.LinkLabel LinkPassword;
    }
}