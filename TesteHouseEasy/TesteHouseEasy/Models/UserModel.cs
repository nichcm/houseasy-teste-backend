using TesteHouseEasy.Models.Contract;

namespace TesteHouseEasy.Models
{
    public class UserModel: BaseModel
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public int OccupationModelId { get; set; }
        public virtual OccupationModel? OccupationModel { get; set; }
     
    }
}
