using DomainClass.Common;

namespace Veterinary.DomainClass.Entity
{
    public class PetType : BaseEntity
    {
        public int typeId { get; set; }
        public string? type { get; set; }

    }
}
