using DomainClass.Common;

namespace Veterinary.DomainClass.Entity
{
    public class Visit : BaseEntity
    {
        public int petId { get; set; }
        public int vetId { get; set; }
        public DateTime visitDate { get; set; }
    }
}