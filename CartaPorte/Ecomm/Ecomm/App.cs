using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ecomm.Forms;
using Ecomm.Logic;
using Ecomm.Models;
namespace Ecomm
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        public void LoadView(Form view)
        {
            MainPanel.Controls.Clear();
            view.TopLevel = false;
            view.FormBorderStyle = FormBorderStyle.None;
            view.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(view);
            MainPanel.Tag = view;
            view.Show();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            if (!Auth.Check())
            {
                LoadView(new Login(this));
                return;
            }
            LoginSuccess();
        }

        public void LoginSuccess()
        {
            LogoutBtn.Visible = true;
            LoadView(new Conecction(this));
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Globals.SetProp("token", "");
            LogoutBtn.Visible = false;
            LoadView(new Login(this)); return;
        }
    }
}
