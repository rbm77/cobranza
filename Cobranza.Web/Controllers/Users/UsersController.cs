using Microsoft.AspNetCore.Mvc;

namespace Cobranza.Web.Controllers.Users
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("{controller}/new")]
        [Route("{controller}/{userCode}")]
        [Route("students/{studentCode}/contacts/new")]
        [Route("students/{studentCode}/contacts/{userCode}")]
        public IActionResult CreateOrEdit(string? userCode, string? studentCode)
        {
            return View();
        }
    }
}
