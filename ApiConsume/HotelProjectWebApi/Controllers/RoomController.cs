using HotelProject.BusinessLAaer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public ActionResult RoomList()
        {
            var values = _roomService.GetList();
            return Ok(values);
        } 
        [HttpPost]
        public ActionResult AddRoom(Room room)
        {
            _roomService.TInsert(room);
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteRoom(int id)
        {
            var values = _roomService.GetByID(id);
            _roomService.TDelete(values);
            return Ok();
        } 
        [HttpPut]
        public ActionResult UpdateRoom(Room room)
        {
            _roomService.TUpdate(room);
            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult GetRoom(int id)
        {
            var values= _roomService.GetByID(id);
            return Ok(values);
        }
    }
}
