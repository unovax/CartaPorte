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
using CartaPorte.Logica;

namespace CartaPorte.Forms
{
    public partial class Token : Form
    {
        public Token()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void BtnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient(Globals.BackUrl);
                var request = new RestRequest("/checkToken");

                request.AddParameter("token", TxtToken.Text);

                var response = await client.PostAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    Properties.Settings.Default.Token = TxtToken.Text;
                    Properties.Settings.Default.Save();

                    this.Hide();
                    Connections connections = new Connections();
                    connections.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La clave de activacion proporcionada no pertenece a nuestro sistema, favor de verificarla");
            }
        }

        private void Token_Load(object sender, EventArgs e)
        {

        }
    }
}
