using HotelProject.BusinessLAaer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public ActionResult AboutList()
        {
            var values = _aboutService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public ActionResult AddAbout(About about)
        {
            _aboutService.TInsert(about);
            return Ok();
        }
        [HttpDelete]
        public ActionResult DeleteAbout(int id)
        {
            var values = _aboutService.GetByID(id);
            _aboutService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public ActionResult UpdateAbout(About about)
        {
            _aboutService.TUpdate(about);
            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult GetAbout(int id)
        {
            var values = _aboutService.GetByID(id);
            return Ok(values);
        }
    }
}
