using HotelProject.BusinessLAaer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService  _guestService;

        public GuestController(IGuestService guestService)
        {
            _guestService = guestService;
        }

        [HttpGet]
        public ActionResult GuestList()
        {
            var values = _guestService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public ActionResult AddGuest(Guest guest)
        {
            _guestService.TInsert(guest);
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteGuest(int id)
        {
            var values = _guestService.GetByID(id);
            _guestService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public ActionResult UpdateGuest(Guest guest)
        {
            _guestService.TUpdate(guest);
            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult GetGuest(int id)
        {
            var values = _guestService.GetByID(id);
            return Ok(values);
        }
    }
}
