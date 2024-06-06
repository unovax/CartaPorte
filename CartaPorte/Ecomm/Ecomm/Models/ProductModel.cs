using Ecomm.Logic;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ecomm.Logic.ContactModel;

namespace Ecomm.Models
{
    public static class ProductModel
    {
        public class ProductResponse
        {
            public string message { get; set; }
            public Boolean error { get; set; }
            public List<Product> products { get; set; }
        }

        public class Product
        {
            public int ARTICULO_ID { get; set; }
            public string NOMBRE { get; set; }
            public string DESCRIPCION { get; set; }
            public Decimal PRECIO { get; set; }
            public string MONEDA { get; set; }
            public int LINEA_ARTICULO_ID { get; set; }
            public string LINEA { get; set; }
            public int GRUPO_LINEA_ID { get; set; }
            public string GRUPO { get; set; }
            public string IMAGEN { get; set; }

        }

        public static ProductResponse GetProducts()
        {
            ProductResponse ProductResponse = new ProductResponse();
            using (FbConnection FbConn = new FbConnection(Globals.ConnString))
            {
                FbConn.Open();
                string query = @"SELECT 
                    A.ARTICULO_ID, 
                    A.NOMBRE, 
                    A.NOTAS_VENTAS AS DESCRIPCION,
                    PA.PRECIO,
                    M.NOMBRE AS MONEDA,
                    LA.LINEA_ARTICULO_ID,
                    LA.NOMBRE AS LINEA,
                    GL.GRUPO_LINEA_ID,
                    GL.NOMBRE AS GRUPO,
                    IA.IMAGEN
                FROM ARTICULOS A 
                JOIN PRECIOS_ARTICULOS PA ON PA.ARTICULO_ID = A.ARTICULO_ID
                JOIN MONEDAS M ON M.MONEDA_ID = PA.MONEDA_ID
                LEFT JOIN LINEAS_ARTICULOS LA ON LA.LINEA_ARTICULO_ID = A.LINEA_ARTICULO_ID
                LEFT JOIN GRUPOS_LINEAS GL ON GL.GRUPO_LINEA_ID = LA.LINEA_ARTICULO_ID
                LEFT JOIN IMAGENES_ARTICULOS IA ON IA.ARTICULO_ID = A.ARTICULO_ID
                WHERE PA.PRECIO_EMPRESA_ID = 42;";

                using (FbCommand FbCommand = new FbCommand(query, FbConn))
                {
                    FbDataReader reader = FbCommand.ExecuteReader();

                    ProductResponse.products = new List<Product>();
                    while (reader.Read())
                    {
                        ProductResponse.products.Add(new Product()
                        {
                            ARTICULO_ID = reader.GetInt32Safe("ARTICULO_ID"),
                            NOMBRE = reader.GetStringSafe("NOMBRE"),
                            DESCRIPCION = reader.GetStringSafe("DESCRIPCION"),
                            PRECIO = reader.GetDecimalSafe("PRECIO"),
                            MONEDA = reader.GetStringSafe("MONEDA"),
                            LINEA_ARTICULO_ID = reader.GetInt32Safe("LINEA_ARTICULO_ID"),
                            LINEA = reader.GetStringSafe("LINEA"),
                            GRUPO_LINEA_ID = reader.GetInt32Safe("GRUPO_LINEA_ID"),
                            GRUPO = reader.GetStringSafe("GRUPO"),
                            IMAGEN = reader.GetBytesSafe("IMAGEN") != null ? Convert.ToBase64String(reader.GetBytesSafe("IMAGEN")) : null,
                        });
                    }
                }
            }
            return ProductResponse;
        }
    }
}
