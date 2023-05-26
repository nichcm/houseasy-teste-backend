using Microsoft.AspNetCore.Mvc;
using TesteHouseEasy.Models.Contract;

namespace TesteHouseEasy.Contracts
{
    public class RepositoryBaseController<TEntity> : Controller where TEntity : BaseModel
    {
        private readonly ServiceException _serviceException;
        private readonly ILogger<TEntity> _logger;
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        public RepositoryBaseController(ILogger<TEntity> logger,
                                     IRepositoryBase<TEntity> repositoryBase,
                                     ServiceException serviceException)
        {
            _logger = logger;
            _repositoryBase = repositoryBase;
            _serviceException = serviceException;
        }

        [HttpGet]
        public async Task<ResultRequest> GetAll()
        {
            try
            {
                 IEnumerable<TEntity> getAllResponse = await _repositoryBase.GetAll();
                return new ResultRequest(true, getAllResponse);
            }
            catch (Exception ex)
            {
                return _serviceException.ResultHandleException(false, ex);
            }
        }

        [HttpGet("{Id}")]
        public async Task<ResultRequest> GetById(int Id)
        {
            try
            {
                TEntity getByIdResponse = await _repositoryBase.GetById(Id);
                return new ResultRequest(true, getByIdResponse);
            }
            catch (Exception ex)
            {
                return _serviceException.ResultHandleException(false, ex);
            }
        }

        [HttpPost]
        public async Task<ResultRequest> Insert([FromBody] TEntity entity)
        {
            try
            {
                await _repositoryBase.Insert(entity);
                return new ResultRequest(true, entity);
            }
            catch (Exception ex)
            {
                return _serviceException.ResultHandleException(false, ex);
            }
        }

        [HttpPut]
        public async Task<ResultRequest> Update([FromBody] TEntity entity)
        {
            try
            {
                _repositoryBase.Update(entity);
                return new ResultRequest(true, entity);
            }
            catch (Exception ex)
            {
                return _serviceException.ResultHandleException(false, ex);
            }
        }

        [HttpDelete("DeleteById/{id}")]
        public async Task<ResultRequest> DeleteById(int id)
        {
            try
            {
                return new ResultRequest(true, _repositoryBase.Delete(id));
            }
            catch (Exception ex)
            {
                return _serviceException.ResultHandleException(false, ex);
            }
        }
    }
}
