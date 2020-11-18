using System;

namespace Budgin.Domain.Entities
{
    public class Moviment
    {
        public Moviment(Guid id, string description, decimal value, bool executed, Guid categoryId, Guid accountId)
        {
            Id = id;
            Description = description;
            Value = value;
            Executed = executed;
            CategoryId = categoryId;
            AccountId = accountId;
        }

        public Guid Id { get; private set; }
        public String Description { get; private set; }
        public Decimal Value { get; set; }
        public Boolean Executed { get; set; } 

        public Guid CategoryId { get; private set; }
        public Guid AccountId { get; private set; }

        public Category category { get; private set; }
        public Account Account { get; private set; }
    }
}