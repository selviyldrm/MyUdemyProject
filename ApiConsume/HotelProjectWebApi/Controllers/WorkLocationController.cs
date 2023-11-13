using HotelProject.BusinessLAaer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkLocationController : ControllerBase
    {
        private readonly IWorkLocationService _workLocationService;

        public WorkLocationController(IWorkLocationService workLocationService)
        {
            _workLocationService = workLocationService;
        }

        [HttpGet]
        public ActionResult WorkLocationList()
        {
            var values = _workLocationService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public ActionResult AddWorkLocation(WorkLocation workLocation)
        {
            _workLocationService.TInsert(workLocation);
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteWorkLocation(int id)
        {
            var values = _workLocationService.GetByID(id);
            _workLocationService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public ActionResult UpdateWorkLocation(WorkLocation workLocation)
        {
            _workLocationService.TUpdate(workLocation);
            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult GetWorkLocation(int id)
        {
            var values = _workLocationService.GetByID(id);
            return Ok(values);
        }
    }
}