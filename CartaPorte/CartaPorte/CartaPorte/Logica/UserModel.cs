using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartaPorte.Logica
{
    public class UserModel
    {
        public class ApiResponse
        {
            public string message { get; set; }
            public User User { get; set; }
        }

        public class CurrentSuscription
        {
            public int id { get; set; }
            public int user_id { get; set; }
            public int suscription_id { get; set; }
            public string status { get; set; }
            public object start_date { get; set; }
            public object end_date { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public Suscription suscription { get; set; }
        }

        public class User
        {
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string company { get; set; }
            public string phone { get; set; }
            public string contact_method { get; set; }
            public object email_verified_at { get; set; }
            public string role { get; set; }
            public string token { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public CurrentSuscription current_suscription { get; set; }
        }

        public class Suscription
        {
            public int id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string price { get; set; }
            public string days { get; set; }
            public string status { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
        }


    }
}
