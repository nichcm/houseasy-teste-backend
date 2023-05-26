using TesteHouseEasy.Models.Contract;

namespace TesteHouseEasy.Models.DTO
{
    public class OccupationDTO : BaseModel
    {
        public string? Position { get; set; }
        public string? Department { get; set; }
        public string? Responsibilities { get; set; }
        public string? EmploymentStatus { get; set; }
        public string? Salary { get; set; }

        public OccupationDTO() { }

        public OccupationDTO(OccupationModel occupationModel)
        {
            Id = occupationModel.Id;
            Position = occupationModel.Position;
            Department = occupationModel.Department;
            Responsibilities =  occupationModel.Responsibilities;
            EmploymentStatus = occupationModel.EmploymentStatus;
            Salary = occupationModel.Salary;
        }
    }
}
