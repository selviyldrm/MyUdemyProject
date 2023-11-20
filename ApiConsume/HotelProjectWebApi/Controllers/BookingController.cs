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
        public IActionResult BookingList()
        {
            var values = _bookingService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.TInsert(booking);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.GetByID(id);
            _bookingService.TDelete(values);
            return Ok();
        }
        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingService.GetByID(id);
            return Ok(values);
        }

        [HttpGet("Last6Booking")]
        public IActionResult Last6Booking()
        {
            var values = _bookingService.TLast6Booking();
            return Ok(values);
        }

        [HttpGet("BookingApproved")]
        public IActionResult BookingApproved(int id)
        {
            _bookingService.TBookingStatusChangeApproved3(id);
            return Ok();
        }

        [HttpGet("BookingCancel")]
        public IActionResult BookingCancel(int id)
        {
            _bookingService.TBookingStatusChangeCancel(id);
            return Ok();
        }
        [HttpGet("BookingWait")]
        public IActionResult BookingWait(int id)
        {
            _bookingService.TBookingStatusChangeWait(id);
            return Ok();
        }
    }
}
