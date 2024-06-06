using Ecomm.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ecomm.Models.ActionModel;

namespace Ecomm.Logic
{
    public static class Api
    {
        public class ApiResponse
        {
            public string message { get; set; }
            public Boolean error { get; set; }

            public ApiResponse() { 
                this.message = "";
                this.error = false;
            }



        }
        public static ApiResponse SendContacts(List<ContactModel.Contact> contacts)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var client = new RestClient(Globals.BackUrl);
                var request = new RestRequest("contacts");
                
                request.AddHeader("Authorization", "Bearer " + Globals.GetProp("token"));
                request.AddHeader("Content-Type", "application/json");

                var jsonBody = JsonConvert.SerializeObject(new { contacts = contacts });
                request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);

                RestResponse rest_response = client.Execute(request, Method.Post);
                apiResponse = JsonConvert.DeserializeObject<ApiResponse>(rest_response.Content);
            }
            catch (Exception ex)
            {
                apiResponse.message = ex.Message;
                apiResponse.error = true;
            }
            return apiResponse;
        }

        public static ApiResponse SendProducts(List<ProductModel.Product> products)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                var client = new RestClient(Globals.BackUrl);
                var request = new RestRequest("syncProducts");

                request.AddHeader("Authorization", "Bearer " + Globals.GetProp("token"));
                request.AddHeader("Content-Type", "application/json");

                var jsonBody = JsonConvert.SerializeObject(new { products = products });
                request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);

                RestResponse rest_response = client.Execute(request, Method.Post);
                apiResponse = JsonConvert.DeserializeObject<ApiResponse>(rest_response.Content);
            }
            catch(Exception ex)
            {
                apiResponse.error = true;
            }
            return apiResponse;
        }
    }
}
