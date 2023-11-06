﻿using HotelProject.BusinessLAaer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLAaer.Concrete
{
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly IMessageCategoryDal _messageCategoryDal;

        public MessageCategoryManager(IMessageCategoryDal messageCategoryDal)
        {
            _messageCategoryDal = messageCategoryDal;
        }

        public MessageCategory GetByID(int id)
        {
           return _messageCategoryDal.GetByID(id);
        }

        public List<MessageCategory> GetList()
        {
            return _messageCategoryDal.GetList();
        }

        public void TDelete(MessageCategory t)
        {
            _messageCategoryDal.Delete(t);
        }

        public void TInsert(MessageCategory t)
        {
            _messageCategoryDal.Insert(t);
        }

        public void TUpdate(MessageCategory t)
        {
            _messageCategoryDal.Update(t);
        }
    }
}
