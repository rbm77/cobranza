using Cobranza.Core.Interfaces;
using Cobranza.Core.Models;

namespace Cobranza.Core.Services
{
    public class ZoneService : IZoneService
    {
        public async Task<List<Zone>> GetList()
        {
            return new List<Zone> { new Zone { Code = "001", Description = "Alto Murillo" }, new Zone { Code = "002", Description = "Cementerio" } };
        }
    }
}
