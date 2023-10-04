using HotelProject.BusinessLAaer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsletterController : ControllerBase
    {
        private readonly INewsletterService _newsletterService;

        public NewsletterController(INewsletterService newsletterService)
        {
            _newsletterService = newsletterService;
        }
        [HttpGet]
        public ActionResult NewsletterList()
        {
            var values = _newsletterService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public ActionResult AddNewsletter(Newsletter newsletter)
        {
            _newsletterService.TInsert(newsletter);
            return Ok();
        }
        [HttpDelete]
        public ActionResult DeleteNewsletterm(int id)
        {
            var values = _newsletterService.GetByID(id);
            _newsletterService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public ActionResult UpdateNewsletter(Newsletter newsletter)
        {
            _newsletterService.TUpdate(newsletter);
            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult GetNewsletter(int id)
        {
            var values = _newsletterService.GetByID(id);
            return Ok(values);
        }
    }
}
