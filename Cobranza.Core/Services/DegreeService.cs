using Cobranza.Core.Interfaces;
using Cobranza.Core.Models;

namespace Cobranza.Core.Services
{
    public class DegreeService : IDegreeService
    {
        public async Task<List<Degree>> GetList()
        {
            return new List<Degree> { new Degree { Code = "001", Description = "Primero" }, new Degree { Code = "002", Description = "Segundo" } };
        }
    }
}
