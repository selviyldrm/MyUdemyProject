using HotelProject.BusinessLAaer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public ActionResult ServiceList()
        {
            var values = _serviceService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public ActionResult AddService(Service service)
        {
            _serviceService.TInsert(service);
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteService(int id)
        {
            var values = _serviceService.GetByID(id);
            _serviceService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public ActionResult UpdateService(Service service)
        {
            _serviceService.TUpdate(service);
            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult GetService(int id)
        {
            var values = _serviceService.GetByID(id);
            return Ok(values);
        }
    }
}
