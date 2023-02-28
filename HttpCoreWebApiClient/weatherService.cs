using System.Net.Http;
using System.Threading.Tasks;

namespace HttpCoreWebApiClient
{
    
        public interface IweatherService
        {
            Task<string> Get(string cityname);
        }

        public class weatherService : IweatherService
        {
            private HttpClient _httpClient;

            public weatherService(HttpClient httpClient)
            {
                _httpClient = httpClient;
            }

            public async Task<string> Get(string cityname)
            {
                var apiKey = "9dfa6831a16c41abbb1222131232502";
                string APIURL = $"?key={apiKey}&q={cityname}";
                var response = await _httpClient.GetAsync(APIURL);
                return await response.Content.ReadAsStringAsync();
            }
        }
    
}
