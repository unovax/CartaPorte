using CartaPorte.Forms;
using CartaPorte.Logica;
using CartaPorte.Properties;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static CartaPorte.Logica.Globals;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CartaPorte
{
    public partial class Connections : Form
    {
        public Connections()
        {
            InitializeComponent();
        }

        private void TxtDB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Username = TxtUsername.Text;
                Properties.Settings.Default.Password = TxtPassword.Text;
                string connectionString;
                if (Properties.Settings.Default.ConnType == "local")
                {
                    connectionString = $"User={TxtUsername.Text};Password={TxtPassword.Text};Database={TxtDB.Text};DataSource=localhost;Port=3050;Dialect=3;Charset=UTF8;";
                    Properties.Settings.Default.DataSource = "localhost";
                    Properties.Settings.Default.Database = TxtDB.Text;
                }
                else
                {
                    connectionString = $"User={TxtUsername.Text};Password={TxtPassword.Text};Database={TxtRemoteDB.Text};DataSource={TxtRemoteIP.Text};Port=3050;Dialect=3;Charset=UTF8;";
                    Properties.Settings.Default.DataSource = TxtRemoteIP.Text;
                    Properties.Settings.Default.Database = TxtRemoteDB.Text;
                }

                // Guarda los cambios en la configuración
                Properties.Settings.Default.Save();

                // Intenta conectarte a la base de datos
                using (FbConnection connection = new FbConnection(connectionString))
                {
                    connection.Open();
                    connection.Close();
                    this.Hide();
                    App app = new App();
                    int x = this.Location.X + (this.Width - app.Width) / 2;
                    int y = this.Location.Y + (this.Height - app.Height) / 2;
                    if(y < 0)
                    {
                        y = 10;
                    }
                    app.StartPosition = FormStartPosition.Manual;
                    app.Location = new Point(x, y);
                    app.ShowDialog();
                    this.Close();
                }
            }
            catch (FbException ex)
            {
                MessageBox.Show($"Error al intentar acceder al archivo de base de datos: {ex.Message}", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Connections_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            Globals.GetUserResponse getUserResponse = Globals.GetUser(Properties.Settings.Default.Token);
            if (getUserResponse.error) {
                this.Hide();
                Forms.Login login = new Forms.Login();
                login.ShowDialog();
                this.Close();
                return; 
            }
            if (Properties.Settings.Default.ConnType == "remote")
            {
                PanelRemote.Visible = true;
                PanelLocal.Visible = false;
                RBtnRemote.Checked = true;
                TxtRemoteDB.Text = Properties.Settings.Default.Database;
                TxtRemoteIP.Text = Properties.Settings.Default.DataSource;
            }
            else
            {
                PanelLocal.Visible = true;
                PanelLocal.Visible = false;
                RBtnLocal.Checked = true;
                TxtDB.Text = Properties.Settings.Default.Database;
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.Username))
            {
                TxtUsername.Text = "SYSDBA";
            }
            else
            {
                TxtUsername.Text = Properties.Settings.Default.Username;
            }if (string.IsNullOrEmpty(Properties.Settings.Default.Password))
            {
                TxtPassword.Text = "masterkey";
            }
            else
            {
                TxtPassword.Text = Properties.Settings.Default.Password;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileExplorer = new OpenFileDialog();

            // Filtra los archivos por extensión .fdb
            FileExplorer.Filter = "Archivos de Firebird (*.fdb)|*.fdb|Todos los archivos (*.*)|*.*";
            FileExplorer.FilterIndex = 1;
            FileExplorer.RestoreDirectory = true;

            if (FileExplorer.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Obtiene el nombre del archivo seleccionado
                    string fileName = FileExplorer.FileName;

                    // Guarda el nombre del archivo en el TextBox
                    TxtDB.Text = fileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: No se pudo abrir el archivo. Error original: " + ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtRemoteDB_TextChanged(object sender, EventArgs e)
        {

        }

        private void RBtnLocal_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ConnType = "local";
            Properties.Settings.Default.Save();
            PanelLocal.Visible = true;
            PanelRemote.Visible = false;
        }

        private void RBtnRemote_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ConnType = "remote";
            Properties.Settings.Default.Save();
            PanelRemote.Visible = true;
            PanelLocal.Visible = false;
        }
    }
}
