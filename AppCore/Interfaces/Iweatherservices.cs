using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
    interface Iweatherservices : IModelservices<OpenWeather>
    {
        List<OpenWeather> findbycity(Expression<Func<OpenWeather, bool>> where);
    }
}
