namespace CartaPorte.Forms
{
    partial class Facturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturas));
            this.DgvFacturas = new System.Windows.Forms.DataGridView();
            this.LblParrafo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvFacturas
            // 
            this.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFacturas.Location = new System.Drawing.Point(12, 33);
            this.DgvFacturas.Name = "DgvFacturas";
            this.DgvFacturas.Size = new System.Drawing.Size(776, 405);
            this.DgvFacturas.TabIndex = 0;
            this.DgvFacturas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFacturas_CellDoubleClick);
            // 
            // LblParrafo
            // 
            this.LblParrafo.AutoSize = true;
            this.LblParrafo.Location = new System.Drawing.Point(12, 9);
            this.LblParrafo.Name = "LblParrafo";
            this.LblParrafo.Size = new System.Drawing.Size(35, 13);
            this.LblParrafo.TabIndex = 1;
            this.LblParrafo.Text = "label1";
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblParrafo);
            this.Controls.Add(this.DgvFacturas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Facturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.Facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvFacturas;
        private System.Windows.Forms.Label LblParrafo;
    }
}