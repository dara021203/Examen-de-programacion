using AppCore.Interfaces;
using Entities.Entities;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    class httpOpenservices : IhttpOpenservices
    {
        private IHttpOpenWeather openWeatherClient;
        public List<OpenWeatherCities> GetCities(byte[] bytes)
        {
            return openWeatherClient.GetCities(bytes);
        }

        public string getimage(OpenWeather im)
        {
            return openWeatherClient.getimage(im);
        }

        public Task<OpenWeather> getweather(string ciudad)
        {
            return openWeatherClient.getweather(ciudad);
        }
    }
   

   
}
