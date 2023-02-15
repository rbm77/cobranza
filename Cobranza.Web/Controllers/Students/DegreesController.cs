using Cobranza.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Cobranza.Web.Controllers.Students
{
    public class DegreesController : Controller
    {
        private readonly IDegreeService _degreeService;

        public DegreesController(IDegreeService degreeService)
        {
            _degreeService = degreeService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("api/{controller}")]
        public async Task<IActionResult> GetDegrees()
        {
            try
            {
                return Ok(await _degreeService.GetList());
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
