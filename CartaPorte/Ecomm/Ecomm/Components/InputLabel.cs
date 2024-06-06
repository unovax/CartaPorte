﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecomm.Components
{
    public class InputLabel : Label
    {
        public InputLabel()
        {
            InitializeControl();
        }
        private void InitializeControl()
        {
            this.ForeColor = Colors.Gray100;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            InitializeControl();
        }
    }
}
