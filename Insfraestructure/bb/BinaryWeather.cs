using Entities.Entities;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Insfraestructure.bb
{
    class BinaryWeather:IWeather
    {
        private RafContext raf;
        private const int Size = 220;

        public BinaryWeather()
        {
            this.raf = new RafContext("Clima", Size);
        }

        public List<OpenWeather> findbycity(Expression<Func<OpenWeather, bool>> where)
        {
            return raf.Find<OpenWeather>(where);
        }

        public void Add(OpenWeather t)
        {
            raf.Create<OpenWeather>(t);
           
        }

        public void Delete(OpenWeather t)
        {
            raf.Delete(t.Id);
        }

        public bool Delete(int t)
        {
            throw new NotImplementedException();
        }

        public List<OpenWeather> read()
        {
            return raf.GetAll<OpenWeather>();
        }
    }
}
