using Microsoft.AspNetCore.Mvc;
using TesteHouseEasy.Contracts;
using TesteHouseEasy.Models;
using TesteHouseEasy.Models.Contract;
using TesteHouseEasy.Models.DTO;

namespace TesteHouseEasy.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IRepositoryBase<UserModel> _repositoryBase;
        public UserController(
            ILogger<UserModel> logger,
            IRepositoryBase<UserModel> repositoryBase
            )
        {
            _repositoryBase = repositoryBase;
        }


        [HttpGet]
        public async Task<ResultRequest> GetAll()
        {
            try
            {
                IEnumerable<UserModel> getAllResponse = await _repositoryBase.GetAll();
                var list = getAllResponse.Select(x => new UserDTO(x));
                return new ResultRequest(true, getAllResponse);
            }
            catch (Exception ex)
            {
                return new ResultRequest(false, ex);
            }
        }

        [HttpGet("{Id}")]
        public async Task<ResultRequest> GetById(int Id)
        {
            try
            {
                UserModel getByIdResponse = await _repositoryBase.GetById(Id);
                return new ResultRequest(true, new UserDTO(getByIdResponse));
            }
            catch (Exception ex)
            {
                return new ResultRequest(false, ex);
            }
        }

        [HttpPost]
        public async Task<ResultRequest> Insert([FromBody] UserModel entity)
        {
            try
            {
                await _repositoryBase.Insert(entity);
                return new ResultRequest(true, new UserDTO(entity));
            }
            catch (Exception ex)
            {
                return new ResultRequest(false, ex);
            }
        }

        [HttpPut]
        public async Task<ResultRequest> Update([FromBody] UserModel entity)
        {
            try
            {
                _repositoryBase.Update(entity);
                return new ResultRequest(true, new UserDTO(entity));
            }
            catch (Exception ex)
            {
                return new ResultRequest(false, ex);
            }
        }

        [HttpDelete("DeleteById/{id}")]
        public async Task<ResultRequest> DeleteById(int id)
        {
            try
            {
                await _repositoryBase.Delete(id);
                return new ResultRequest(true, id);
            }
            catch (Exception ex)
            {
                return new ResultRequest(false, ex);
            }
        }
    }
}
