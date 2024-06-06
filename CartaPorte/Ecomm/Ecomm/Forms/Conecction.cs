using Ecomm.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecomm.Forms
{
    public partial class Conecction : Form
    {
        AppForm MainForm;
        public Conecction(AppForm MF)
        {
            InitializeComponent();
            MainForm = MF;
        }

        private void RBtnRemote_CheckedChanged(object sender, EventArgs e)
        {
            InputDatasource.Enabled = true;
            InputDatasource.Text = string.Empty;
        }

        private void RbtnLocal_CheckedChanged(object sender, EventArgs e)
        {
            InputDatasource.Enabled = false;
            InputDatasource.Text = "localhost";
        }

        private void Conecction_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Datasource == "localhost" || string.IsNullOrEmpty(Properties.Settings.Default.Datasource))
            {
                RbtnLocal.Checked = true;
                InputDatasource.Enabled = false;
                InputDatasource.Text = "Localhost";
            }
            else
            {
                RBtnRemote.Checked = true;
                InputDatasource.Text = Properties.Settings.Default.Datasource;
            }
            InputDatabase.Text = Properties.Settings.Default.Database;
            InputPassword.Text = Properties.Settings.Default.DatabasePassword;
            InputPort.Text = Properties.Settings.Default.DatabasePort;
            InputUsername.Text = Properties.Settings.Default.DatabaseUsername;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Datasource = InputDatasource.Text;
            Properties.Settings.Default.Database = InputDatabase.Text;
            Properties.Settings.Default.DatabasePassword = InputPassword.Text;
            Properties.Settings.Default.DatabaseUsername = InputUsername.Text;
            Properties.Settings.Default.DatabasePort = InputPort.Text;
            Properties.Settings.Default.Save();
            MainForm.LoadView(new Main());
        }

        private void Conecction_Resize(object sender, EventArgs e)
        {
            Globals.CenterPanel(MainPanel, this.ClientSize);
        }
    }
}
