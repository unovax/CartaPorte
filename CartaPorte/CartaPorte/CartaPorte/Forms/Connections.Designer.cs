namespace CartaPorte
{
    partial class Connections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connections));
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RBtnLocal = new System.Windows.Forms.RadioButton();
            this.RBtnRemote = new System.Windows.Forms.RadioButton();
            this.LblType = new System.Windows.Forms.Label();
            this.PanelLocal = new System.Windows.Forms.Panel();
            this.PanelRemote = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.LblServidor = new System.Windows.Forms.Label();
            this.TxtRemoteDB = new System.Windows.Forms.TextBox();
            this.TxtRemoteIP = new System.Windows.Forms.TextBox();
            this.PanelLocal.SuspendLayout();
            this.PanelRemote.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(114, 12);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(258, 20);
            this.TxtUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de usuario";
            // 
            // TxtDB
            // 
            this.TxtDB.Location = new System.Drawing.Point(3, 23);
            this.TxtDB.Name = "TxtDB";
            this.TxtDB.ReadOnly = true;
            this.TxtDB.Size = new System.Drawing.Size(354, 20);
            this.TxtDB.TabIndex = 2;
            this.TxtDB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TxtDB_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conexión";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(114, 43);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(258, 20);
            this.TxtPassword.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contraseña";
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(153, 235);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(75, 23);
            this.BtnAccept.TabIndex = 4;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Explorar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RBtnLocal
            // 
            this.RBtnLocal.AutoSize = true;
            this.RBtnLocal.Location = new System.Drawing.Point(13, 95);
            this.RBtnLocal.Name = "RBtnLocal";
            this.RBtnLocal.Size = new System.Drawing.Size(51, 17);
            this.RBtnLocal.TabIndex = 5;
            this.RBtnLocal.TabStop = true;
            this.RBtnLocal.Text = "Local";
            this.RBtnLocal.UseVisualStyleBackColor = true;
            this.RBtnLocal.CheckedChanged += new System.EventHandler(this.RBtnLocal_CheckedChanged);
            // 
            // RBtnRemote
            // 
            this.RBtnRemote.AutoSize = true;
            this.RBtnRemote.Location = new System.Drawing.Point(71, 95);
            this.RBtnRemote.Name = "RBtnRemote";
            this.RBtnRemote.Size = new System.Drawing.Size(62, 17);
            this.RBtnRemote.TabIndex = 6;
            this.RBtnRemote.TabStop = true;
            this.RBtnRemote.Text = "Remota";
            this.RBtnRemote.UseVisualStyleBackColor = true;
            this.RBtnRemote.CheckedChanged += new System.EventHandler(this.RBtnRemote_CheckedChanged);
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(10, 75);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(89, 13);
            this.LblType.TabIndex = 7;
            this.LblType.Text = "Tipo de conexión";
            // 
            // PanelLocal
            // 
            this.PanelLocal.Controls.Add(this.button1);
            this.PanelLocal.Controls.Add(this.TxtDB);
            this.PanelLocal.Controls.Add(this.label2);
            this.PanelLocal.Location = new System.Drawing.Point(13, 118);
            this.PanelLocal.Name = "PanelLocal";
            this.PanelLocal.Size = new System.Drawing.Size(360, 95);
            this.PanelLocal.TabIndex = 8;
            // 
            // PanelRemote
            // 
            this.PanelRemote.Controls.Add(this.label4);
            this.PanelRemote.Controls.Add(this.LblServidor);
            this.PanelRemote.Controls.Add(this.TxtRemoteDB);
            this.PanelRemote.Controls.Add(this.TxtRemoteIP);
            this.PanelRemote.Location = new System.Drawing.Point(13, 117);
            this.PanelRemote.Name = "PanelRemote";
            this.PanelRemote.Size = new System.Drawing.Size(360, 95);
            this.PanelRemote.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ubicación base de datos";
            // 
            // LblServidor
            // 
            this.LblServidor.AutoSize = true;
            this.LblServidor.Location = new System.Drawing.Point(0, 8);
            this.LblServidor.Name = "LblServidor";
            this.LblServidor.Size = new System.Drawing.Size(58, 13);
            this.LblServidor.TabIndex = 1;
            this.LblServidor.Text = "Ip Servidor";
            // 
            // TxtRemoteDB
            // 
            this.TxtRemoteDB.Location = new System.Drawing.Point(-3, 71);
            this.TxtRemoteDB.Name = "TxtRemoteDB";
            this.TxtRemoteDB.Size = new System.Drawing.Size(360, 20);
            this.TxtRemoteDB.TabIndex = 3;
            this.TxtRemoteDB.TextChanged += new System.EventHandler(this.TxtRemoteDB_TextChanged);
            // 
            // TxtRemoteIP
            // 
            this.TxtRemoteIP.Location = new System.Drawing.Point(1, 22);
            this.TxtRemoteIP.Name = "TxtRemoteIP";
            this.TxtRemoteIP.Size = new System.Drawing.Size(360, 20);
            this.TxtRemoteIP.TabIndex = 2;
            this.TxtRemoteIP.TextChanged += new System.EventHandler(this.TxtRemoteDB_TextChanged);
            // 
            // Connections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 267);
            this.Controls.Add(this.PanelRemote);
            this.Controls.Add(this.PanelLocal);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.RBtnRemote);
            this.Controls.Add(this.RBtnLocal);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 306);
            this.MinimumSize = new System.Drawing.Size(400, 306);
            this.Name = "Connections";
            this.Text = "Cambiar de usuario y conexión";
            this.Load += new System.EventHandler(this.Connections_Load);
            this.PanelLocal.ResumeLayout(false);
            this.PanelLocal.PerformLayout();
            this.PanelRemote.ResumeLayout(false);
            this.PanelRemote.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RBtnLocal;
        private System.Windows.Forms.RadioButton RBtnRemote;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Panel PanelLocal;
        private System.Windows.Forms.Panel PanelRemote;
        private System.Windows.Forms.TextBox TxtRemoteIP;
        private System.Windows.Forms.Label LblServidor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRemoteDB;
    }
}