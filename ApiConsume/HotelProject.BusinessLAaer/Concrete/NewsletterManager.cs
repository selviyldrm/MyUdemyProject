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
    public class NewsletterManager : INewsletterService
    {
        private readonly INewsletterDal _newsletterDal;

        public NewsletterManager(INewsletterDal newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }

        public Newsletter GetByID(int id)
        {
            return _newsletterDal.GetByID(id);
        }

        public List<Newsletter> GetList()
        {
            return _newsletterDal.GetList();
        }

        public void TDelete(Newsletter t)
        {
            _newsletterDal.Delete(t);
        }

        public void TInsert(Newsletter t)
        {
            _newsletterDal.Insert(t);
        }

        public void TUpdate(Newsletter t)
        {
            _newsletterDal.Update(t);
        }
    }
}
