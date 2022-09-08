namespace Veterinary.Core.Entities
{
    public class UserRol
    {
        public int RolId { get; set; }
        public string? rol { get; set; }

        //Audit Data
        public DateTime dateUpload { get; set; }
        public DateTime dateUpdate { get; set; }
        public int user { get; set; }
    }
}
