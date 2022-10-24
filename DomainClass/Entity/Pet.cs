using DomainClass.Common;

namespace Veterinary.DomainClass.Entity
{
    public class Pet : BaseEntity
    {
        public string? petName { get; set; }
        public long clientId { get; set; }
        public long typeId { get; set; }

        //Foreing keys
        public ICollection<PetType>? petType { get; set; }
        public ICollection<Client>? client { get; set; }
    }
}
