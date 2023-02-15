using Cobranza.Core.Models;

namespace Cobranza.Core.Interfaces
{
    public interface IRouteService
    {
        Task<List<Route>> GetList();
    }
}
