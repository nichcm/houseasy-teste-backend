using TesteHouseEasy.Models.Contract;
using TesteHouseEasy.Models.DTO;

namespace TesteHouseEasy.Models
{
    public class AddressModel: BaseModel
    {
        public string? ZipCode { get; set; }
        public string? Street { get; set; }
        public string? Complement { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }

        public int UserModelId { get; set; }
        public virtual UserModel? UserModel { get; set; }

    }
}
