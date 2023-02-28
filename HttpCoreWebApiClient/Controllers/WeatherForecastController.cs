using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpCoreWebApiClient.Controllers
{
 //   [ApiKey]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       private readonly ILogger<WeatherForecastController> _logger;
        //   private static HttpClient _httpClient;
        //   private readonly IHttpClientFactory _httpClientFactory;
        private readonly IweatherService _weatherService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IweatherService weatherService)
        {
            _logger = logger;
            _weatherService = weatherService;
        }
        //public WeatherForecastController(ILogger<WeatherForecastController> logger, IHttpClientFactory httpClientFactory)
        //{
        //    _logger = logger;
        //    _httpClientFactory = httpClientFactory;
        //}

        //static WeatherForecastController()
        //{
        //    _httpClient = new HttpClient();
        //}


        [HttpGet]
        public async Task<string> Get(string cityname)
        {

            //  var URL = $"http://api.weatherapi.com/v1/current.json?key=9dfa6831a16c41abbb1222131232502&q={cityname}"; var URL = $"http://api.weatherapi.com/v1/current.json?key=9dfa6831a16c41abbb1222131232502&q={cityname}";

            ////1.called one process , not serveral process daemon
            //using (var httpClient = new HttpClient())
            //{
            //var reponse = await httpClient.GetAsync(URL);
            //return await reponse.Content.ReadAsStringAsync();
            //} ;

            ////2.called singleton with construct for one process
            //    var reponse = await _httpClient.GetAsync(URL);
            //    return await response.Content.ReadAsStringAsync();

            //3. Factory definition to get one proecess
            // add services.AddHttpClient(); in Startup.cs
            //var httpClient = _httpClientFactory.CreateClient();
            //var response = await httpClient.GetAsync(URL);
            //return await response.Content.ReadAsStringAsync();

            //4.weather name defined in startup.cs to start
            //var httpClient = _httpClientFactory.CreateClient("weather");
            //var URL = $"?key=9dfa6831a16c41abbb1222131232502&q={cityname}";
            //var response = await httpClient.GetAsync(URL);
            //return await response.Content.ReadAsStringAsync();

            //5. Create weatherServicw.cs and update the controller, startup.cs
            return await _weatherService.Get(cityname);

        }

        //  }
        //[ApiKey]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
    }
}
