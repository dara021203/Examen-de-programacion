﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
   public  interface IModel<T>
    {
         void Add(T t);

        void Delete(T t); 
        bool Delete(int t);
        List<T> read();
      


    }
}
