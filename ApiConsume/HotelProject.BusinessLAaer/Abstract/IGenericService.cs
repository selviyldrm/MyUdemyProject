﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLAaer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> GetList();
        T GetByID(int id);
    }
}
