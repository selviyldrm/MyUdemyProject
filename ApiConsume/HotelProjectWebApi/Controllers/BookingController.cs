using HotelProject.BusinessLAaer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingBooking)
        {
            _bookingService = bookingBooking;
        }

        [HttpGet]
        public ActionResult BookingList()
        {
            var values = _bookingService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public ActionResult AddBooking(Booking booking)
        {
            _bookingService.TInsert(booking);
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteBooking(int id)
        {
            var values = _bookingService.GetByID(id);
            _bookingService.TDelete(values);
            return Ok();
        }
        [HttpPut("UpdateBooking")]
        public ActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult GetBooking(int id)
        {
            var values = _bookingService.GetByID(id);
            return Ok(values);
        }
        [HttpPut("aaa")]
        public IActionResult aaa(Booking booking)
        {
            _bookingService.TBookingStatusChangeApproved(booking);
            return Ok();
        } 
        [HttpPut("bbb")]
        public IActionResult bbb(int id)
        {
            _bookingService.TBookingStatusChangeApproved2(id);
            return Ok();
        }
    }
}
