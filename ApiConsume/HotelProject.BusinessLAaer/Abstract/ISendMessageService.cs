﻿using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLAaer.Abstract
{
    public interface ISendMessageService:IGenericService<SendMessage>
    {
        public int TSendMessageCount();
    }
}
