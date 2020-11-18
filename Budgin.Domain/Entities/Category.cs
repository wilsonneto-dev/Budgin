using System;

namespace Budgin.Domain.Entities
{
    public class Category
    {
        public Category(Guid id, string title, string icon, string color)
        {
            Id = id;
            Title = title;
            Icon = icon;
            Color = color;
        }

        public Guid Id { get; private set; }
        public String Title { get; private set; }
        public String Icon { get; private set; }
        public String Color { get; private set; }
    }
}