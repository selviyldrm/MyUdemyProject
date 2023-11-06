using HotelProject.BusinessLAaer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLAaer.Concrete
{
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDal _sendMessageDal;

        public SendMessageManager(ISendMessageDal sendMessageDal)
        {
            _sendMessageDal = sendMessageDal;
        }

        public SendMessage GetByID(int id)
        {
            return _sendMessageDal.GetByID(id);
        }

        public List<SendMessage> GetList()
        {
         return   _sendMessageDal.GetList();
        }

        public void TDelete(SendMessage t)
        {
            _sendMessageDal.Delete(t);
        }

        public void TInsert(SendMessage t)
        {
           _sendMessageDal.Insert(t);
        }

        public int TSendMessageCount()
        {
            return _sendMessageDal.SendMessageCount();
        }

        public void TUpdate(SendMessage t)
        {
            _sendMessageDal.Update(t);
        }
    }
}
