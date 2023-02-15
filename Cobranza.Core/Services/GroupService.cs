using Cobranza.Core.Interfaces;
using Cobranza.Core.Models;

namespace Cobranza.Core.Services
{
    public class GroupService : IGroupService
    {
        public async Task<List<Group>> GetList(string degreeCode)
        {
            return new List<Group> { new Group { Code = "001", Description = "A" }, new Group { Code = "002", Description = "B" } };
        }
    }
}
