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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public Testimonial GetByID(int id)
        {
            return _testimonialDal.GetByID(id);
        }

        public List<Testimonial> GetList()
        {
            return _testimonialDal.GetList();
        }

        public void TDelete(Testimonial t)
        {
            _testimonialDal.Delete(t);
        }

        public void TInsert(Testimonial t)
        {
           _testimonialDal.Insert(t);
        }

        public void TUpdate(Testimonial t)
        {
           _testimonialDal.Update(t);
        }
    }
}
