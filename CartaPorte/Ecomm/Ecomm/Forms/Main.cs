using Ecomm.Logic;
using Ecomm.Models;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Globals.GetProp("ActionEcommCreated")))
            {
                return;
            }
            ActionModel.Response ActionModelResponse = ActionModel.CheckIfActionExist();
            if (ActionModelResponse.Error)
            {
                MessageBox.Show(ActionModelResponse.Message, "Error al crear la accion de Ecomm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnContacts_Click(object sender, EventArgs e)
        {
            ContactModel.ContactResponse contactResponse = ContactModel.GetContacts();
            if (contactResponse.contacts.Count > 0) {
                Api.ApiResponse apiResponse = Api.SendContacts(contactResponse.contacts);
                MessageBox.Show(apiResponse.message, "Respuesta del servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);    
            }
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            ProductModel.ProductResponse productResponse = ProductModel.GetProducts();
            if(productResponse.products.Count > 0)
            {
                Api.ApiResponse apiResponse = Api.SendProducts(productResponse.products);
                MessageBox.Show(apiResponse.message, "Respuesta del servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
