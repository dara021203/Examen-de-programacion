using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
   public interface IModelservices<T>
    {
        void Add(T t);

        void Delete(T t);
        bool Delete(int t);
        List<T> read();

    }
}
