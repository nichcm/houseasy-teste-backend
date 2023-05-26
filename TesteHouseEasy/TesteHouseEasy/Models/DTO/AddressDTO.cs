using TesteHouseEasy.Models.Contract;

namespace TesteHouseEasy.Models.DTO
{
    public class AddressDTO : BaseModel
    {
        public string? ZipCode { get; set; }
        public string? Street { get; set; }
        public string? Complement { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public int UserModelId { get; set; }

        public AddressDTO() { }

        public AddressDTO(AddressModel addressModel) 
        {
            Id = addressModel.Id;
            ZipCode = addressModel.ZipCode; 
            Street = addressModel.Street;    
            Complement = addressModel.City;
            City = addressModel.State;
            State = addressModel.Country;
            Country = addressModel.Country;
            UserModelId = addressModel.UserModelId;

        }

    }
}
