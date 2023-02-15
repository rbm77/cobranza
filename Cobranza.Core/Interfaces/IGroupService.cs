using Cobranza.Core.Models;

namespace Cobranza.Core.Interfaces
{
    public interface IGroupService
    {
        Task<List<Group>> GetList(string degreeCode);
    }
}
