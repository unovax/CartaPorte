using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;
using System.Xml.Linq;
using static CartaPorte.Logica.UserModel;

namespace CartaPorte.Logica
{
    public static class Globals
    {
        public class Factura
        {
            public long DATOS_ADICIONALES_ID;
            public long DOCTO_VE_ID { get; }
            public string FECHA { get; }
            public string MONEDA { get; }
            public string NO_CLIENTE { get; }
            public string CLIENTE { get; }
            public string ALMACEN { get; }
            public string ORDEN_COMPRA { get; }
            public string XML { get; set; }
            public string DATO2 { get; set; }

            public string CFDI_CERTIFICADO { get; set; }

            public Factura(long DOCTO_VE_ID, string FECHA, string MONEDA, string NO_CLIENTE, string CLIENTE, string ALMACEN, string ORDEN_COMPRA)
            {
                this.DOCTO_VE_ID = DOCTO_VE_ID;
                this.FECHA = FECHA;
                this.MONEDA = MONEDA;
                this.NO_CLIENTE = NO_CLIENTE;
                this.CLIENTE = CLIENTE;
                this.ALMACEN = ALMACEN;
                this.ORDEN_COMPRA = ORDEN_COMPRA;
            }
        }
        public class GetUserResponse
        {
            public string message {  get; set; }
            public Boolean error { get; set; }

        }

        public class CheckStatusResponse
        {
            public string message { get; set; }
            public Boolean error { get; set; }
            public CurrentSuscription current_suscription { get; set; }
        }

        public static string Token = null;
        public static string BackUrl = "https://apps.bplussoft.com/cartaporte/public/api";
        //public static string BackUrl = "http://127.0.0.1:8000/api";
        public static string PasswordUrl = "http://127.0.0.1:8000/password_recovery";
        //public static string PasswordUrl = "https://apps.bplussoft.com/cartaporte/public/password_reset";


        public class ValidationError
        {
            public Boolean error { get; set; }
            public string message { get; set; }

            public ValidationError(Boolean error, string message)
            {
                this.error = error;
                this.message = message;
            }
        }

        public static GetUserResponse GetUser(string Token)
        {
            GetUserResponse get_user_response = new GetUserResponse();
            try
            {
                var client = new RestClient(Globals.BackUrl);
                var request = new RestRequest("/user");
                //add header
                request.AddHeader("Authorization", "Bearer " + Token);

                var response = client.Get(request);
                if (response.IsSuccessStatusCode)
                {
                    UserModel.ApiResponse ApiResponse = JsonConvert.DeserializeObject<UserModel.ApiResponse>(response.Content);
                    get_user_response = new GetUserResponse()
                    {
                        error = false,
                        message = "Inicio de sesion correcto",
                    };
                    Auth.User = ApiResponse.User;
                }

            }
            catch (Exception ex)
            {
                get_user_response = new GetUserResponse()
                {
                    error = true,
                    message = ex.Message,
                };
            }

            return get_user_response;
        }

        public static void CheckStatusSuscription()
        {
            CheckStatusResponse checkStatusResponse = new CheckStatusResponse();
            try
            {
                var client = new RestClient(Globals.BackUrl);
                var request = new RestRequest("/check_status_suscription");
                request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.Token);
                var response = client.Get(request);
                if (response.IsSuccessStatusCode)
                {
                    checkStatusResponse = JsonConvert.DeserializeObject<CheckStatusResponse>(response.Content);
                    Auth.User.current_suscription = checkStatusResponse.current_suscription;
                }
            }
            catch (Exception ex)
            {
                checkStatusResponse.error = true;
            }
        }
    }
}
