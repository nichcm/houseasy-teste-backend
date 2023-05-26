using apiFundadores.Data;
using TesteHouseEasy.Contracts;
using TesteHouseEasy.Models;

namespace TesteHouseEasy.Repositories
{
    public class AddressRepository : RepositoryBase<AddressModel>
    {
        public AddressRepository(SistemaDbContext dBContext) : base(dBContext)
        {
        }
    }
}
