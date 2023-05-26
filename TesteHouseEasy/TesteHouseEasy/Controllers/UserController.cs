using AutoMapper;
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
        private readonly IMapper _mapper;
        public UserController(
            ILogger<UserModel> logger,
            IRepositoryBase<UserModel> repositoryBase,
            IMapper mapper
            )
        {
            _repositoryBase = repositoryBase;
            _mapper = mapper;
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
        public async Task<ResultRequest> Insert([FromBody] UserDTO entity)
        {
            try
            {
                var userModel = _mapper.Map<UserDTO, UserModel>(entity);
                await _repositoryBase.Insert(userModel);
                return new ResultRequest(true, new UserDTO(userModel));
            }
            catch (Exception ex)
            {
                return new ResultRequest(false, ex);
            }
        }

        [HttpPut]
        public async Task<ResultRequest> Update([FromBody] UserDTO entity)
        {
            try
            {
                var userModel = _mapper.Map<UserDTO, UserModel>(entity);
                await _repositoryBase.Update(userModel);
                return new ResultRequest(true, new UserDTO(userModel));
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
