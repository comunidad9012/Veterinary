using DomainClass.Common;

namespace Veterinary.Core.Entities
{
    public class Client : BaseEntity
    {
        public string? clientName { get; set; }
        public string? clientSurname { get; set; }
        public string? clientAdress { get; set; }
        public string? clientPhoneNum { get; set; }
        public string? clientIdn { get; set; }
    }
}
