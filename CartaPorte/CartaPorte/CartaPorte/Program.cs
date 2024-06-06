using CartaPorte.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartaPorte
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Properties.Settings.Default.Reset();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (string.IsNullOrEmpty(Properties.Settings.Default.Token))
            {
                Application.Run(new Register());
            }
            else
            {
                Application.Run(new Connections());
            }

        }
    }
}
