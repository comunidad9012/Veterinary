using Veterinary.DomainClass.Entity;

namespace Veterinary.Core.DTOs
{
    public class PetFullDto
    {
        public string? petName { get; set; }
        public long clientId { get; set; }
        public long typeId { get; set; }
    }
}
