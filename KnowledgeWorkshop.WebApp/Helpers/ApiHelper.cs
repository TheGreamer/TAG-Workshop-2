using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace KnowledgeWorkshop.WebApp.Helpers
{
    public static class ApiHelper
    {
        private static readonly string baseUrl = "https://localhost:7256/api/";

        public static async Task<List<T>> SendHttpGetRequest<T>(string url)
        {
            List<T> objects = new();

            using (HttpClient client = new())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string objectResponse = await response.Content.ReadAsStringAsync();
                    objects = JsonConvert.DeserializeObject<List<T>>(objectResponse);
                }

                return objects;
            }
        }
    }
}