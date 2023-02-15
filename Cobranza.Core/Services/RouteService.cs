using Cobranza.Core.Interfaces;
using Cobranza.Core.Models;

namespace Cobranza.Core.Services
{
    public class RouteService : IRouteService
    {
        public async Task<List<Route>> GetList()
        {
            return new List<Route> { new Route { Code = "001", Description = "San Juan" }, new Route { Code = "002", Description = "Candelaria" } };
        }
    }
}
