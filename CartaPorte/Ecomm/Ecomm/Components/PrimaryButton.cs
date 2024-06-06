using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecomm.Components
{
    public class PrimaryButton : Button
    {
        public PrimaryButton()
        {
            InitializeControl();
        }
        private void InitializeControl()
        {
            this.BackColor = Colors.Green700;
            this.ForeColor = Color.White;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 1;
            this.FlatAppearance.BorderColor = Colors.Green700;
            this.FlatAppearance.MouseDownBackColor = Colors.Green600;
            this.FlatAppearance.MouseOverBackColor = Colors.Green600;
            this.Padding = new Padding(4, 2, 4, 2);
            this.AutoSize = false;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            InitializeControl();
        }
    }
}
