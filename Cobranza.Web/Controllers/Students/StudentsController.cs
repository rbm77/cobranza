using Microsoft.AspNetCore.Mvc;

namespace Cobranza.Web.Controllers.Students
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("{controller}/search")]
        public IActionResult Search()
        {
            return View();
        }

        [Route("{controller}/new")]
        [Route("{controller}/{studentCode}")]
        public IActionResult CreateOrEdit(string? studentCode)
        {
            return View();
        }
    }
}
