using Cobranza.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Cobranza.Web.Controllers.Routes
{
    public class RoutesController : Controller
    {
        private readonly IRouteService _routeService;

        public RoutesController(IRouteService routeService)
        {
            _routeService = routeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("api/{controller}")]
        public async Task<IActionResult> GetRoutes()
        {
            try
            {
                return Ok(await _routeService.GetList());
            }
            catch(Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
