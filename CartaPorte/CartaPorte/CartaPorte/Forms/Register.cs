using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CartaPorte.Forms;
using static CartaPorte.Logica.Globals;
using CartaPorte.Logica;
using Microsoft.Win32;
namespace CartaPorte.Forms
{
    public partial class Register : Form
    {
        public class ComboBoxItem
        {
            public long Value { get; set; }
            public string Text { get; set; }

            public override string ToString()
            {
                return Text; // Display the Text property in the ComboBox
            }
        }

        public string option = "Telefono";

        public class Suscrption
        {
            public long id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public Decimal price { get; set; }
            public int days { get; set; }
        }

        public List<ValidationError> ValidationErrors;

        public List<Suscrption> suscriptions;
        private long suscription_id = 0;

        public async void GetSuscriptions()
        {
            try
            {
                var client = new RestClient(Globals.BackUrl);
                var request = new RestRequest("/suscriptions");

                var response = await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    suscriptions = JsonConvert.DeserializeObject<List<Suscrption>>(response.Content);

                    // Agregar las suscriptios al combobox, valor = id, text = name
                    foreach (var subscription in suscriptions)
                    {
                        CboxSuscriptions.Items.Add(new ComboBoxItem { Value = subscription.id, Text = subscription.name });
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Register()
        {
            GetSuscriptions();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            LblWelcome.Left = this.Width / 2 - LblWelcome.Width / 2;
            this.MaximizeBox = false;
        }

        private bool ValidateFrom()
        {
            Boolean hasError = false;
            ValidationErrors = new List<ValidationError>();
            if (string.IsNullOrEmpty(TxtCompany.Text)) {
                ValidationErrors.Add(new ValidationError(true, "Empresa requerida"));
                hasError = true;
            };
            if (string.IsNullOrEmpty(TxtName.Text)) {
                ValidationErrors.Add(new ValidationError(true, "Nombre requerido"));
                hasError = true;
            };
            if (string.IsNullOrEmpty(TxtEmail.Text)) {
               ValidationErrors.Add(new ValidationError(true, "Correo electronico requerido"));
                hasError = true;
            };
            if (string.IsNullOrEmpty(TxtPhone.Text)) {
                ValidationErrors.Add(new ValidationError(true, "Telefono requerido"));
                hasError = true;
            };
            if (string.IsNullOrEmpty(TxtPassword.Text)) {
                ValidationErrors.Add(new ValidationError(true, "Contraseña requerida"));
                hasError = true;
            };
            if (string.IsNullOrEmpty(TxtPassword.Text)) {
                ValidationErrors.Add(new ValidationError(true, "Confirmar contraseña requerida"));
                hasError = true;
            };
            if (!TxtPassword.Text.Equals(TxtPasswordConfirmation.Text))
            {
                ValidationErrors.Add(new ValidationError(true, "Las contraseñas no coinciden"));
                hasError = true;
            }
            if (suscription_id == 0) {
                ValidationErrors.Add(new ValidationError(true, "Suscripción requerida"));
                hasError = true;
            };
            return hasError;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (CboxSuscriptions.SelectedItem != null)
            {
                ComboBoxItem selectedComboBoxItem = (ComboBoxItem)CboxSuscriptions.SelectedItem;
                suscription_id = selectedComboBoxItem.Value;
            }
            if (this.ValidateFrom()) {
                Errors errores = new Errors(ValidationErrors);
                errores.ShowDialog();
                return;
            };
            try
            {
                var client = new RestClient(Globals.BackUrl);
                var request = new RestRequest("/register");

                request.AddParameter("name", TxtName.Text);
                request.AddParameter("company", TxtCompany.Text);
                request.AddParameter("contact_method", option);
                request.AddParameter("phone", TxtPhone.Text);
                request.AddParameter("email", TxtEmail.Text);
                request.AddParameter("suscription_id", suscription_id);

                var response = client.Execute(request, Method.Post);
                if (response.IsSuccessStatusCode)
                {
                    //usar JSON NEWTONSOFT PARA DESIREALZIAR EL RESPONSE.CONTENT

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
                    MessageBox.Show(ApiResponse.message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RbtnPhone_CheckedChanged(object sender, EventArgs e)
        {
            option = RbtnPhone.Text;
        }

        private void RbtnEmail_CheckedChanged(object sender, EventArgs e)
        {
            option = RbtnEmail.Text;
        }

        private void RbtnWa_CheckedChanged(object sender, EventArgs e)
        {
            option = RbtnWa.Text;
        }

        private void RbtnTelegram_CheckedChanged(object sender, EventArgs e)
        {
            option = RbtnTelegram.Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Forms.Login login = new Forms.Login();

            int x = this.Location.X + (this.Width - login.Width) / 2;
            int y = this.Location.Y + (this.Height - login.Height) / 2;
            if (y < 0)
            {
                y = 10;
            }
            login.StartPosition = FormStartPosition.Manual;
            login.Location = new Point(x, y);

            login.ShowDialog();
            this.Close();
        }
    }
}
