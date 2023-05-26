using apiFundadores.Data;
using System.Numerics;
using TesteHouseEasy.Contracts;
using TesteHouseEasy.Models;

namespace TesteHouseEasy.Repositories
{
    public class PhoneRepository : RepositoryBase<PhoneModel>
    {
      public PhoneRepository(SistemaDbContext dBContext) : base(dBContext)
        {
        }
    }
}
