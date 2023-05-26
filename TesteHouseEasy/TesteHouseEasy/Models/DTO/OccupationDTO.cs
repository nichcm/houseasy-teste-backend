namespace TesteHouseEasy.Models.DTO
{
    public class OccupationDTO
    {
        public string? Position { get; set; }
        public string? Department { get; set; }
        public string? Responsibilities { get; set; }
        public string? EmploymentStatus { get; set; }
        public string? Salary { get; set; }
        public int UserModelId { get; set; }

        public OccupationDTO() { }

        public OccupationDTO(OccupationModel occupationModel)
        {
            Position = occupationModel.Position;
            Department = occupationModel.Department;
            Responsibilities =  occupationModel.Responsibilities;
            EmploymentStatus = occupationModel.EmploymentStatus;
            Salary = occupationModel.Salary;
            UserModelId = occupationModel.UserModelId;
        }
    }
}
