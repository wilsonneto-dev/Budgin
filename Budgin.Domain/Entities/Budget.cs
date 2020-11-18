using System;

namespace Budgin.Domain.Entities
{
    public class Budget
    {
        public Budget(Guid id, decimal limit, Guid categoryId)
        {
            Id = id;
            Limit = limit;
            CategoryId = categoryId;
        }

        public Guid Id { get; private set; }
        public Decimal Limit { get; private set; }

        public Guid CategoryId { get; private set; }
        public Category Category { get; set; }
    }
} 