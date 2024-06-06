namespace Ecomm.Forms
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
            this.BtnClose = new Ecomm.Components.DangerButton();
            this.BtnLogin = new Ecomm.Components.PrimaryButton();
            this.LblPassword = new Ecomm.Components.InputLabel();
            this.LblUsername = new Ecomm.Components.InputLabel();
            this.InputPassword = new Ecomm.Components.Input();
            this.InputUsername = new Ecomm.Components.Input();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.InputCode = new Ecomm.Components.Input();
            this.LblCode = new Ecomm.Components.InputLabel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(185, 178);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnClose.Size = new System.Drawing.Size(100, 36);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Cerrar";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(291, 178);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnLogin.Size = new System.Drawing.Size(99, 36);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Iniciar sesión";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.LblPassword.Location = new System.Drawing.Point(7, 122);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(61, 13);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Contraseña";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.LblUsername.Location = new System.Drawing.Point(7, 69);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(43, 13);
            this.LblUsername.TabIndex = 1;
            this.LblUsername.Text = "Usuario";
            // 
            // InputPassword
            // 
            this.InputPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.InputPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.InputPassword.Location = new System.Drawing.Point(10, 138);
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.Size = new System.Drawing.Size(380, 26);
            this.InputPassword.TabIndex = 1;
            // 
            // InputUsername
            // 
            this.InputUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.InputUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.InputUsername.Location = new System.Drawing.Point(10, 85);
            this.InputUsername.Name = "InputUsername";
            this.InputUsername.Size = new System.Drawing.Size(380, 26);
            this.InputUsername.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.LblCode);
            this.MainPanel.Controls.Add(this.LblUsername);
            this.MainPanel.Controls.Add(this.BtnClose);
            this.MainPanel.Controls.Add(this.InputCode);
            this.MainPanel.Controls.Add(this.InputUsername);
            this.MainPanel.Controls.Add(this.BtnLogin);
            this.MainPanel.Controls.Add(this.InputPassword);
            this.MainPanel.Controls.Add(this.LblPassword);
            this.MainPanel.Location = new System.Drawing.Point(200, 161);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(400, 223);
            this.MainPanel.TabIndex = 4;
            // 
            // InputCode
            // 
            this.InputCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.InputCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.InputCode.Location = new System.Drawing.Point(10, 31);
            this.InputCode.Name = "InputCode";
            this.InputCode.Size = new System.Drawing.Size(380, 26);
            this.InputCode.TabIndex = 0;
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.LblCode.Location = new System.Drawing.Point(7, 15);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(109, 13);
            this.LblCode.TabIndex = 1;
            this.LblCode.Text = "Código de la empresa";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.MainPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Resize += new System.EventHandler(this.Login_Resize);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.Input InputUsername;
        private Components.InputLabel LblUsername;
        private Components.Input InputPassword;
        private Components.InputLabel LblPassword;
        private Components.PrimaryButton BtnLogin;
        private Components.DangerButton BtnClose;
        private System.Windows.Forms.Panel MainPanel;
        private Components.InputLabel LblCode;
        private Components.Input InputCode;
    }
}