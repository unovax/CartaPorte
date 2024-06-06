namespace Ecomm.Forms
{
    partial class Main
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
            this.BtnContacts = new Ecomm.Components.PrimaryButton();
            this.BtnProducts = new Ecomm.Components.PrimaryButton();
            this.SuspendLayout();
            // 
            // BtnContacts
            // 
            this.BtnContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.BtnContacts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.BtnContacts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.BtnContacts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.BtnContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContacts.ForeColor = System.Drawing.Color.White;
            this.BtnContacts.Location = new System.Drawing.Point(12, 12);
            this.BtnContacts.Name = "BtnContacts";
            this.BtnContacts.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnContacts.Size = new System.Drawing.Size(182, 42);
            this.BtnContacts.TabIndex = 0;
            this.BtnContacts.Text = "Obtener y Sincronizar contactos";
            this.BtnContacts.UseVisualStyleBackColor = false;
            this.BtnContacts.Click += new System.EventHandler(this.BtnContacts_Click);
            // 
            // BtnProducts
            // 
            this.BtnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.BtnProducts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.BtnProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.BtnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.BtnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProducts.ForeColor = System.Drawing.Color.White;
            this.BtnProducts.Location = new System.Drawing.Point(200, 12);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnProducts.Size = new System.Drawing.Size(182, 42);
            this.BtnProducts.TabIndex = 0;
            this.BtnProducts.Text = "Obtener y Sincronizar productos";
            this.BtnProducts.UseVisualStyleBackColor = false;
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnProducts);
            this.Controls.Add(this.BtnContacts);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.PrimaryButton BtnContacts;
        private Components.PrimaryButton BtnProducts;
    }
}