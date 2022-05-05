using AppCore.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    class WeatherServices : ModelServices<OpenWeather>, Iweatherservices
    {
        IWeather weather;
        public WeatherServices(IWeather model) : base(model)
        {
            this.weather = model;
        }
        
        public List<OpenWeather> findbycity(Expression<Func<OpenWeather, bool>> where)
        {
            return weather.findbycity(where);
        }

      
    }
}
