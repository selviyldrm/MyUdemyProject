using HotelProject.BusinessLAaer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public ActionResult TestimonialList()
        {
            var values = _testimonialService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public ActionResult AddTestimonial(Testimonial testimonial)
        {
            _testimonialService.TInsert(testimonial);
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteTestimonial(int id)
        {
            var values = _testimonialService.GetByID(id);
            _testimonialService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public ActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _testimonialService.TUpdate(testimonial);
            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult GetTestimonial(int id)
        {
            var values = _testimonialService.GetByID(id);
            return Ok(values);
        }
    }
}
