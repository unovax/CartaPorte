using CartaPorte.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartaPorte.Forms
{
    public partial class Errors : Form
    {
        public int TotalHeight = 100;
        public int TotalWidth = 100;
        public Errors(List<Globals.ValidationError> ValidationErrors)
        {
            InitializeComponent();
            int y = 10;
            foreach (Globals.ValidationError error in ValidationErrors)
            {
                TotalHeight += 30;
                this.Controls.Add(this.NewLabel(error.message, y));
                y += 30;
            }
            this.Height = TotalHeight;
            this.Width = TotalWidth + 200;
            foreach(Control control in this.Controls)
            {
                control.Left = this.Width / 2 - control.Width / 2;
            }
        }

        public Label NewLabel(string error, int y)
        {
            Label label = new Label();
            label.Text = error;
            label.Location = new Point(10, y);
            label.AutoSize = true;
            if (TotalWidth < label.Width) { TotalWidth = label.Width; }
            return label;
        }

        private void Errors_Load(object sender, EventArgs e)
        {

        }
    }
}
