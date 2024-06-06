using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecomm.Components
{
    public class DangerButton : Button
    {
        public DangerButton()
        {
            InitializeControl();
        }
        private void InitializeControl()
        {
            this.BackColor = Colors.Red700;
            this.ForeColor = Color.White;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 1;
            this.FlatAppearance.BorderColor = Colors.Red700;
            this.FlatAppearance.MouseDownBackColor = Colors.Red600;
            this.FlatAppearance.MouseOverBackColor = Colors.Red600;
            this.Padding = new Padding(4, 2, 4, 2);
            this.AutoSize = false;
            this.Width = 100; // Establece el ancho del botón
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            InitializeControl();
        }
    }
}
