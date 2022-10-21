namespace ApplicationsServices.DTOs
{
    public class AddUserDto
    {
        public string name { get; set; }
        public string userSurname { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string? userPhoneNumber { get; set; }
        public long userRol { get; set; }
    }
}
