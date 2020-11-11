using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace Assignment.Models
{
    public class ClientModel
    {
        
        
            public static ClientModel clientModel;
            private ClientModel()
            {}

            public static ClientModel getInstance()
            {
                if (clientModel == null)
                {
                    clientModel = new ClientModel();
                }

                return clientModel;
            }
            public string GetAdultJson()
            {
                Task<string> data = GetDataAsync();
                string result = data.GetAwaiter().GetResult();
                return result;
            }
            public void addAdult(Adult adult)
            {
                PostData(adult);
            }
            static async Task<string> GetDataAsync()
        {
            var httpClientHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, certificate2, arg3, arg4) => true
            };
            HttpClient client = new HttpClient(httpClientHandler);
            
            string s = await client.GetStringAsync("https://localhost:5001/Adult");
            return s;
        }
        static async Task<string> PostData(Adult adult)
        {
            var httpClientHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, certificate2, arg3, arg4) => true
            };
            HttpClient client = new HttpClient(httpClientHandler);
            string adultSerialized = JsonSerializer.Serialize(adult);
            StringContent content = new StringContent(
                adultSerialized,Encoding.UTF8,
                "application/json"
                );
            HttpResponseMessage response = await client.PutAsync("https://localhost:5001/Adult", content);
            return response.ToString();
        }
        
    }
}