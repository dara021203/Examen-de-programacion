using Clima;
using Domain.Entities;
using Domain.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Insfraestructure.aa
{
    class Httpopenweather : IHttpOpenWeather
    {
        public List<OpenWeatherCities> GetCities(byte[] bytes)
        {
            string jsonStr = Encoding.UTF8.GetString(bytes);
            return JsonConvert.DeserializeObject<List<OpenWeatherCities>>(jsonStr);
        }

        public string getimage(OpenWeather im)
        {
            string imageLocation = $"{apiweather.Image}{im.Weather[0].Icon}.png";
            return imageLocation;
        }

        public async Task<OpenWeather> getweather(string ciudad)
        {
            string url = $"{apiweather.ApiUrl}{ciudad}&units={apiweather.Units}&lang=sp&appid={apiweather.Token}";
            string jsonObject = string.Empty;
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    jsonObject = await httpClient.GetAsync(url).Result.Content.ReadAsStringAsync();
                }

                if (string.IsNullOrEmpty(jsonObject))
                {
                    throw new NullReferenceException("El objeto json no puede ser null.");
                }

                return Newtonsoft.Json.JsonConvert.DeserializeObject<OpenWeather>(jsonObject);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
