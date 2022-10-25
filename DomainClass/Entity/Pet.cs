﻿using DomainClass.Common;

namespace Veterinary.DomainClass.Entity
{
    public class Pet : BaseEntity
    {
        public string? petName { get; set; }
        public long clientId { get; set; }
        public long typeId { get; set; }

        public ICollection<PetType> petTypes { get; set; }
        public ICollection<Client> clients { get; set; }
    }
}
