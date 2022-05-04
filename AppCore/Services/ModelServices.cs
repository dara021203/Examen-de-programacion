using AppCore.Interfaces;
using Entities.Interfaces;
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
        public void Add(T t)
        {
            Model.Add(t);
        }

        public void Delete(T t)
        {
            Model.Delete(t);
        }

       

        public List<T> read()
        {
            return Model.read();
        }
    }
}


