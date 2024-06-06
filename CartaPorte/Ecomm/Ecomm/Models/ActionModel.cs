using Ecomm.Logic;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecomm.Models
{
    public static class ActionModel
    {
        public class Response
        {
            public Boolean Error { get; set; }
            public string Message { get; set; }

            public Response() {
                this.Error = false;
                this.Message = string.Empty;
            }
        }
        public static Response CheckIfActionExist()
        {
            Response response = new Response();
            using(FbConnection FbConn = new FbConnection(Globals.ConnString))
            {
                FbConn.Open();
                string query = @"SELECT * FROM ACCIONES_CONTACTOS_CLIENTES acc WHERE acc.CLAVE = 'CONECTAR_ECOMM';";
                using (FbCommand FbCommand = new FbCommand(query, FbConn))
                {
                    FbDataReader reader = FbCommand.ExecuteReader();
                    
                    if (reader.Read())
                    {
                        return response;
                    }
                    response = CreateEcommAction();
                    Globals.SetProp("ActionEcommCreated", true);
                }
            }
            return response;
        }

        private static Response CreateEcommAction()
        {
            Response response = new Response();
            using (FbConnection FbConn = new FbConnection(Globals.ConnString))
            {
                try
                {
                    FbConn.Open();
                    string query = @"INSERT INTO ACCIONES_CONTACTOS_CLIENTES
                            (ACCION_ID, NOMBRE, CLAVE)
                            VALUES(9999, 'Conectar Ecomm', 'CONECTAR_ECOMM')";
                    using (FbCommand FbCommand = new FbCommand(query, FbConn))
                    {
                        FbCommand.ExecuteNonQuery();
                        response.Message = "Accion creada correctamente";
                    }
                }
                catch (Exception ex)
                {
                    response.Message = ex.Message;
                    response.Error = true;
                }
            }
            return response;
        }
    }
}
