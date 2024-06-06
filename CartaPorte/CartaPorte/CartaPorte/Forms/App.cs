using CartaPorte.Logica;
using FirebirdSql.Data.FirebirdClient;
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
using static CartaPorte.Logica.Globals;

namespace CartaPorte.Forms
{
    public partial class App : Form
    {
        private Timer timer;
        public App()
        {
            
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            // Configura el temporizador para que se dispare cada minuto (60000 ms)
            timer = new Timer();
            timer.Interval = 10000; // 1 minuto
            timer.Tick += async (sender, e) => await TimerTickAsync();
            timer.Start();
        }

        private async Task TimerTickAsync()
        {
            // Aquí va la función que deseas ejecutar cada minuto
            await Task.Run(() =>
            {
                if (!string.IsNullOrEmpty(Properties.Settings.Default.Token))
                {
                    Globals.CheckStatusSuscription();
                }
                
            });
            this.BeginInvoke((Action)(() =>
            {
                if (!string.IsNullOrEmpty(Properties.Settings.Default.Token))
                {
                     SetLoadData(); 
                }
            }));


        }

        Globals.Factura factura;
        Globals.Factura factura2;
        public int DATOS_ADICIONALES_ID1;
        public int DATOS_ADICIONALES_ID2;
        string connectionString;

