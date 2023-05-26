using TesteHouseEasy.Models.Contract;

namespace TesteHouseEasy.Models
{
    public class PhoneModel: BaseModel
    {
        public string? Phone { get; set; }
        public int UserModelId { get; set; }
        public virtual UserModel? UserModel { get; set; }
    }
}
