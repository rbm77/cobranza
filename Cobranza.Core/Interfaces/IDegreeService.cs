using Cobranza.Core.Models;

namespace Cobranza.Core.Interfaces
{
    public interface IDegreeService
    {
        Task<List<Degree>> GetList();
    }
}
