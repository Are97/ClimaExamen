using ClimaExamen.ModelsAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaExamen.ServicesAPI
{
    public interface IProxy
    {
        WeatherObject weather(string ciudad);
        ForecastObject forecast(string ciudad);
    }
}
