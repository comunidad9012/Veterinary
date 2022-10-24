using DomainClass.Common;

namespace Veterinary.DomainClass.Entity
{
    public class VisitDetail : BaseEntity
    {
        public long visitId { get; set; }
        public long procedureId { get; set; }
        public string? price { get; set; }

        //Foreing Keys

        public ICollection<Visit>? visit { get; set; }
        public ICollection<Procedure>? procedure { get; set; }

    }
}
