using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Diagnostics;
namespace Printers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadInstalledPrinters();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadInstalledPrinters()
        {
            Boolean PrinterExist = false;
            // Obtiene la colección de impresoras instaladas
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                if(printer == "Tickets Agapito Caja3")
                {
                    PrinterExist = true;
                }
            }
            if (!PrinterExist)
            {
                InstallPrinter();
            }
        }

        private void InstallPrinter()
        {
            try
            {
                // Nombre del puerto, nombre del controlador, nombre compartido de la impresora y nombre del archivo .inf del controlador
                string printerPort = "USB1";
                string printerDriverName = "HP Universal Printing PCL 6";
                string printerShareName = "Tickets Agapito Caja1";
                string infPath = @"C:\Path\To\Driver\hpud.inf";

                // Comando para agregar la impresora
                string command = $"/ia /m \"{printerDriverName}\" /f \"{infPath}\"";

                // Ejecutar el comando
                Process process = new Process();
                process.StartInfo.FileName = "rundll32.exe";
                process.StartInfo.Arguments = $"printui.dll,PrintUIEntry {command}";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.Start();

                // Leer la salida del comando
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                // Mostrar el resultado
                MessageBox.Show($"Output: {output}\nError: {error}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
