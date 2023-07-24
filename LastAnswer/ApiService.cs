using LastAnswer.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace LastAnswer
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://gorest.co.in/public/v2/") // istekte bulunacağımız adres
            };
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); //we are expecting data in json format from the api.
        }
        public async Task<List<ResultGorestDto>> GetDatas()
        {
            var response = await _httpClient.GetAsync("users");// We need Get attribute
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject<List<ResultGorestDto>>(responseBody); // Deserializing the the Json type.

            return users; 
        }
      
    }

    
}

