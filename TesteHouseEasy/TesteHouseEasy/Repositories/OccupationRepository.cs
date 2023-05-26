using apiFundadores.Data;
using TesteHouseEasy.Contracts;
using TesteHouseEasy.Models;

namespace TesteHouseEasy.Repositories
{
    public class OccupationRepository : RepositoryBase<OccupationModel>
    {
        public OccupationRepository(SistemaDbContext dBContext) : base(dBContext)
        {
        }
    }
}
