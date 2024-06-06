using CartaPorte.Logica;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartaPorte.Forms
{
    public partial class Facturas : Form
    {
        string connectionString;
        public string folio = "";
        public int type = 0;
        public Facturas(string connectionString, string Parrafo, int type)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            LblParrafo.Text = Parrafo;
            this.type = type;
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            string query = "";
            if (this.type == 1)
            {
                query = @"SELECT DV.FOLIO, DV.""FECHA"", 'SI' AS FACARTURA_CERTIFICADA, 'SI' AS COMPLEMENTO_CARTA_PORTE
                    FROM DOCTOS_VE DV
                    JOIN DATOS_ADICIONALES DA ON DA.ELEM_ID = DV.DOCTO_VE_ID AND DA.TIPO_REG = '7'
                    WHERE DV.CFDI_CERTIFICADO = 'S'
                    ORDER BY DV.FOLIO DESC;
                ";
            }
            else
            {
                query = @"SELECT DV.FOLIO, DV.""FECHA"", 'NO' AS FACARTURA_CERTIFICADA
                    FROM DOCTOS_VE DV
                    WHERE DV.CFDI_CERTIFICADO = 'N'
                    ORDER BY DV.FOLIO DESC;
                ";
            }

            using (FbConnection connection = new FbConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();

                // Crear un adaptador de datos Firebird
                using (FbDataAdapter adapter = new FbDataAdapter(query, connection))
                {
                    // Crear un nuevo conjunto de datos para almacenar los resultados
                    DataSet dataSet = new DataSet();

                    // Llenar el conjunto de datos con los resultados de la consulta
                    adapter.Fill(dataSet);

                    // Asignar el conjunto de datos como origen de datos del DataGridView
                    DgvFacturas.DataSource = dataSet.Tables[0];

                    //AJUSTAR AUTOMATICAMENTE EL ANCHO DE LAS COLUMNAS
                    DgvFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
        }

        private void DgvFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string folio = DgvFacturas.Rows[e.RowIndex].Cells["FOLIO"].Value.ToString();
                this.folio = folio;
                this.Close();
            }
        }
    }
}
