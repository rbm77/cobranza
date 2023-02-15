using Cobranza.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Cobranza.Web.Controllers.Students
{
    public class GroupsController : Controller
    {
        private readonly IGroupService _groupService;

        public GroupsController(IGroupService groupService)
        {
            _groupService = groupService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("api/degrees/{degreeCode}/{controller}")]
        public async Task<IActionResult> GetGroups(string degreeCode)
        {
            try
            {
                return Ok(await _groupService.GetList(degreeCode));
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
