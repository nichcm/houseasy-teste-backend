namespace TesteHouseEasy.Models.DTO
{
    public class PhoneDTO
    {
        public string? Phone { get; set; }
        public int UserModelId { get; set; }

        public PhoneDTO() { }

        public PhoneDTO(PhoneModel phoneModel)
        {
            Phone = phoneModel.Phone;
        }
    }
}
