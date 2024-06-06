namespace CartaPorte.Forms
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.LblCompany = new System.Windows.Forms.Label();
            this.TxtCompany = new System.Windows.Forms.TextBox();
            this.LabelMetodo = new System.Windows.Forms.Label();
            this.RbtnPhone = new System.Windows.Forms.RadioButton();
            this.RbtnEmail = new System.Windows.Forms.RadioButton();
            this.RbtnWa = new System.Windows.Forms.RadioButton();
            this.RbtnTelegram = new System.Windows.Forms.RadioButton();
            this.LblPhone = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.LblWelcome = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CboxSuscriptions = new System.Windows.Forms.ComboBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblPasswordConfirmation = new System.Windows.Forms.Label();
            this.TxtPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(12, 48);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(104, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Nombre de contacto";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(15, 65);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(224, 20);
            this.TxtName.TabIndex = 0;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(12, 539);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(227, 23);
            this.BtnRegister.TabIndex = 11;
            this.BtnRegister.Text = "Registrarme";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // LblCompany
            // 
            this.LblCompany.AutoSize = true;
            this.LblCompany.Location = new System.Drawing.Point(12, 94);
            this.LblCompany.Name = "LblCompany";
            this.LblCompany.Size = new System.Drawing.Size(113, 13);
            this.LblCompany.TabIndex = 0;
            this.LblCompany.Text = "Nombre de la empresa";
            // 
            // TxtCompany
            // 
            this.TxtCompany.Location = new System.Drawing.Point(15, 111);
            this.TxtCompany.Name = "TxtCompany";
            this.TxtCompany.Size = new System.Drawing.Size(224, 20);
            this.TxtCompany.TabIndex = 1;
            // 
            // LabelMetodo
            // 
            this.LabelMetodo.AutoSize = true;
            this.LabelMetodo.Location = new System.Drawing.Point(12, 337);
            this.LabelMetodo.Name = "LabelMetodo";
            this.LabelMetodo.Size = new System.Drawing.Size(103, 13);
            this.LabelMetodo.TabIndex = 0;
            this.LabelMetodo.Text = "Metodo de contacto";
            // 
            // RbtnPhone
            // 
            this.RbtnPhone.AutoSize = true;
            this.RbtnPhone.Checked = true;
            this.RbtnPhone.Location = new System.Drawing.Point(12, 368);
            this.RbtnPhone.Name = "RbtnPhone";
            this.RbtnPhone.Size = new System.Drawing.Size(67, 17);
            this.RbtnPhone.TabIndex = 6;
            this.RbtnPhone.TabStop = true;
            this.RbtnPhone.Text = "Telefono";
            this.RbtnPhone.UseVisualStyleBackColor = true;
            this.RbtnPhone.CheckedChanged += new System.EventHandler(this.RbtnPhone_CheckedChanged);
            // 
            // RbtnEmail
            // 
            this.RbtnEmail.AutoSize = true;
            this.RbtnEmail.Location = new System.Drawing.Point(12, 398);
            this.RbtnEmail.Name = "RbtnEmail";
            this.RbtnEmail.Size = new System.Drawing.Size(56, 17);
            this.RbtnEmail.TabIndex = 7;
            this.RbtnEmail.Text = "Correo";
            this.RbtnEmail.UseVisualStyleBackColor = true;
            this.RbtnEmail.CheckedChanged += new System.EventHandler(this.RbtnEmail_CheckedChanged);
            // 
            // RbtnWa
            // 
            this.RbtnWa.AutoSize = true;
            this.RbtnWa.Location = new System.Drawing.Point(12, 428);
            this.RbtnWa.Name = "RbtnWa";
            this.RbtnWa.Size = new System.Drawing.Size(74, 17);
            this.RbtnWa.TabIndex = 8;
            this.RbtnWa.Text = "Whatsapp";
            this.RbtnWa.UseVisualStyleBackColor = true;
            this.RbtnWa.CheckedChanged += new System.EventHandler(this.RbtnWa_CheckedChanged);
            // 
            // RbtnTelegram
            // 
            this.RbtnTelegram.AutoSize = true;
            this.RbtnTelegram.Location = new System.Drawing.Point(12, 458);
            this.RbtnTelegram.Name = "RbtnTelegram";
            this.RbtnTelegram.Size = new System.Drawing.Size(69, 17);
            this.RbtnTelegram.TabIndex = 9;
            this.RbtnTelegram.Text = "Telegram";
            this.RbtnTelegram.UseVisualStyleBackColor = true;
            this.RbtnTelegram.CheckedChanged += new System.EventHandler(this.RbtnTelegram_CheckedChanged);
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Location = new System.Drawing.Point(12, 140);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(49, 13);
            this.LblPhone.TabIndex = 0;
            this.LblPhone.Text = "Telefono";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(15, 157);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(224, 20);
            this.TxtPhone.TabIndex = 2;
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LblWelcome.Location = new System.Drawing.Point(67, 9);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(105, 24);
            this.LblWelcome.TabIndex = 5;
            this.LblWelcome.Text = "Bienvenido";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(12, 186);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(93, 13);
            this.LblEmail.TabIndex = 0;
            this.LblEmail.Text = "Correo electronico";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(15, 203);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(224, 20);
            this.TxtEmail.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Suscripción";
            // 
            // CboxSuscriptions
            // 
            this.CboxSuscriptions.FormattingEnabled = true;
            this.CboxSuscriptions.ItemHeight = 13;
            this.CboxSuscriptions.Location = new System.Drawing.Point(15, 507);
            this.CboxSuscriptions.Name = "CboxSuscriptions";
            this.CboxSuscriptions.Size = new System.Drawing.Size(224, 21);
            this.CboxSuscriptions.TabIndex = 10;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(12, 235);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(61, 13);
            this.LblPassword.TabIndex = 0;
            this.LblPassword.Text = "Contraseña";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(15, 252);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(224, 20);
            this.TxtPassword.TabIndex = 4;
            // 
            // LblPasswordConfirmation
            // 
            this.LblPasswordConfirmation.AutoSize = true;
            this.LblPasswordConfirmation.Location = new System.Drawing.Point(12, 284);
            this.LblPasswordConfirmation.Name = "LblPasswordConfirmation";
            this.LblPasswordConfirmation.Size = new System.Drawing.Size(107, 13);
            this.LblPasswordConfirmation.TabIndex = 0;
            this.LblPasswordConfirmation.Text = "Confirmar contraseña";
            // 
            // TxtPasswordConfirmation
            // 
            this.TxtPasswordConfirmation.Location = new System.Drawing.Point(15, 301);
            this.TxtPasswordConfirmation.Name = "TxtPasswordConfirmation";
            this.TxtPasswordConfirmation.PasswordChar = '*';
            this.TxtPasswordConfirmation.Size = new System.Drawing.Size(224, 20);
            this.TxtPasswordConfirmation.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(77, 574);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ya tengo cuenta";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 600);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.CboxSuscriptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblWelcome);
            this.Controls.Add(this.RbtnTelegram);
            this.Controls.Add(this.RbtnWa);
            this.Controls.Add(this.RbtnEmail);
            this.Controls.Add(this.RbtnPhone);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.TxtPasswordConfirmation);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.LblPasswordConfirmation);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TxtCompany);
            this.Controls.Add(this.LblPhone);
            this.Controls.Add(this.LabelMetodo);
            this.Controls.Add(this.LblCompany);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label LblCompany;
        private System.Windows.Forms.TextBox TxtCompany;
        private System.Windows.Forms.Label LabelMetodo;
        private System.Windows.Forms.RadioButton RbtnPhone;
        private System.Windows.Forms.RadioButton RbtnEmail;
        private System.Windows.Forms.RadioButton RbtnWa;
        private System.Windows.Forms.RadioButton RbtnTelegram;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboxSuscriptions;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblPasswordConfirmation;
        private System.Windows.Forms.TextBox TxtPasswordConfirmation;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}