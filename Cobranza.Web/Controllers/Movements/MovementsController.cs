using Cobranza.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cobranza.Web.Controllers.Movements
{
    public class MovementsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("{controller}/new/{studentCode}")]
        public IActionResult Create(string studentCode)
        {
            Movement movement = new()
            {
                DateTime = DateTime.Now,
                WeekPrice = 0,
                Student = new() { Code = studentCode, Name = "Juano", LastName = "Mora" }
            };
            return View(movement);
        }
    }
}
