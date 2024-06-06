using Ecomm.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecomm.Forms
{
    public partial class Login : Form
    {
        AppForm AppForm;
        public Login(AppForm AppForm)
        {
            this.AppForm = AppForm;
            InitializeComponent();
        }
       
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Auth.AuthResponse auth_response = Auth.Login(InputCode.Text, InputUsername.Text, InputPassword.Text);
            if (auth_response.error)
            {
                MessageBox.Show(auth_response.message, "Inicio de sesión invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Globals.SetProp("token", auth_response.token);
            AppForm.LoginSuccess();
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            Globals.CenterPanel(MainPanel, this.ClientSize);
        }
    }
}
