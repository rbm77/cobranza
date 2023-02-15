using Cobranza.Core.Models;

namespace Cobranza.Core.Interfaces
{
    public interface IZoneService
    {
        Task<List<Zone>> GetList();
    }
}
