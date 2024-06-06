using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ecomm.Models.ActionModel;

namespace Ecomm.Logic
{
    public static class ContactModel
    {
        public class ContactResponse
        {
            public string message { get; set; }
            public Boolean errored { get; set; }
            public List<Contact> contacts { get; set; }
        }

        public class Contact
        {
            public int CONTACTO_CLIENTE_ID { get; set; }
            public int CLIENTE_ID { get; set; }
            public string NOMBRE { get; set; }
            public string EMAIL { get; set; }
            public string TELEFONO_TRABAJO { get; set; }
            public string TELEFONO_MOVIL { get; set; }
        }

        public static ContactResponse GetContacts()
        {
            ContactResponse contactResponse = new ContactResponse();
            using (FbConnection FbConn = new FbConnection(Globals.ConnString))
            {
                FbConn.Open();
                string query = @"
                    SELECT * FROM CONTACTOS_CLIENTES CC 
                    JOIN CONTACTOS_CLIENTES_ACCIONES CCA 
                    ON CCA.CONTACTO_CLIENTE_ID = CC.CONTACTO_CLIENTE_ID 
                    AND CCA.ACCION_ID = 9999;";
                using (FbCommand FbCommand = new FbCommand(query, FbConn))
                {
                    FbDataReader reader = FbCommand.ExecuteReader();

                    contactResponse.contacts = new List<Contact>();
                    while (reader.Read())
                    {
                        contactResponse.contacts.Add(new Contact()
                        {
                            CONTACTO_CLIENTE_ID = reader.GetInt32Safe("CONTACTO_CLIENTE_ID"),
                            CLIENTE_ID = reader.GetInt32Safe("CLIENTE_ID"),
                            NOMBRE = reader.GetStringSafe("NOMBRE"),
                            EMAIL = reader.GetStringSafe("EMAIL"),
                            TELEFONO_TRABAJO = reader.GetStringSafe("TELEFONO_TRABAJO"),
                            TELEFONO_MOVIL = reader.GetStringSafe("TELEFONO_MOVIL")
                        });
                    }
                }
            }
            return contactResponse;
        }
    }
}