        private void TxtFolio_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && factura == null)
            {
                BuscarFactura();
            }

        }

        public void BuscarFactura()
        {
            if (string.IsNullOrEmpty(TxtFolio.Text))
            {
                Facturas facturas = new Facturas(connectionString, "Seleccione la factura origen con complemento de carta porte", 1);
                int x = this.Location.X + (this.Width - facturas.Width) / 2;
                int y = this.Location.Y + (this.Height - facturas.Height) / 2;

                // Establecer la posición inicial del formulario de Facturas como la ubicación calculada
                facturas.StartPosition = FormStartPosition.Manual;
                facturas.Location = new Point(x, y);
                facturas.ShowDialog();
                if (string.IsNullOrEmpty(facturas.folio)) return;
                TxtFolio.Text = facturas.folio;
            };
            if (Auth.User.current_suscription.status != "A")
            {
                MessageBox.Show("Tu licencia no se encuentra activa.");
                return;
            }
            TxtFolio.Enabled = false;
            BtnSearch.Enabled = false;
            PanelCartaPorte.Visible = true;
            LblCartaPorte.Visible = true;
            using (FbConnection connection = new FbConnection(connectionString))
            {
                connection.Open();
                try
                {
                    factura = null;

                    string sql = @"SELECT 
	                        dv.FOLIO,
	                        dv.DOCTO_VE_ID,
	                        dv.FECHA, 
	                        m.NOMBRE AS MONEDA,
	                        c.CLIENTE_ID AS NO_CLIENTE,
	                        c.NOMBRE AS CLIENTE,
	                        a.NOMBRE AS ALMACEN,
	                        dv.ORDEN_COMPRA,
	                        da.DATOS 
                        FROM DOCTOS_VE dv
                        LEFT JOIN CLIENTES c ON c.CLIENTE_ID = dv.CLIENTE_ID
                        LEFT JOIN MONEDAS m ON m.MONEDA_ID = dv.MONEDA_ID 
                        LEFT JOIN ALMACENES a ON a.ALMACEN_ID = dv.ALMACEN_ID 
                        LEFT JOIN DATOS_ADICIONALES da ON da.ELEM_ID = dv.DOCTO_VE_ID 
                        WHERE dv.FOLIO = @Folio AND dv.TIPO_DOCTO = 'F';";
                    using (FbCommand command = new FbCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("Folio", GetFolio(TxtFolio.Text));
                        using (FbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                factura = new Globals.Factura(
                                    reader.GetInt64(reader.GetOrdinal("DOCTO_VE_ID")),
                                    reader.GetString(reader.GetOrdinal("FECHA")),
                                    reader.GetString(reader.GetOrdinal("MONEDA")),
                                    reader.GetString(reader.GetOrdinal("NO_CLIENTE")),
                                    reader.GetString(reader.GetOrdinal("CLIENTE")),
                                    reader.GetString(reader.GetOrdinal("ALMACEN")),
                                    reader.GetString(reader.GetOrdinal("ORDEN_COMPRA"))
                                );
                                BtnClear1.Visible = true;
                            }
                            if (factura != null)
                            {
                                TxtClienteNo.Text = factura.NO_CLIENTE;
                                TxtCliente.Text = factura.CLIENTE;
                                TxtAlmacen.Text = factura.ALMACEN;
                                TxtFecha.Text = factura.FECHA;
                                TxtMoneda.Text = factura.MONEDA;
                                TxtOrdenCompra.Text = factura.ORDEN_COMPRA;

                                ObtenerDatosAdicionales(factura.DOCTO_VE_ID);
                            }
                            else
                            {
                                TxtClienteNo.Text = "";
                                TxtAlmacen.Text = "";
                                TxtFecha.Text = "";
                                TxtMoneda.Text = "";
                                TxtOrdenCompra.Text = "";
                                TxtCliente.Text = "";
                                TxtFolio.Enabled = true;
                                BtnSearch.Enabled = true;
                                MessageBox.Show("No se encontro ninguna factura con el folio " + TxtFolio.Text);
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private string GetFolio(string Folio)
        {
            return Folio.Substring(0, 2) + Folio.Substring(2).PadLeft(7, '0');
        }

        public void ObtenerDatosAdicionales(long DOCTO_VE_ID)
        {
            using (FbConnection connection = new FbConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string sql = @"SELECT da.TIPO_REG, da.DATOS FROM DATOS_ADICIONALES da WHERE da.ELEM_ID = @DOCTO_VE_ID AND da.NOM_TABLA = 'DOCTOS_VE'";
                    using (FbCommand command = new FbCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("DOCTO_VE_ID", DOCTO_VE_ID);
                        using (FbDataReader reader = command.ExecuteReader())
                        {
                            
                            while (reader.Read())
                            {
                                string TIPO_REG = reader.GetString(reader.GetOrdinal("TIPO_REG"));
                                if (TIPO_REG == "7")
                                {
                                    factura.XML = reader.GetString(reader.GetOrdinal("DATOS"));
                                    TxtXml.Text = factura.XML;
                                    //GeneradorDeFormulario.Generar(PanelCartaPorte, factura.XML, 10, 10);
                                }
                                else if (TIPO_REG == "8")
                                {
                                    factura.DATO2 = reader.GetString(reader.GetOrdinal("DATOS"));
                                }
                            }
                            if (string.IsNullOrEmpty(factura.XML) || string.IsNullOrEmpty(factura.DATO2))
                            {
                                LblError1.Text = "Esta factura no tiene complemento de carta porte.";
                                LblError1.Visible = true;
                                return;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            BuscarFactura();
        }

        private void BtnSearch2_Click(object sender, EventArgs e)
        {
            BuscarFactura2();
        }

        public void BuscarFactura2()
        {
            if (string.IsNullOrEmpty(TxtFolio2.Text))
            {
                Facturas facturas = new Facturas(connectionString, "Seleccione la factura destino que no este certificada.", 2);
                // Calcular la ubicación para centrar el formulario de Facturas con respecto al formulario principal
                int x = this.Location.X + (this.Width - facturas.Width) / 2;
                int y = this.Location.Y + (this.Height - facturas.Height) / 2;

                // Establecer la posición inicial del formulario de Facturas como la ubicación calculada
                facturas.StartPosition = FormStartPosition.Manual;
                facturas.Location = new Point(x, y);
                facturas.ShowDialog();
                if (string.IsNullOrEmpty(facturas.folio)) return;
                TxtFolio2.Text = facturas.folio;
            };
            Globals.CheckStatusSuscription();
            if (Auth.User.current_suscription.status != "A")
            {
                MessageBox.Show("Tu licencia no se encuentra activa.");
                return;
            }
            using (FbConnection connection = new FbConnection(connectionString))
            {
                connection.Open();
                try
                {
                    factura2 = null;

                    string sql = @"SELECT 
                            da.DATOS_ADICIONALES_ID,
                            dv.CFDI_CERTIFICADO,
	                        dv.FOLIO,
	                        dv.DOCTO_VE_ID,
	                        dv.FECHA,
	                        m.NOMBRE AS MONEDA,
	                        c.CLIENTE_ID AS NO_CLIENTE,
	                        c.NOMBRE AS CLIENTE,
	                        a.NOMBRE AS ALMACEN,
	                        dv.ORDEN_COMPRA,
	                        da.DATOS 
                        FROM DOCTOS_VE dv
                        LEFT JOIN CLIENTES c ON c.CLIENTE_ID = dv.CLIENTE_ID
                        LEFT JOIN MONEDAS m ON m.MONEDA_ID = dv.MONEDA_ID 
                        LEFT JOIN ALMACENES a ON a.ALMACEN_ID = dv.ALMACEN_ID 
                        LEFT JOIN DATOS_ADICIONALES da ON da.ELEM_ID = dv.DOCTO_VE_ID 
                        WHERE dv.FOLIO = @Folio AND dv.TIPO_DOCTO = 'F';";
                    using (FbCommand command = new FbCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("Folio", GetFolio(TxtFolio2.Text));
                        using (FbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                factura2 = new Globals.Factura(
                                    reader.GetInt64(reader.GetOrdinal("DOCTO_VE_ID")),
                                    reader.GetString(reader.GetOrdinal("FECHA")),
                                    reader.GetString(reader.GetOrdinal("MONEDA")),
                                    reader.GetString(reader.GetOrdinal("NO_CLIENTE")),
                                    reader.GetString(reader.GetOrdinal("CLIENTE")),
                                    reader.GetString(reader.GetOrdinal("ALMACEN")),
                                    reader.GetString(reader.GetOrdinal("ORDEN_COMPRA"))
                                );
                                factura2.CFDI_CERTIFICADO = reader.GetString(reader.GetOrdinal("CFDI_CERTIFICADO"));
                                if(factura2.CFDI_CERTIFICADO == "S")
                                {
                                    LblError2.Text = "Factura certificada";
                                    LblError2.Visible = true;
                                }
                                TxtFolio2.Enabled = false;
                                BtnSearch2.Enabled = false;
                                BtnClear2.Visible = true;
                            }
                            if (factura2 != null)
                            {
                                TxtClienteNo2.Text = factura2.NO_CLIENTE;
                                TxtCliente2.Text = factura2.CLIENTE;
                                TxtAlmacen2.Text = factura2.ALMACEN;
                                TxtFecha2.Text = factura2.FECHA;
                                TxtMoneda2.Text = factura2.MONEDA;
                                TxtOrdenCompra2.Text = factura2.ORDEN_COMPRA;
                            }
                            else
                            {
                                TxtClienteNo2.Text = "";
                                TxtAlmacen2.Text = "";
                                TxtFecha2.Text = "";
                                TxtMoneda2.Text = "";
                                TxtOrdenCompra2.Text = "";
                                TxtCliente2.Text = "";
                                TxtFolio2.Enabled = true;
                                BtnSearch2.Enabled = true;
                                MessageBox.Show("No se encontro ninguna factura con el folio " + TxtFolio.Text);
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void TxtFolio2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarFactura2();
            }
        }

        private void CopyAndSaveXml()
        {
            string query = @" INSERT INTO DATOS_ADICIONALES
                (DATOS_ADICIONALES_ID, NOM_TABLA, ELEM_ID, TIPO_REG, CLAVE, DATOS)
                VALUES(-1, 'DOCTOS_VE', @DOCTO_VE_ID, '7', NULL, @DATOS);";

            using (FbConnection connection = new FbConnection(connectionString))
            {
                connection.Open();
                using (FbCommand command = new FbCommand(query, connection))
                {
                    // Asegúrate de reemplazar "@DOCTO_VE_ID" con el valor adecuado
                    command.Parameters.AddWithValue("DOCTO_VE_ID", factura2.DOCTO_VE_ID);
                    command.Parameters.AddWithValue("DATOS", factura.XML);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }

            query = @" INSERT INTO DATOS_ADICIONALES
                (DATOS_ADICIONALES_ID, NOM_TABLA, ELEM_ID, TIPO_REG, CLAVE, DATOS)
                VALUES(-1, 'DOCTOS_VE', @DOCTO_VE_ID, '8', NULL, @DATOS);";

            using (FbConnection connection = new FbConnection(connectionString))
            {
                connection.Open();
                using (FbCommand command = new FbCommand(query, connection))
                {
                    // Asegúrate de reemplazar "@DOCTO_VE_ID" con el valor adecuado
                    command.Parameters.AddWithValue("DOCTO_VE_ID", factura2.DOCTO_VE_ID);
                    command.Parameters.AddWithValue("DATOS", factura.DATO2);
                    int rowsAffected = command.ExecuteNonQuery();
                    if(rowsAffected > 0)
                    {
                        MessageBox.Show("Complemento copiado correctamente.");
                        Clear1();
                        Clear2();
                        TxtFolio.Text = String.Empty;
                        TxtFolio2.Text = String.Empty;
                        TxtFolio.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error al copiar el complemento.");
                    }
                }
            }

        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (factura == null || factura2 == null)
            {
                MessageBox.Show("Ingresa las dos facturas");
                return;
            }
            if(string.IsNullOrEmpty(factura.XML) || string.IsNullOrEmpty(factura.DATO2))
            {
                MessageBox.Show("La factura " + TxtFolio.Text + " no tiene complemento de carta porte que se pueda copiar");
                return;
            }
            if(factura2.CFDI_CERTIFICADO == "S")
            {
                MessageBox.Show("La factura " + TxtFolio2.Text + " ya esta certificada, no se puede copiar elementos a facturas certificadas.");
                return;
            }
            if (Auth.User.current_suscription.status != "A")
            {
                MessageBox.Show("Tu licencia no se encuentra activa.");
                return;
            }
            if (CheckIfExistCCP())
            {
                DialogResult result = MessageBox.Show("La factura con folio " + TxtFolio2.Text + " ya tiene un complemento de carta porte, ¿desea reemplazarlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DeleteCCP();
                }
                else
                {
                    return;
                }
            }
            CopyAndSaveXml();
            
        }

        private void DeleteCCP()
        {
            try
            {
                using (FbConnection connection = new FbConnection(connectionString))
                {
                    connection.Open();
                    string sql = @"DELETE FROM DATOS_ADICIONALES DA WHERE DA.ELEM_ID = @ELEM_ID AND DA.NOM_TABLA = 'DOCTOS_VE';";

                    using (FbCommand command = new FbCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ELEM_ID", factura2.DOCTO_VE_ID);
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

        private Boolean CheckIfExistCCP()
        {
            using (FbConnection connection = new FbConnection(connectionString))
            {
                Boolean result = false;
                connection.Open();
                try
                {
                    string sql = @"SELECT * FROM DATOS_ADICIONALES da WHERE da.ELEM_ID = @ELEM_ID";
                    using (FbCommand command = new FbCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("ELEM_ID", factura2.DOCTO_VE_ID);
                        using (FbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                result = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    result = false;
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return result;
            }
        }

        private void App_Load(object sender, EventArgs e)
        {
            SetLoadData();
        }

        private void SetLoadData()
        {
            if( Auth.User.current_suscription == null )
            {
                Properties.Settings.Default.Token = null;
                Properties.Settings.Default.Save();
                MessageBox.Show("Esta cuenta no cuenta con ninguna suscripcion, ponte en contacto con b+software para corregir este problema");
                this.Hide();
                Forms.Login login = new Forms.Login();
                login.ShowDialog();
                this.Close();
                return;
            }
            if (Auth.User.current_suscription.status == "N")
            {
                LblSuscriptionStatus.Text = "Suscripción pendiente de activar";
                LblSuscriptionStatus.BackColor = Color.DarkOrange;
            }
            else if (Auth.User.current_suscription.status == "I")
            {
                LblSuscriptionStatus.Text = "Suscripción vencida.";
                LblSuscriptionStatus.ForeColor = Color.White;
                LblSuscriptionStatus.BackColor = Color.DarkRed;
            }
            else
            {
                LblSuscriptionStatus.Text = "Tu suscripcion vence el dia " + Auth.User.current_suscription.end_date;
                LblSuscriptionStatus.ForeColor = Color.White;
                LblSuscriptionStatus.BackColor = Color.DarkGreen;
            }
            LblSuscriptionStatus.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            LblSuscriptionStatus.Top = PanelCompany.Height / 2 - LblSuscriptionStatus.Height / 2;
            LblSuscriptionStatus.Left = PanelCompany.Width - LblSuscriptionStatus.Width - 10;
            LblCompany.Text = Auth.User.company;
            LblSuscription.Text = "Suscripción " + Auth.User.current_suscription.suscription.name;

            LblDatabase.Text = Properties.Settings.Default.DataSource + "/" + Properties.Settings.Default.Database;
            LblDatabase.Left = PanelFactura.Right - LblDatabase.Width;
            string Username = Properties.Settings.Default.Username;
            string Password = Properties.Settings.Default.Password;
            string Database = Properties.Settings.Default.Database;
            string DataSource = Properties.Settings.Default.DataSource;
            connectionString = $"User={Username};Password={Password};Database={Database};DataSource={DataSource};Port=3050;Dialect=3;Charset=UTF8;";
        }

        private void BtnClear1_Click(object sender, EventArgs e)
        {
            Clear1();
            TxtFolio.Focus();

        }
        private void Clear1()
        {
            LblError1.Visible = false;
            factura = null;
            TxtClienteNo.Text = "";
            TxtAlmacen.Text = "";
            TxtFecha.Text = "";
            TxtMoneda.Text = "";
            TxtOrdenCompra.Text = "";
            TxtCliente.Text = "";
            TxtFolio.Enabled = true;
            BtnSearch.Enabled = true;
            BtnClear1.Visible = false;
            TxtXml.Text = string.Empty;
            TxtFolio.Text = string.Empty;
        }

        private void BtnClear2_Click(object sender, EventArgs e)
        {
            Clear2();
            TxtFolio2.Focus();

        }

        private void Clear2()
        {
            factura2 = null;
            TxtClienteNo2.Text = "";
            TxtAlmacen2.Text = "";
            TxtFecha2.Text = "";
            TxtMoneda2.Text = "";
            TxtOrdenCompra2.Text = "";
            TxtCliente2.Text = "";
            TxtFolio2.Enabled = true;
            BtnSearch2.Enabled = true;
            BtnClear2.Visible = false;
            LblError2.Visible = false;
            TxtFolio2.Text = string.Empty;
        }

        private void PanelFactura_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cerrarAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient(Globals.BackUrl);
                var request = new RestRequest("/logout");
                request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.Token);
                var response = client.Post(request);
                if (response.IsSuccessStatusCode)
                {
                    Properties.Settings.Default.Token = null;
                    Properties.Settings.Default.Save();
                    this.Hide();
                    Forms.Login login = new Forms.Login();
                    login.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(response.Content);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
