namespace CartaPorte.Forms
{
    partial class Token
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Token));
            this.TxtToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnActivate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtToken
            // 
            this.TxtToken.Location = new System.Drawing.Point(12, 58);
            this.TxtToken.Name = "TxtToken";
            this.TxtToken.Size = new System.Drawing.Size(321, 20);
            this.TxtToken.TabIndex = 0;
            this.TxtToken.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Activa tu cuenta con la clave de activación que te proporcionaron";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clave de activación";
            // 
            // BtnActivate
            // 
            this.BtnActivate.Location = new System.Drawing.Point(131, 98);
            this.BtnActivate.Name = "BtnActivate";
            this.BtnActivate.Size = new System.Drawing.Size(75, 23);
            this.BtnActivate.TabIndex = 3;
            this.BtnActivate.Text = "Activar";
            this.BtnActivate.UseVisualStyleBackColor = true;
            this.BtnActivate.Click += new System.EventHandler(this.BtnActivate_Click);
            // 
            // Token
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 133);
            this.Controls.Add(this.BtnActivate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtToken);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(361, 172);
            this.MinimumSize = new System.Drawing.Size(361, 172);
            this.Name = "Token";
            this.Text = "Activa tu cuenta";
            this.Load += new System.EventHandler(this.Token_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnActivate;
    }
}