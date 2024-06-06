using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ecomm.Logic.Auth;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Ecomm.Logic
{
    public static class Auth
    {
        public class Tenant
        {
            public string name { get; set; }
            public string rfc {  get; set; }
            public string phone { get; set; }

        }

        public class User
        {
            public int id;
            public string email { get; set; }
            public string name { get; set; }

            public Tenant tenant { get; set; }
        }

        public class AuthResponse {
            public string message { get; set; }
            public User user { get; set; }
            public Boolean error { get; set; }
            public string token { get; set; }
        }

        public static event Action LoginSuccess;

        public static Boolean Check()
        {
            Boolean response =  false;
            string token = Globals.GetProp("token");
            if (!string.IsNullOrEmpty(token))
            {
                try
                {
                    var client = new RestClient(Globals.BackUrl);
                    var request = new RestRequest("user");
                    request.AddHeader("Authorization", "Bearer " + token);

                    RestResponse rest_response = client.Execute(request, Method.Get);
                    if (rest_response.IsSuccessful)
                    {
                        response = true;
                    }
                }
                catch (Exception ex)
                {
                    response = false;
                }
            }
            return response;
        }

        public static AuthResponse Login(string code, string username, string password)
        {
            AuthResponse auth_response = new AuthResponse();
            try
            {
                var client = new RestClient(Globals.BackUrl);
                var request = new RestRequest("login");

                request.AddParameter("code", code);
                request.AddParameter("email", username);
                request.AddParameter("password", password);
               
                RestResponse rest_response = client.Execute(request, Method.Post);
                auth_response = JsonConvert.DeserializeObject<AuthResponse>(rest_response.Content);
                if(rest_response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    auth_response.error = true;
                    LoginSuccess?.Invoke();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return auth_response;
        }
    }
}
