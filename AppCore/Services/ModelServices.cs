using AppCore.Interfaces;
using Domain.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
   public   abstract class ModelServices<T>: IModelservices<T>
    {
        private IModel<T> Model;
        protected ModelServices(IModel<T> model)
        {
            this.Model = model;
        }
        public void Add(T t)
        {
            Model.Add(t);
        }

        public void Delete(T t)
        {
            Model.Delete(t);
        }

        public bool Delete(int t)
        {
            throw new NotImplementedException();
        }

        public List<T> read()
        {
            return Model.read();
        }
    }
}


