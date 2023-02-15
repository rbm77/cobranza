using Cobranza.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Cobranza.Web.Controllers.Students
{
    public class ZonesController : Controller
    {
        private readonly IZoneService _zoneService;

        public ZonesController(IZoneService zoneService)
        {
            _zoneService = zoneService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("api/{controller}")]
        public async Task<IActionResult> GetZones()
        {
            try
            {
                return Ok(await _zoneService.GetList());
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
