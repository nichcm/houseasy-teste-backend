using apiFundadores.Data;
using Microsoft.EntityFrameworkCore;
using TesteHouseEasy.Contracts;
using TesteHouseEasy.Models;

namespace TesteHouseEasy.Repositories
{
    public class UserRepository : RepositoryBase<UserModel>
    {
        public UserRepository(SistemaDbContext dBContext) : base(dBContext)
        {
        }
    }
}
