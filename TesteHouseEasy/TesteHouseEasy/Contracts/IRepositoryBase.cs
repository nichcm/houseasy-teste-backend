using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using TesteHouseEasy.Models.Contract;

namespace TesteHouseEasy.Contracts
{
    public interface IRepositoryBase<TEntity> where TEntity : BaseModel
    {
        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> GetAll();
        Task Insert(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(int id);
    }
}
