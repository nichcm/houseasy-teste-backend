using TesteHouseEasy.Models.Contract;

namespace TesteHouseEasy.Models.DTO
{
    public class PhoneDTO : BaseModel
    {
        public string? Phone { get; set; }
        public int UserModelId { get; set; }

        public PhoneDTO() { }

        public PhoneDTO(PhoneModel phoneModel)
        {
            Id = phoneModel.Id;
            Phone = phoneModel.Phone;
        }
    }
}
