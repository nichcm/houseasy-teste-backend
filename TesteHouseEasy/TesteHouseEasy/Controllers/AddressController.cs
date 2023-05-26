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
    public class AddressController : Controller
    {
        private readonly IRepositoryBase<AddressModel> _repositoryBase;
        private readonly IMapper _mapper;
        public AddressController(
            ILogger<AddressModel> logger,
            IRepositoryBase<AddressModel> repositoryBase,
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
                IEnumerable<AddressModel> getAllResponse = await _repositoryBase.GetAll();
                var list = getAllResponse.Select(x => new AddressDTO(x));
                return new ResultRequest(true, list);
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
                AddressModel getByIdResponse = await _repositoryBase.GetById(Id);

                return new ResultRequest(true, new AddressDTO(getByIdResponse));
            }
            catch (Exception ex)
            {
                return new ResultRequest(false, ex);
            }
        }

        [HttpPost]
        public async Task<ResultRequest> Insert([FromBody] AddressDTO entity)
        {
            try
            {
                var addressModel = _mapper.Map<AddressDTO, AddressModel>(entity);
                await _repositoryBase.Insert(addressModel);
                return new ResultRequest(true, new AddressDTO(addressModel));
            }
            catch (Exception ex)
            {
                return new ResultRequest(false, ex);
            }
        }

        [HttpPut]
        public async Task<ResultRequest> Update([FromBody] AddressDTO entity)
        {
            try
            {
                var addressModel = _mapper.Map<AddressDTO, AddressModel>(entity);
                await _repositoryBase.Update(addressModel);
                return new ResultRequest(true, new AddressDTO(addressModel));
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
                return new ResultRequest(true, _repositoryBase.Delete(id));
            }
            catch (Exception ex)
            {
                return new ResultRequest(false, ex);
            }
        }

    }
}
