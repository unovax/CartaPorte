using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ecomm.Logic.Auth;

namespace Ecomm.Logic
{
    internal class Globals
    {
        public static string ConnString = "User="+ Properties.Settings.Default.DatabaseUsername +";Password="+ Properties.Settings.Default.DatabasePassword +";Database=" + Properties.Settings.Default.Database + ";DataSource="+ Properties.Settings.Default.Datasource +";Port="+ Properties.Settings.Default.DatabasePort +";";
        public static string BackUrl = "http://127.0.0.1:8000/api/";

        public static void CenterPanel(Panel MainPanel, Size ClientSize)
        {
            if (MainPanel != null)
            {
                MainPanel.Left = (ClientSize.Width - MainPanel.Width) / 2;
                MainPanel.Top = (ClientSize.Height - MainPanel.Height) / 2;
            }
        }

        public static void SetProp(string key, object value)
        {
            Properties.Settings.Default[key] = value;
            Properties.Settings.Default.Save();
        }

        public static string GetProp(string key)
        {
            return Properties.Settings.Default[key].ToString();
        }
    }
}
