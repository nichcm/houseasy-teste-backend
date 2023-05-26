using AutoMapper;
using TesteHouseEasy.Models;
using TesteHouseEasy.Models.DTO;

namespace TesteHouseEasy.Mappings
{
    public class EntitiesToDTOMappingProfile :Profile
    {
        public EntitiesToDTOMappingProfile() 
        {
            CreateMap<AddressModel,AddressDTO>().ReverseMap();
            CreateMap<OccupationModel, OccupationDTO>().ReverseMap();
            CreateMap<PhoneModel, PhoneDTO>().ReverseMap();
            CreateMap<UserModel, UserDTO>().ReverseMap();
        }
    }
}
