using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecomm.Components
{
    public class Input : TextBox
    {
        public Input()
        {
            InitializeControl();
        }
        private void InitializeControl()
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Colors.Gray700;
            this.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = Colors.Gray100;
            this.Padding = new Padding(5);
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            InitializeControl();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            // Cambiar el color de fondo solo si el control está deshabilitado
            if (this.Enabled)
            {
                this.BackColor = Colors.Gray700;
                this.ForeColor = Colors.Gray100;
            }
            else
            {
                this.BackColor = Colors.Gray300;
                this.ForeColor = Colors.Gray800;
            }
        }

    }
}
