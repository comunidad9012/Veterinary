using DomainClass.Common;

namespace Veterinary.DomainClass.Entity
{
    public class Pet : BaseEntity
    {
        public string? petName { get; set; }
        public int clientId { get; set; }
        public int typeId { get; set; }
    }
}
