using CartaPorte.Logica;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Xml.Linq;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace CartaPorte.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private String[] errors;
        private Boolean ValidateForm()
        {
            Boolean result = true;
            if(string.IsNullOrEmpty(this.TxtEmail.Text) || string.IsNullOrEmpty(this.TxtPassword.Text)) {
                result = false;
            }
            return result;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!this.ValidateForm())
            {
                MessageBox.Show("No dejes ningun campo en blanco");
                return;
            }
            try
            {
                var client = new RestClient(Globals.BackUrl);
                var request = new RestRequest("/login");

                request.AddParameter("email", TxtEmail.Text);
                request.AddParameter("password", TxtPassword.Text);

                var response = client.Execute(request, Method.Post);
                if (response.IsSuccessful)
                {
                    UserModel.ApiResponse ApiResponse = JsonConvert.DeserializeObject<UserModel.ApiResponse>(response.Content);
                    Properties.Settings.Default.Token = ApiResponse.User.token;
                    Properties.Settings.Default.HasBeenRegistered = true;
                    Properties.Settings.Default.Save();
                    this.Hide();
                    Connections conn = new Connections();
                    int x = this.Location.X + (this.Width - conn.Width) / 2;
                    int y = this.Location.Y + (this.Height - conn.Height) / 2;
                    if (y < 0)
                    {
                        y = 10;
                    }
                    conn.StartPosition = FormStartPosition.Manual;
                    conn.Location = new Point(x, y);
                    conn.ShowDialog();
                    this.Close();
                }
                else
                {
                    UserModel.ApiResponse ApiResponse = JsonConvert.DeserializeObject<UserModel.ApiResponse>(response.Content);
                    // MessageBox.Show(ApiResponse.message);
                    //Message box con icono
                    MessageBox.Show(ApiResponse.message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();


            int x = this.Location.X + (this.Width - register.Width) / 2;
            int y = this.Location.Y + (this.Height - register.Height) / 2;
            if (y < 0)
            {
                y = 10;
            }
            register.StartPosition = FormStartPosition.Manual;
            register.Location = new Point(x, y);

            register.ShowDialog();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            center();
        }

        private void center()
        {
            BtnLogin.Left = this.Width / 2 - BtnLogin.Width / 2;
            LinkPassword.Left = this.Width / 2 - LinkPassword.Width / 2;
            LinkRegister.Left = this.Width / 2 - LinkRegister.Width / 2;
        }

        private void LinkPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = $"{Globals.PasswordUrl}?email={TxtEmail.Text}";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }
}
