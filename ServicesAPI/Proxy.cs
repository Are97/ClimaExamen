using ClimaExamen.ModelsAPI;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaExamen.ServicesAPI
{
    class Proxy : IProxy
    {
        //b1e34d4d55487b41db609a28e5854900
        private RestClient _client;
        private string appid = "807e039bd90c3a40ac224637ffd000fb";
        private string metrics = "metric";
        public Proxy()
        {
            _client = new RestClient("http://api.openweathermap.org/data/2.5/");
        }
        public WeatherObject weather(string ciudad)
        {
            var request = new RestRequest($"weather?q={ciudad}&APPID={appid}&units={metrics}");
            var response = _client.Get<WeatherObject>(request);
            return response.Data;
        }
        public ForecastObject forecast(string ciudad)
        {
            var request = new RestRequest($"forecast?q={ciudad}&APPID={appid}&units={metrics}");
            var response = _client.Get<ForecastObject>(request);
            return response.Data;
        }

    }
}
