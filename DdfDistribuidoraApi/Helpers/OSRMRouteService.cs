using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DdfDistribuidoraApi.Helpers
{
    public class OSRMRouteService : IOSRMRouteService
    {
        private readonly HttpClient httpClient;

        public OSRMRouteService()
        {
            HttpClientHandler clientHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }
            };

            // Pass the handler to httpclient(from you are calling api)
            httpClient = new HttpClient(clientHandler);
        }

        public async Task<DirectionResponse> GetDirectionResponseAsync(string latitudOrigen, string longitudOrigen, string latitudDestino, string longitudDestino)
        {
            try
            {

                string url = $"https://router.project-osrm.org/route/v1/driving/{longitudOrigen},{latitudOrigen};{longitudDestino},{latitudDestino}?overview=full&geometries=polyline&steps=true";

                var response = await httpClient.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var result = JsonConvert.DeserializeObject<DirectionResponse>(json);

                    if (result.Code.Equals("Ok"))
                    {
                        return result;
                    }

                    return null;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException.Message);
            }

            return null;

        }

    }
}
    