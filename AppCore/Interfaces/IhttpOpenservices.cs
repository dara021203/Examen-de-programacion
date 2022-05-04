using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
    public interface IhttpOpenservices
    {
        Task<OpenWeather> getweather(string ciudad);
        string getimage(OpenWeather im);
        List<OpenWeatherCities> GetCities(byte[] bytes);
    }
}
