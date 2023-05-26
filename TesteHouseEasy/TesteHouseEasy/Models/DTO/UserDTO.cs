namespace TesteHouseEasy.Models.DTO
{
    public class UserDTO
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public int OccupationModelId { get; set; }

        public UserDTO() { }

        public UserDTO(UserModel user)
        {
            Name = user.Name;
            Age = user.Age;
            Gender = user.Gender;
            Email = user.Email;
            OccupationModelId = user.OccupationModelId;
        }
    }
}
