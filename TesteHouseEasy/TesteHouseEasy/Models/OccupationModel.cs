using TesteHouseEasy.Models.Contract;

namespace TesteHouseEasy.Models
{
    public class OccupationModel: BaseModel
    {
        public string? Position { get; set; }
        public string? Department { get; set; }
        public string? Responsibilities { get; set; }
        public string? EmploymentStatus { get; set; }
        public string? Salary { get; set; }
    }
}
