using DomainClass.Common;

namespace Veterinary.DomainClass.Entity
{
    public class VisitDetail : BaseEntity
    {
        public int visitId { get; set; }
        public int procedureId { get; set; }
        public string? price { get; set; }

    }
}
