using Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IWeather:IModel<OpenWeather>
    {
        List<OpenWeather> findbycity(Expression<Func<OpenWeather, bool>> where);
    }
}
