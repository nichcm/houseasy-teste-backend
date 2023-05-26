using apiFundadores.Data;
using Microsoft.EntityFrameworkCore;
using System.Data;
using TesteHouseEasy.Models.Contract;

namespace TesteHouseEasy.Contracts
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : BaseModel
    {
        private SistemaDbContext _dBContext;

        protected RepositoryBase(SistemaDbContext dBContext) 
        {
            _dBContext = dBContext ?? throw new ArgumentNullException(nameof(dBContext));
        }

        public async Task Delete(int id)
        {
                var entity = await GetById(id);
                _dBContext.Set<TEntity>().Remove(entity);
                await _dBContext.SaveChangesAsync();
            try
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            try
            {
                return await _dBContext.Set<TEntity>().AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<TEntity> GetById(int id)
        {
            try
            {
                return await _dBContext.Set<TEntity>().FindAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public async Task Insert(TEntity entity)
        {
            try
            {
                await _dBContext.Set<TEntity>().AddAsync(entity);
                await _dBContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public async Task Update(TEntity entity)
        {
            try
            {
                _dBContext.Set<TEntity>().Update(entity);
                await _dBContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
