using HotelProject.BusinessLAaer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public ActionResult StaffList()
        {
            var values=_staffService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public ActionResult AddStaff(Staff staff)
        {
            _staffService.TInsert(staff);
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteStaff(int id)
        {
           var values= _staffService.GetByID(id);
            _staffService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public ActionResult UpdateStaff(Staff staff)
        {
            _staffService.TUpdate(staff);
            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult GetStaff(int id)
        {
            var values = _staffService.GetByID(id);
            return Ok(values);
        }
    }
}